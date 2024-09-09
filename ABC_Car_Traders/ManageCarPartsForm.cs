using ABC_Car_Traders.Controllers;
using ABC_Car_Traders.Model;
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
    public partial class ManageCarPartsForm : Form
    {
        private readonly CarPartsController _controller;

        public ManageCarPartsForm(CarPartsController carPartsController)
        {
            _controller = carPartsController;
            InitializeComponent();
            loadCarParts();
            loadBrands();
            dataGridViewCarParts.AutoGenerateColumns = false;

        }

        private void btnAddNewCarPart_Click(object sender, EventArgs e)
        {
            AddNewCarPartsForm addNewCarPartsForm = new AddNewCarPartsForm(_controller);
            addNewCarPartsForm.Show();
        }

        private void loadCarParts()
        {
            var carParts = _controller.GetAllCarParts();
            dataGridViewCarParts.DataSource = carParts;

        }

        private void loadBrands()
        {
            var carBrands = _controller.GetAllBrands();
            cmbBrand.DataSource = carBrands;
            cmbBrand.DisplayMember = "brandName";
            cmbBrand.ValueMember = "brandId";
            cmbBrand.SelectedIndex = -1;
        }

        public void loadModels(int brandId)
        {
            var carModels = _controller.GetModelsByBrand(brandId);

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

            // Get the selected brand and model IDs
            int selectedBrandId = Convert.ToInt32(cmbBrand.SelectedValue);
            int selectedModelId = Convert.ToInt32(cmbModel.SelectedValue);

            // Search car parts based on the selected brand and model
            var filteredCarParts = _controller.SearchCarPartsByBrandAndModel(selectedBrandId, selectedModelId);

            // Check if any cars were found
            if (filteredCarParts.Count > 0)
            {
                MessageBox.Show($"{filteredCarParts.Count} car(s) found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewCarParts.DataSource = filteredCarParts;
            }
            else
            {
                MessageBox.Show("No car parts found for the selected brand and model.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
        }

        private void txtSearchName_Click(object sender, EventArgs e)
        {
            string carPartName = txtName.Text.Trim();
            if (string.IsNullOrEmpty(carPartName))
            {
                MessageBox.Show("Please enter an Part Name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filteredCarParts = _controller.GetCarsByPartName(carPartName);

            if (filteredCarParts.Count == 0)
            {
                MessageBox.Show("No cars found with the specified Part Name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridViewCarParts.DataSource = filteredCarParts;
            }
        }

        private void txtSearchStatus_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCarParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Ensure the carId column exists and has a value
                if (dataGridViewCarParts.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    try
                    {
                        // Convert the carId value to an integer
                        int carPartId = Convert.ToInt32(dataGridViewCarParts.Rows[e.RowIndex].Cells[0].Value);

                        // Show the ManageCarActionForm popup
                        ManageCarPartsActionForm actionForm = new ManageCarPartsActionForm(_controller, carPartId);
                        actionForm.Show();
                    }
                    catch (InvalidCastException ex)
                    {
                        MessageBox.Show($"Invalid Car Part ID. Expected an integer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selected car ID is null. Please select a valid car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
