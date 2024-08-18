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
        private Form activeForm = null;
        public CustomerDashboard(CarController carController)
        {
            InitializeComponent();
            _carController = carController;
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
            loadForm(new CustomerDashboardCarPartsDetailsForm());
        }

        private void ManageCustomerOrders_Click(object sender, EventArgs e)
        {
            loadForm(new CustomerDashboardMyOrdersForm());
        }
    }
}
