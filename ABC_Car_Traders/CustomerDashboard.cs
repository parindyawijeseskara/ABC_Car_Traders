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
    public partial class CustomerDashboard : Form
    {
        private readonly CarController _carController;
        private readonly CarPartsController _carPartsController;
        private readonly UserController _userController;
        public readonly RegistrationController _controller;
        private Form activeForm = null;
        public int _userId;
        public CustomerDashboard(CarController carController, CarPartsController carPartsController,UserController userController,RegistrationController registrationController,int userId)
        {
            InitializeComponent();
            _carController = carController;
            _carPartsController = carPartsController;
            _userController = userController;
            _controller = registrationController;
            _userId = userId;
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
            loadForm(new CustomerDashboardDetailsForm());
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
            loadForm(new CustomerDashboardMyOrdersForm(_carController));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();

            // Show the LoginForm
            LoginForm loginForm = new LoginForm(_userController, _controller, _carController, _carPartsController);
            loginForm.Show();
        }
    }
}
