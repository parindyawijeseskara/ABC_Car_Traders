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
    public partial class dasboard : Form
    {
        private readonly CarController _carController;
        private readonly CarPartsController _carPartsController;
        private readonly UserController _userController;
        public readonly OrdersController _ordersController;
        public dasboard(CarController carController, CarPartsController carPartsController, UserController userController, OrdersController ordersController)
        {
            InitializeComponent();
            _carController = carController;
            _carPartsController = carPartsController;
            _userController = userController;
            _ordersController = ordersController;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminDashboard_panel3_Paint(object sender, PaintEventArgs e)
        {
            int totalCars = _carController.GetTotalCars();
            int totalCarParts = _carPartsController.GetTotalCarParts();
            int totalCarOrders = _ordersController.GetTotalCarOrders();
            int totalCustomers = _userController.GetTotalUsers();


            labelTotalCars.Text = totalCars.ToString();
            labelTotalCarParts.Text = totalCarParts.ToString();
            labelTotalCarOrders.Text = totalCarOrders.ToString();
            labeltotalCustomers.Text = totalCustomers.ToString();

        }
    }
}
