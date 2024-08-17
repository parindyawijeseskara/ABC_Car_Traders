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
                /* DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                 btn.Name = "Action";
                 btn.HeaderText = "Action";
                 btn.Text = "Action";
                 btn.UseColumnTextForButtonValue = true;*/

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Ensure the cell value is not null
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
    }
}
