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
    public partial class AdminDashboard : Form
    {
        private Form activeForm = null; // Keep track of the currently active form
        private readonly CarController _carController;
        private readonly CarPartsController _carPartsController;
        public AdminDashboard(CarController carController, CarPartsController carPartsController)
        {
            _carController = carController;
            InitializeComponent();
            _carPartsController = carPartsController;
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
            //int width = Screen.PrimaryScreen.Bounds.Width;
            //int height = Screen.PrimaryScreen.Bounds.Height;
            //this.Location = new Point(0, 0);
            //this.Size = new Size(width, height);
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            loadForm(new ManageCustomer());
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
            loadForm(new ManageUsers());
        }

        private void btnManageReports_Click(object sender, EventArgs e)
        {
            loadForm(new ManageReports());
        }
    }
}
