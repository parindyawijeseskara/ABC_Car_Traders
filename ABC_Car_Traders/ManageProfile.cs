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
    public partial class ManageProfile : Form
    {
        private readonly int _userId;
        private readonly UserController _userController;

        public ManageProfile(int userId, UserController userController)
        {
            InitializeComponent();
            _userId = userId;
            _userController = userController;

            LoadUserDetails();
        }
        private void LoadUserDetails()
        {
            var user = _userController.getUserById(_userId);
            if (user != null)
            {
                txtFirstName.Text = user.firstName;
                txtLastName.Text = user.lastName;
                txtNic.Text = user.nic;
                txtEmail.Text = user.email;
                txtAddress.Text = user.address;
                txtContactNo.Text = user.contactNo;
            }
            else
            {
                MessageBox.Show("User details could not be loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateProfileDetails_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new User()
                {
                    userId = _userId,
                    firstName = txtFirstName.Text,
                    lastName = txtLastName.Text,
                    nic = txtNic.Text,
                    email = txtEmail.Text,
                    address = txtAddress.Text,
                    contactNo = txtContactNo.Text
                };

                _userController.updateUser(user);
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
