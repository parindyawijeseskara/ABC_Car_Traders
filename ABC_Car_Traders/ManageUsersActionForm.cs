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
    public partial class ManageUsersActionForm : Form
    {
        private readonly UserController _userController;
        private readonly int _userId;
        private User _user;
        public ManageUsersActionForm(UserController userController, int userId)
        {
            InitializeComponent();
            _userController = userController;
            _userId = userId;
            loadUserDetails();
        }
        private void LoadRoles()
        {
            var roles = _userController.GetAllRoles();
            cmbRole.DataSource = roles;
            cmbRole.DisplayMember = "role";
            cmbRole.ValueMember = "roleId"; 

        }

        public void loadUserDetails()
        {
            _user = _userController.getUserById(_userId);
            if (_user == null)
            {
                MessageBox.Show("User not found. Please select a valid userId.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txtCustomerName.Text = _user.firstName;
            txtEmail.Text = _user.email;
            txtRegistrationDate.Text = null;
            LoadRoles();
            cmbRole.SelectedValue = _user.roleId;
            cmbStatus.SelectedValue = _user.status;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _user.firstName = txtCustomerName.Text;
                _user.email = txtEmail.Text;
                // _user.createdAt = txtRegistrationDate.Text;     
                //_user.roleId = cmbRole.SelectedIndex;
                //_user.status = cmbStatus.Text;
                if (cmbRole.SelectedValue != null)
                {
                    _user.roleId = (int)cmbRole.SelectedValue;
                }
                _user.status = cmbStatus.Text;
                DateTime parsedDate;
                if (DateTime.TryParse(txtRegistrationDate.Text, out parsedDate))
                {
                    _user.createdAt = parsedDate;
                }
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
