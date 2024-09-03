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
    public partial class CustomerDashboardCarDetailsForm : Form
    {
        private readonly CarController _carController;

        public CustomerDashboardCarDetailsForm(CarController carController)
        {
            InitializeComponent();
            _carController = carController;
            dataGridViewCars.AutoGenerateColumns = false;
            loadCarDetails();

        }
        private void CustomerDashboardCarDetailsForm_Load(object sender, EventArgs e)
        {
            loadCarDetails();
            loadBrands();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridViewCars.Columns["Column11"].Index || e.ColumnIndex == dataGridViewCars.Columns["Column11"].Index))
            {
                if (e.ColumnIndex == dataGridViewCars.Columns["Column11"].Index)
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        // Ensure the cell value is not null
                        if (dataGridViewCars.Rows[e.RowIndex].Cells[3].Value != null)
                        {
                            string carIdString = dataGridViewCars.Rows[e.RowIndex].Cells[0].Value.ToString();

                            // Convert the string to an integer
                            int carId = int.Parse(carIdString);

                            CustomerCarDetailsViewForm form1 = new CustomerCarDetailsViewForm(_carController, carId);
                            form1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Selected car ID is null. Please select a valid car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (e.ColumnIndex == dataGridViewCars.Columns["Column12"].Index)
                {
                    OpenForm2();
                }
            }

        }

        private void OpenForm2()
        {
            CustomerCarPlaceOrderForm form2 = new CustomerCarPlaceOrderForm();
            form2.Show();
        }

        private void loadCarDetails()
        {
            var cars = _carController.GetAllCars();
            dataGridViewCars.DataSource = cars;
        }

        private void loadBrands()
        {
            var carBrands = _carController.GetAllBrands();
            cmbBrand.DataSource = carBrands;
            cmbBrand.DisplayMember = "brandName";
            cmbBrand.ValueMember = "brandId";
            cmbBrand.SelectedIndex = -1;
        }

        public void loadModels(int brandId)
        {
            var carModels = _carController.GetModelsByBrand(brandId);

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


        private void btnSearchModel_Click(object sender, EventArgs e)
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

            // Search cars based on the selected brand and model
            var filteredCars = _carController.SearchCarsByBrandAndModel(selectedBrandId, selectedModelId);

            // Check if any cars were found
            if (filteredCars.Count > 0)
            {
                MessageBox.Show($"{filteredCars.Count} car(s) found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewCars.DataSource = filteredCars;
            }
            else
            {
                MessageBox.Show("No cars found for the selected brand and model.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnSearchYear_Click(object sender, EventArgs e)
        {
            string year = txtYear.Text;
            var filteredYear = _carController.GetAllCarsByYear(year);
            if (filteredYear == null || filteredYear.Count == 0)
            {
                MessageBox.Show($"No cars found for the year {year}.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridViewCars.DataSource = filteredYear;
            }

        }

        private void btnSearchPriceRange_Click(object sender, EventArgs e)
        {
            string priceFromText = txtFromPriceRange.Text;
            string priceToText = txtToPriceRange.Text;

            if (decimal.TryParse(priceFromText, out decimal priceFrom) && decimal.TryParse(priceToText, out decimal priceTo))
            {
                if (priceFrom > priceTo)
                {
                    MessageBox.Show("The starting price should be less than or equal to the ending price.", "Invalid Price Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var filteredCars = _carController.GetAllCarsByPrice(priceFrom, priceTo);
               
                if (filteredCars == null || filteredCars.Count == 0)
                {
                    MessageBox.Show($"No cars found within the price range Rs {priceFrom:N2} to Rs {priceTo:N2}.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataGridViewCars.DataSource = filteredCars;
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbModel.SelectedIndex = -1;
            cmbBrand.SelectedIndex = -1;
            txtYear.Text = string.Empty;
            txtFromPriceRange.Text = string.Empty;
            txtToPriceRange.Text = string.Empty;
            loadCarDetails();
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
    }
}
