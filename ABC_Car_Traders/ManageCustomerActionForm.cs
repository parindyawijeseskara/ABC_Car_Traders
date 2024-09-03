using ABC_Car_Traders.Controllers;
using ABC_Car_Traders.Model;
using ABC_Car_Traders.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            //var roles = _userController.GetAllRoles();
            //cmbRole.DataSource = roles;
            //cmbRole.DisplayMember = "role"; // Display the role description
            //cmbRole.ValueMember = "roleId"; // The role ID is used as the value

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
            //cmbStatus.SelectedItem = _user.status;
            // LoadRoles();
            // cmbRole.SelectedValue = _user.roleId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate the form
                if (!ValidateFields())
                {
                    MessageBox.Show("Please enter valid text inputs.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _user.firstName = txtFirstName.Text;
                _user.lastName = txtLastName.Text;
                _user.email = txtEmail.Text;
                _user.address = txtAddress.Text;
                _user.contactNo = txtContactNo.Text;
                _user.nic = txtNic.Text;
                _user.status = "ACT";
                _user.userName = txtUserName.Text;
                _user.password = txtPassword.Text;
                _user.userId = _userId;
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

        private void ManageCustomerActionForm_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateFields()
        {
            bool isValid = true;

            // Validate First Name
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || !Regex.IsMatch(txtFirstName.Text, PatternValidation.namePattern))
            {
                lblFirstNameError.Text = "Invalid first name.";
                lblFirstNameError.Visible = true;
                isValid = false;
            }
            else
            {
                lblFirstNameError.Visible = false;
            }

            // Validate Last Name
            if (string.IsNullOrWhiteSpace(txtLastName.Text) || !Regex.IsMatch(txtLastName.Text, PatternValidation.namePattern))
            {
                lblLastNameError.Text = "Invalid last name.";
                lblLastNameError.Visible = true;
                isValid = false;
            }
            else
            {
                lblLastNameError.Visible = false;
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, PatternValidation.emailPattern))
            {
                lblEmailError.Text = "Invalid email address.";
                lblEmailError.Visible = true;
                isValid = false;
            }
            else
            {
                lblEmailError.Visible = false;
            }

            // Validate Address
            if (string.IsNullOrWhiteSpace(txtAddress.Text) || !Regex.IsMatch(txtAddress.Text, PatternValidation.addressPattern))
            {
                lblAddressError.Text = "Invalid address.";
                lblAddressError.Visible = true;
                isValid = false;
            }
            else
            {
                lblAddressError.Visible = false;
            }

            // Validate Contact No
            if (string.IsNullOrWhiteSpace(txtContactNo.Text) || !Regex.IsMatch(txtContactNo.Text, PatternValidation.contactNoPattern))
            {
                lblcontactNoError.Text = "Invalid contact number.";
                lblcontactNoError.Visible = true;
                isValid = false;
            }
            else
            {
                lblcontactNoError.Visible = false;
            }

            // Validate NIC
            if (string.IsNullOrWhiteSpace(txtNic.Text) || !Regex.IsMatch(txtNic.Text, PatternValidation.nicPattern))
            {
                lblNicError.Text = "Invalid NIC.";
                lblNicError.Visible = true;
                isValid = false;
            }
            else
            {
                lblNicError.Visible = false;
            }

            return isValid;
        }

    }
}
