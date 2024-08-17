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
    public partial class ManageUsers : Form
    {
        private readonly UserController _userController;
        public ManageUsers(UserController userController)
        {
            InitializeComponent();
            _userController = userController;
            loadUsers();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                ManageUsersActionForm actionForm = new ManageUsersActionForm();
                actionForm.Show();

            }
        }

        public void loadUsers()
        {
            var users = _userController.GetUsers();
            dataGridViewUsers.DataSource = users;
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
