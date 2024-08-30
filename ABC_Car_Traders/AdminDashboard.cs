﻿using ABC_Car_Traders.Controllers;
using ABC_Car_Traders.DBContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class AdminDashboard : Form
    {
        private Form activeForm = null; // Keep track of the currently active form
        private readonly CarController _carController;
        private readonly CarPartsController _carPartsController;
        private readonly UserController _userController;
        public readonly RegistrationController _controller;
        public AdminDashboard(CarController carController, CarPartsController carPartsController, UserController userController, RegistrationController controller)
        {
            _carController = carController;
            InitializeComponent();
            _carPartsController = carPartsController;
            _userController = userController;
            _controller = controller;
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
            this.adminDashboard_panel3.Controls.Clear();
            this.adminDashboard_panel3.Controls.Add(newForm);
            this.adminDashboard_panel3.Tag = newForm;
            newForm.Show();
        }

        private void adminDashboard_load(object sender, EventArgs e)
        {
            timerDateTime.Start();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            loadForm(new ManageCustomer(_userController));
        }

        private void btnAdminDasboard_Click(object sender, EventArgs e)
        {

            loadForm(new dasboard());
        }

        private void btnManageCars_Click(object sender, EventArgs e)
        {
            loadForm(new ManageCarsForm(_carController));
        }

        private void btnManageCarParts_Click(object sender, EventArgs e)
        {
            loadForm(new ManageCarPartsForm(_carPartsController));
        }

        private void ManageCustomerOrders_Click(object sender, EventArgs e)
        {
            loadForm(new ManageCustomerOrderForm());
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            loadForm(new ManageUsers(_userController));
        }

        private void btnManageReports_Click(object sender, EventArgs e)
        {
            loadForm(new ManageReports());
        }

        private void adminDashboard_panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy, HH:mm:ss");

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close(); 

            // Show the LoginForm
            LoginForm loginForm = new LoginForm(_userController,_controller,_carController,_carPartsController);
            loginForm.Show();
        }
    }
}
