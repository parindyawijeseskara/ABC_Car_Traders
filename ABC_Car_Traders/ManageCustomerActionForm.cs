using ABC_Car_Traders.Controllers;
using ABC_Car_Traders.Model;
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
    public partial class ManageCustomerActionForm : Form
    {
        private readonly UserController _userController;
        private readonly int _userId;
        private User _user;
        public ManageCustomerActionForm(UserController userController, int userId)
        {
            InitializeComponent();
            _userController = userController;
            _userId = userId;
            loadCustomerDetails();
        }

        private void LoadRoles()
        {
            var roles = _userController.GetAllRoles();
            cmbRole.DataSource = roles;
            cmbRole.DisplayMember = "role"; // Display the role description
            cmbRole.ValueMember = "roleId"; // The role ID is used as the value

        }

        public void loadCustomerDetails()
        {
            _user = _userController.getUserById(_userId);
            if (_user == null)
            {
                MessageBox.Show("User not found. Please select a valid userId.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txtFirstName.Text = _user.firstName;
            txtLastName.Text = _user.lastName;
            txtEmail.Text = _user.email;
            txtAddress.Text = _user.address;
            txtContactNo.Text = _user.contactNo;
            txtNic.Text = _user.nic;
            txtUserName.Text = _user.userName;
            txtPassword.Text = _user.password;
            cmbStatus.SelectedItem = _user.status;
            LoadRoles();
            cmbRole.SelectedValue = _user.roleId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _user.firstName = txtFirstName.Text;
                _user.lastName = txtLastName.Text;
                _user.email = txtEmail.Text;
                _user.address = txtAddress.Text;
                _user.contactNo = txtContactNo.Text;
                _user.nic = txtNic.Text;
                _user.status = cmbStatus.Text;
                _user.userName = txtUserName.Text;
                _user.password = txtPassword.Text;
                //_user.roleId = cmbRole.SelectedIndex;
                _userController.updateUser(_user);
                this.Close();
                MessageBox.Show("User Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _userController.deleteUser(_userId);
                this.Close();
                MessageBox.Show("User Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
