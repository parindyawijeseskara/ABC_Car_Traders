using ABC_Car_Traders.Controllers;
using ABC_Car_Traders.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ABC_Car_Traders
{
    public partial class CustomerDashboardMyOrdersForm : Form
    {
        private readonly CarController _carController;
        public CustomerDashboardMyOrdersForm(CarController carController)
        {
            InitializeComponent();
            _carController = carController;
            dataGridPlaceOrder.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                CustomerMyOrderDetailsViewForm actionForm = new CustomerMyOrderDetailsViewForm();
                actionForm.Show();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCarRegNoOrPartName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCarRegNoOrPartName_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                string input = txtCarRegNoOrPartName.Text.Trim();

                if (string.IsNullOrEmpty(input))
                {
                    ClearCarDetailsFields();
                    MessageBox.Show("Please enter a Car RegNo or Car Part Name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var details = _carController.GetCarOrCarPartDetails(input);

                if (details != null)
                {
                    txtBrand.Text = details.Brand;
                    txtCarModel.Text = details.Model;
                    txtCarRegNoOrPartName.Text = details.ItemName;
                    txtUnitPrice.Text = details.Price.ToString();
                    txtQuantityOnHand.Text = details.Quantity.ToString();
                }
                else
                {
                    MessageBox.Show("No matching car or car part found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearCarDetailsFields();
                }
            }
        }

        //clear the car details fields
        private void ClearCarDetailsFields()
        {
            txtBrand.Text = string.Empty;
            txtCarModel.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtQuantityOnHand.Text = string.Empty;
        }

        private void txtNic_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                string input = txtNic.Text.Trim();

                if (string.IsNullOrEmpty(input))
                {
                    ClearCustomerDetailsFields();
                    MessageBox.Show("Please enter Nic.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var details = _carController.GetCustomerDetailsForOrder(input);

                if (details != null)
                {
                    txtCustomerName.Text = details.Name;
                    txtAddress.Text = details.Address;
                    txtNic.Text = details.ItemName;
                    txtEmail.Text = details.Email;
                    txtContactNo.Text = details.ContactNo;
                }
                else
                {
                    MessageBox.Show("No matching Nic found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearCustomerDetailsFields();
                }

              
            }
        }

        private void ClearCustomerDetailsFields()
        {
            txtCustomerName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNic.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContactNo.Text = string.Empty;
        }
    }
}
