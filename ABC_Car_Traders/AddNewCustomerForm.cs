using ABC_Car_Traders.Controllers;
using ABC_Car_Traders.Model;
using Microsoft.EntityFrameworkCore;
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
    public partial class AddNewCustomerForm : Form
    {
        public readonly UserController _userController;
        public AddNewCustomerForm(UserController userController)
        {
            _userController = userController;
            InitializeComponent();
            LoadRoles();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //var selectedRoleId = (int)cmbRole.SelectedValue;

                var user = new User()
                {
                    firstName = txtFirstName.Text,
                    lastName = txtLastName.Text,
                    email = txtEmail.Text,
                    address = txtAddress.Text,
                    contactNo = txtContactNo.Text,
                    nic = txtNic.Text,
                    status = "ACT",
                    userName = txtUserName.Text,    
                    password = txtPassword.Text,
                    roleId = 2,

                };
                _userController.AddUser(user);
                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Error: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void LoadRoles()
        {
            //var roles = _userController.GetAllRoles();
            //cmbRole.DisplayMember = "role";
            //cmbRole.ValueMember = "roleId";
            //cmbRole.DataSource = roles;
        }
    }
}
