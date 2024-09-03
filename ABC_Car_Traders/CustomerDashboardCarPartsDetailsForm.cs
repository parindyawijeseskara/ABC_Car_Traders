using ABC_Car_Traders.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class CustomerDashboardCarPartsDetailsForm : Form
    {
        private readonly CarPartsController _carPartsController;
        public CustomerDashboardCarPartsDetailsForm(CarPartsController carPartsController)
        {
            InitializeComponent();
            _carPartsController = carPartsController;
            cmbBrand.SelectedIndexChanged += cmbBrand_SelectedIndexChanged;
            dataGridViewCarParts.AutoGenerateColumns = false;
        }
        private void CustomerDashboardCarPartsDetailsForm_Load(object sender, EventArgs e)
        {
            loadCarPartDetails();
            loadBrands();
        }

        private void dataGridViewCarParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridViewCarParts.Columns["Column11"].Index))
            {
                if (e.ColumnIndex == dataGridViewCarParts.Columns["Column11"].Index)
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        // Ensure the cell value is not null
                        if (dataGridViewCarParts.Rows[e.RowIndex].Cells[3].Value != null)
                        {
                            int carPartId = (int)dataGridViewCarParts.Rows[e.RowIndex].Cells[0].Value;
                            CustomerCarPartsDetailViewForm form1 = new CustomerCarPartsDetailViewForm(_carPartsController, carPartId);
                            form1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Selected car ID is null. Please select a valid car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (e.ColumnIndex == dataGridViewCarParts.Columns["Column12"].Index)
                {
                    OpenForm2();
                }
            }
        }

        private void OpenForm1()
        {
            //CustomerCarPartsDetailViewForm form1 = new CustomerCarPartsDetailViewForm();
            //form1.Show();

        }

        private void OpenForm2()
        {
            CustomerCarPartsPlaceOrderForm form2 = new CustomerCarPartsPlaceOrderForm();
            form2.Show();
        }

        private void loadCarPartDetails()
        {
            var carParts = _carPartsController.GetAllCarParts();
            dataGridViewCarParts.DataSource = carParts;

        }

        private void loadBrands()
        {
            var carBrands = _carPartsController.GetAllBrands();
            cmbBrand.DataSource = carBrands;
            cmbBrand.DisplayMember = "brandName";
            cmbBrand.ValueMember = "brandId";
            cmbBrand.SelectedIndex = -1;
        }

        public void loadModels(int brandId)
        {
            var carModels = _carPartsController.GetModelsByBrand(brandId);

            if (carModels.Count == 0)
            {
                MessageBox.Show("No models found for the selected brand.");
            }
            else
            {
                cmbModel.DataSource = carModels;
                cmbModel.DisplayMember = "modelName";
                cmbModel.ValueMember = "modelId";
                cmbModel.SelectedIndex = -1;
            }
        }

        private void btnSearchByCartPartName_Click(object sender, EventArgs e)
        {
            string partName = txtCarPartName.Text.Trim();
            if (string.IsNullOrEmpty(partName))
            {
                MessageBox.Show("Please enter an regNo to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filteredCars = _carPartsController.GetCarsByPartName(partName);

            if (filteredCars.Count == 0)
            {
                MessageBox.Show("No cars found with the specified regNo.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridViewCarParts.DataSource = filteredCars;
            }
        }

        private void txtSearchModel_Click(object sender, EventArgs e)
        {
            // Check if the brand and model are selected
            if (cmbBrand.SelectedIndex == -1 || cmbModel.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both a brand and a model.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve the selected brand and model IDs
            int selectedBrandId = Convert.ToInt32(cmbBrand.SelectedValue);
            int selectedModelId = Convert.ToInt32(cmbModel.SelectedValue);

            // Search car parts based on the selected brand and model
            var filteredCars = _carPartsController.SearchCarPartsByBrandAndModel(selectedBrandId, selectedModelId);

            // Check if any cars were found
            if (filteredCars.Count > 0)
            {
                // If cars are found, display a success message and load the data into the DataGridView
                MessageBox.Show($"{filteredCars.Count} car(s) found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewCarParts.DataSource = filteredCars;
            }
            else
            {
                MessageBox.Show("No cars found for the selected brand and model.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBrand.SelectedIndex != -1)
            {
                var selectedValue = cmbBrand.SelectedValue;
                if (selectedValue is int selectedBrandId)
                {
                    loadModels(selectedBrandId);
                }
                //else
                //{
                //    MessageBox.Show("Invalid brand selection. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void SearchByPriceRange_Click(object sender, EventArgs e)
        {
            string priceFromText = txtFromPrice.Text;
            string priceToText = txtToPrice.Text;

            if (decimal.TryParse(priceFromText, out decimal priceFrom) && decimal.TryParse(priceToText, out decimal priceTo))
            {
                if (priceFrom > priceTo)
                {
                    MessageBox.Show("The starting price should be less than or equal to the ending price.", "Invalid Price Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var filteredCars = _carPartsController.GetAllCarPartsByPrices(priceFrom, priceTo);
                if (filteredCars == null || filteredCars.Count == 0)
                {
                    MessageBox.Show($"No cars found within the price range Rs {priceFrom:N2} to Rs {priceTo:N2}.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataGridViewCarParts.DataSource = filteredCars;
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbBrand.SelectedIndex = -1;
            cmbModel.SelectedIndex = -1;
            txtCarPartName.Text = string.Empty;
            txtToPrice.Text = string.Empty;
            txtFromPrice.Text = string.Empty;
            loadCarPartDetails();
        }
    }
}
