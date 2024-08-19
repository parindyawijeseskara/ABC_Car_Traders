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
            loadCarDetails();
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
    }
}
