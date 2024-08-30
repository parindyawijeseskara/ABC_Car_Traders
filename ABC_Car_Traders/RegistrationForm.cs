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
using System.Security.Cryptography;
using ABC_Car_Traders.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace ABC_Car_Traders
{
    public partial class RegistrationForm : Form
    {
        public readonly RegistrationController _controller;
        public readonly UserController _userController;
        private readonly CarController _carController;
        private readonly CarPartsController _carPartsController;
        private Form activeForm = null; // Keep track of the currently active form
        public RegistrationForm(RegistrationController controller, UserController userController, CarController carController, CarPartsController carPartsController)
        {
            InitializeComponent();
            _controller = controller;
            _userController = userController;
            _carController = carController;
            _carPartsController = carPartsController;
            LoadRoleUsers();
        }

        public static class PasswordHelper
        {
            public static string HashPassword(string password)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in bytes)
                    {
                        builder.Append(b.ToString("x2"));
                    }
                    return builder.ToString();
                }
            }

            public static bool VerifyPassword(string inputPassword, string storedHash)
            {
                string inputHash = HashPassword(inputPassword);
                return inputHash.Equals(storedHash);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var selectedRoleId = (int)cmbRole.SelectedValue;

            try
            {
                if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
                {
                    MessageBox.Show("Passwords do not match. Please try again.");
                    return;
                }

                var newUser = new User
                {
                    firstName = txtFirstName.Text.Trim(),
                    lastName = txtLastName.Text.Trim(),
                    email = txtEmail.Text.Trim(),
                    address = txtAddress.Text.Trim(),
                    contactNo = txtContactNo.Text.Trim(),
                    nic = txtNic.Text.Trim(),
                    status = "ACT",
                    userName = txtUserName.Text.Trim(),
                    password = PasswordHelper.HashPassword(txtPassword.Text.Trim()),
                    roleId = selectedRoleId
                };

                //UserController userController = new UserController(_userController);
                _userController.AddUser(newUser);

                MessageBox.Show("Registration successful!");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Error: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void LoadRoleUsers()
        {
            var roles = _controller.GetRoles();  // Call the method from UserController to get roles
            cmbRole.DataSource = roles;
            cmbRole.DisplayMember = "Role";  // The name of the role to be displayed
            cmbRole.ValueMember = "RoleId";
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
            //newForm.TopLevel = false;
            //newForm.Dock = DockStyle.Fill;
            //this.LoginForm.Controls.Clear();
            //this.LoginForm.Controls.Add(newForm);
            //this.LoginForm.Tag = newForm;
            //newForm.Show();
        }

        private void LoadFormIntoPanel(Form formToLoad)
        {
            if (this.registrationPanel.Controls.Count > 0)
            {
                this.registrationPanel.Controls[0].Dispose();  // Dispose the previous form
            }
            formToLoad.TopLevel = false;
            formToLoad.FormBorderStyle = FormBorderStyle.None;
            formToLoad.Dock = DockStyle.Fill;
            this.registrationPanel.Controls.Add(formToLoad);
            this.registrationPanel.Tag = formToLoad;
            formToLoad.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //loadForm(new ManageCustomer(_userController));
            LoginForm loginForm = new LoginForm(_userController,_controller,_carController,_carPartsController);
            LoadFormIntoPanel(loginForm);
        }
    }
}
