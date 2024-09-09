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
    public partial class ManageCustomer : Form
    {
        private readonly UserController _userController;
        public ManageCustomer(UserController userController)
        {
            InitializeComponent();
            _userController = userController;
            loadUsers();
            loadStatus();
            dataGridViewCustomers.AutoGenerateColumns = false;

        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            AddNewCustomerForm addNewCustomerForm = new AddNewCustomerForm(_userController);
            addNewCustomerForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dataGridViewCustomers.Rows[e.RowIndex].Cells[1].Value != null)
                    {
                        int userId = (int)dataGridViewCustomers.Rows[e.RowIndex].Cells[1].Value;
                        ManageCustomerActionForm actionForm = new ManageCustomerActionForm(_userController, userId);
                        actionForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selected car ID is null. Please select a valid car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void loadUsers()
        {
            var users = _userController.GetAllUsers();
            dataGridViewCustomers.DataSource = users;
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchEmail_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email address to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filteredCustomers = _userController.GetCustomersByEmail(email);

            if (filteredCustomers.Count == 0)
            {
                MessageBox.Show("No customers found with the specified email.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridViewCustomers.DataSource = filteredCustomers;
            }

        }

        public void loadStatus()
        {
            //var customerStatus = _userController.GetCustomersByStatus();
            //cmbStatus.DataSource = customerStatus;
            //cmbStatus.DisplayMember = "status";
            //cmbStatus.SelectedIndex = -1;
        }

        private void btnSearchStatus_Click(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem != null)
            {
                string selectedStatus = cmbStatus.Text; // Get the selected status from the combo box
                var filteredCustomers = _userController.GetCustomersByStatus(selectedStatus);
                dataGridViewCustomers.DataSource = filteredCustomers;
            }
            else
            {
                MessageBox.Show("Please select a status to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = -1;
            txtEmail.Text = string.Empty;
            loadUsers();
        }
    }
}
