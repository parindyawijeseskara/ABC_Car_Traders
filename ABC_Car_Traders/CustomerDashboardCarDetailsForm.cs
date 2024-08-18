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
                    OpenForm1();
                }
                else if (e.ColumnIndex == dataGridViewCars.Columns["Column12"].Index)
                {
                    OpenForm2();
                }
            }

        }

        private void OpenForm1()
        {
            CustomerCarDetailsViewForm form1 = new CustomerCarDetailsViewForm();
            form1.Show();
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
