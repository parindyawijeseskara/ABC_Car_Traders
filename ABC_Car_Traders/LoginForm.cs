using System.Text;
using System.Security.Cryptography;
using ABC_Car_Traders.Controllers;
using ABC_Car_Traders.Model;
using Microsoft.EntityFrameworkCore;

namespace ABC_Car_Traders
{
    public partial class LoginForm : Form
    {
        public readonly UserController _userController;
        public readonly RegistrationController _controller;
        private readonly CarController _carController;
        private readonly CarPartsController _carPartsController;
        private readonly OrdersController _ordersController;
        public int userId;

        public LoginForm(UserController userController, RegistrationController controller, CarController carController, CarPartsController carPartsController, OrdersController ordersController)
        {
            InitializeComponent();
            _carController = carController;
            _carPartsController = carPartsController;
            _userController = userController;
            _controller = controller;
            _ordersController = ordersController;
            LoadRoleUsers();
        }

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

        private void LoadFormIntoPanel(Form formToLoad)
        {
            if (this.loginPanel.Controls.Count > 0)
            {
                this.loginPanel.Controls[0].Dispose();
            }
            formToLoad.TopLevel = false;
            formToLoad.FormBorderStyle = FormBorderStyle.None;
            formToLoad.Dock = DockStyle.Fill;
            this.loginPanel.Controls.Add(formToLoad);
            this.loginPanel.Tag = formToLoad;
            formToLoad.Show();
        }

        private void link_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(_controller, _userController, _carController, _carPartsController, _ordersController);
            LoadFormIntoPanel(registrationForm);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void LoadRoleUsers()
        {
            var roles = _controller.GetRoles();
            cmbUserRole.DataSource = roles;
            cmbUserRole.DisplayMember = "Role";
            cmbUserRole.ValueMember = "RoleId";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string inputUserName = txtUserName.Text.Trim();
                string inputPassword = txtPassword.Text.Trim();
                int selectedRoleId = (int)cmbUserRole.SelectedValue;

                var user = _controller.ValidateUser(inputUserName, inputPassword, selectedRoleId);

                if (user != null)
                {
                    this.userId = user.userId;
                    MessageBox.Show("Login successful!");
                    if (user.roleId == 1)
                    {
                        AdminDashboard adminDashboard = new AdminDashboard(_carController, _carPartsController, _userController, _controller, _ordersController, this.userId);
                        adminDashboard.Show();
                        this.Hide();
                    }
                    else if (user.roleId == 2)
                    {
                        CustomerDashboard customerDashboard = new CustomerDashboard(_carController, _carPartsController, _userController, _controller, this.userId, _ordersController);
                        customerDashboard.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username, password, or role.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
