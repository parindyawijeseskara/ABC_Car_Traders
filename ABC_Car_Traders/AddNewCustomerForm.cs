﻿using ABC_Car_Traders.Controllers;
using ABC_Car_Traders.Model;
using ABC_Car_Traders.Validation;
using Microsoft.EntityFrameworkCore;
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
    public partial class AddNewCustomerForm : Form
    {
        public readonly UserController _userController;
        public AddNewCustomerForm(UserController userController)
        {
            _userController = userController;
            InitializeComponent();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any fields are empty
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtContactNo.Text) ||
                    string.IsNullOrWhiteSpace(txtNic.Text) ||
                    string.IsNullOrWhiteSpace(txtUserName.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Validate the form
                if (!ValidateFields())
                {
                    MessageBox.Show("Please correct the highlighted errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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
                MessageBox.Show("Added customer successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Validate form feilds
        private bool ValidateFields()
        {
            bool isValid = true;

            // Validate First Name
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || !Regex.IsMatch(txtFirstName.Text, PatternValidation.namePattern))
            {
                lblFirstNameError.Text = "Please enter a valid first name.";
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
                lblLastNameError.Text = "Please enter a valid last name.";
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
                lblEmailError.Text = "Please enter a valid email address.";
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
                lblAddressError.Text = "Please enter a valid address.";
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
                lblcontactNoError.Text = "Please enter a valid contact number.";
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
                lblNicError.Text = "Please enter a valid NIC.";
                lblNicError.Visible = true;
                isValid = false;
            }
            else
            {
                lblNicError.Visible = false;
            }

            // Validate Username
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || !Regex.IsMatch(txtUserName.Text, PatternValidation.userNamePattern))
            {
                lblUserNameError.Text = "Please enter a valid username.";
                lblUserNameError.Visible = true;
                isValid = false;
            }
            else
            {
                lblUserNameError.Visible = false;
            }

            // Validate Password
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || !Regex.IsMatch(txtPassword.Text, PatternValidation.passwordPattern))
            {
                lblPasswordError.Text = "Please enter a valid password.";
                lblPasswordError.Visible = true;
                isValid = false;
            }
            else
            {
                lblPasswordError.Visible = false;
            }

            return isValid;
        }




    }
}
