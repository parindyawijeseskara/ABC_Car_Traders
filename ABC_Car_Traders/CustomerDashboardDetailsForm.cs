using ABC_Car_Traders.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class CustomerDashboardDetailsForm : Form
    {
        private readonly CarController _carController;
        private readonly CarPartsController _carPartsController;
        public readonly OrdersController _ordersController;
        public CustomerDashboardDetailsForm(CarController carController, CarPartsController carPartsController, OrdersController ordersController)
        {
            InitializeComponent();
            _carController = carController;
            _carPartsController = carPartsController;
            _ordersController = ordersController;
        }

        private void CustomerDashboardDetailsForm_Load(object sender, EventArgs e)
        {

            try
            {
                // Get totals
                int totalCars = _carController.GetTotalCars();
                int totalCarParts = _carPartsController.GetTotalCarParts();
                int totalCarOrders = _ordersController.GetTotalCarOrders();
                int totalCarPartOrders = _ordersController.GetTotalCarPartOrders();

                labelTotalCars.Text = totalCars.ToString();
                labelTotalCarParts.Text = totalCarParts.ToString();
                labelTotalCarOrders.Text = totalCarOrders.ToString();
                labelTotalCarPartOrders.Text = totalCarPartOrders.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading dashboard: {ex.Message}");

            }
        }

        private void panelData3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
