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
    public partial class CustomerDashboard : Form
    {
        private readonly CarController _carController;
        private readonly CarPartsController _carPartsController;
        private readonly UserController _userController;
        public readonly RegistrationController _controller;
        public readonly OrdersController _ordersController;
        private Form activeForm = null;
        public int _userId;
        public CustomerDashboard(CarController carController, CarPartsController carPartsController, UserController userController, RegistrationController registrationController, int userId, OrdersController ordersController)
        {
            InitializeComponent();
            _carController = carController;
            _carPartsController = carPartsController;
            _userController = userController;
            _controller = registrationController;
            _userId = userId;
            _ordersController = ordersController;

        }

        public void loadForm(Form newForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }

            // Set the new form as the active form
            activeForm = newForm;

            // Prepare the new form to be displayed in the panel
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            this.customerDashboard_sidepanel3.Controls.Clear();
            this.customerDashboard_sidepanel3.Controls.Add(newForm);
            this.customerDashboard_sidepanel3.Tag = newForm;
            newForm.Show();
        }

        private void btnCustomerDasboard_Click(object sender, EventArgs e)
        {
            loadForm(new CustomerDashboardDetailsForm(_carController, _carPartsController, _ordersController));
        }

        private void btnCarDetails_Click(object sender, EventArgs e)
        {
            loadForm(new CustomerDashboardCarDetailsForm(_carController));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new CustomerDashboardCarPartsDetailsForm(_carPartsController));
        }

        private void ManageCustomerOrders_Click(object sender, EventArgs e)
        {
            loadForm(new CustomerDashboardMyOrdersForm(_carController, _ordersController));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();

            // Show the LoginForm
            LoginForm loginForm = new LoginForm(_userController, _controller, _carController, _carPartsController, _ordersController);
            loginForm.Show();
        }

        private void btnOrderCarParts_Click(object sender, EventArgs e)
        {
            loadForm(new CustomerDashboardCarPartsOrderForm(_carPartsController, _carController, _ordersController));
        }

        private void btnManageProfile_Click(object sender, EventArgs e)
        {
            loadForm(new ManageProfile(_userId, _userController));
        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            loadForm(new MyOrdersForm(_carController, _ordersController));
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                var user = _userController.getUserById(_userId);
                if (user != null)
                {
                    labelLoggedInAs.Text = $"You are logged in as {user.userName}";
                }
                else
                {
                    labelLoggedInAs.Text = "User not found";
                }

                timerDateTime.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the dashboard: {ex.Message}");
            }

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

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy, HH:mm:ss");
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalCars_Click(object sender, EventArgs e)
        {

        }

        private void customerDashboard_sidepanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerDashboard_sidepanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
