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
            dataGridViewCars.AutoGenerateColumns = false; // Ensures columns are not auto-generated
            loadCarDetails();

        }
        private void CustomerDashboardCarDetailsForm_Load(object sender, EventArgs e)
        {
            loadCarDetails();
            loadCarModels();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridViewCars.Columns["Column11"].Index || e.ColumnIndex == dataGridViewCars.Columns["Column12"].Index))
            {
                if (e.ColumnIndex == dataGridViewCars.Columns["Column11"].Index)
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        // Ensure the cell value is not null
                        if (dataGridViewCars.Rows[e.RowIndex].Cells[3].Value != null)
                        {
                            int carId = (int)dataGridViewCars.Rows[e.RowIndex].Cells[3].Value;
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

        //Load car models to the combo box
        public void loadCarModels()
        {
            var carModels = _carController.GetAllCars();
            cmbModel.DataSource = carModels;
            cmbModel.DisplayMember = "model";
            cmbModel.SelectedIndex = -1;
        }

        private void btnSearchModel_Click(object sender, EventArgs e)
        {
            if (cmbModel.SelectedItem != null)
            {
                string selectedModel = cmbModel.Text;
                var filteredCars = _carController.GetCarsByModel(selectedModel);
                dataGridViewCars.DataSource = filteredCars;
            }
            else
            {
                MessageBox.Show("Please select a valid car model.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (decimal.TryParse(priceFromText,out decimal priceFrom) && decimal.TryParse(priceToText,out decimal priceTo))
            {
                if (priceFrom > priceTo)
                {
                    MessageBox.Show("The starting price should be less than or equal to the ending price.", "Invalid Price Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var filteredCars = _carController.GetAllCarsByPrice(priceFrom,priceTo);
                // Check if the result is empty
                if (filteredCars == null || filteredCars.Count == 0)
                {
                    MessageBox.Show($"No cars found within the price range Rs {priceFrom:N2} to Rs {priceTo:N2}.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Bind the filtered result to the DataGridView
                    dataGridViewCars.DataSource = filteredCars;
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbModel.SelectedIndex = -1;
            txtYear.Text = string.Empty;
            txtFromPriceRange.Text = string.Empty;
            txtToPriceRange.Text = string.Empty;
            loadCarDetails();
        }
    }
}
