﻿using ABC_Car_Traders.Controllers;
using ABC_Car_Traders.DBContext;
using ABC_Car_Traders.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ABC_Car_Traders
{
    public partial class ManageCarsForm : Form
    {
        private readonly CarController _carController;
        public ManageCarsForm(CarController carController)
        {
            InitializeComponent();
            _carController = carController;
            loadCars();
            loadBrands();
            LoadStatusOptions();
            cmbBrand.SelectedIndexChanged += cmbBrand_SelectedIndexChanged;
            dataGridViewCars.AutoGenerateColumns = false;

        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            AddNewCarForm addNewCarForm = new AddNewCarForm(_carController);
            addNewCarForm.Show();
        }

        private void dataGridViewCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {

                //int carId = (int)dataGridViewCars.Rows[e.RowIndex].Cells["Column1"].Value;
                //Car car = _carController.getcarById(carId);


                //if (car != null)
                //{
                //var carId = (int)dataGridViewCars.Rows[e.RowIndex].Cells["Column1"].Value;
                //ManageCarActionForm actionForm = new ManageCarActionForm(_carController, carId);
                //actionForm.Show();
                //}
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dataGridViewCars.Rows[e.RowIndex].Cells[1].Value != null)
                    {
                        int carId = (int)dataGridViewCars.Rows[e.RowIndex].Cells[1].Value;
                        ManageCarActionForm actionForm = new ManageCarActionForm(_carController, carId);
                        actionForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selected car ID is null. Please select a valid car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }


        private void loadCars()
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

        private void LoadStatusOptions()
        {
            cmbStatus.Items.Add("AVAILABLE");
            cmbStatus.Items.Add("NOT AVAILABLE");
            cmbStatus.SelectedIndex = -1;
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBrand.SelectedIndex != -1)
            {
                var selectedValue = cmbBrand.SelectedValue;
                if (selectedValue is int selectedBrandId)
                {
                    loadModels(selectedBrandId);  // Load the relevant models based on the selected brand
                }
                //else
                //{
                //    MessageBox.Show("Invalid brand selection. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbBrand.SelectedIndex = -1;
            cmbModel.SelectedIndex = -1;
            txtRegNo.Text = string.Empty;
            loadCars();
        }

        private void searchRegNo_Click(object sender, EventArgs e)
        {
            string regNo = txtRegNo.Text.Trim();
            if (string.IsNullOrEmpty(regNo))
            {
                MessageBox.Show("Please enter an regNo to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filteredCars = _carController.GetCarsByRegNo(regNo);

            if (filteredCars.Count == 0)
            {
                MessageBox.Show("No cars found with the specified regNo.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridViewCars.DataSource = filteredCars;
            }
        }

        private void btnSearchStatus_Click(object sender, EventArgs e)
        {
            //string status = cmbStatus.SelectedItem?.ToString();

            //if (string.IsNullOrEmpty(status))
            //{
            //    MessageBox.Show("Please select a status to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //var filteredCars = _carController.GetCarsByStatus(status);

            //if (filteredCars.Count > 0)
            //{
            //    // If cars are found, display a success message and load the data into the DataGridView
            //    MessageBox.Show($"{filteredCars.Count} car(s) found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    dataGridViewCars.DataSource = filteredCars;  // Update the DataGridView with found cars
            //}
            //else
            //{
            //    // If no cars are found, display an informational message
            //    MessageBox.Show("No cars found for the selected status.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}
