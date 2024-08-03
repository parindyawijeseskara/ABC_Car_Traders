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
    public partial class CustomerDashboardMyOrdersForm : Form
    {
        public CustomerDashboardMyOrdersForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                CustomerMyOrderDetailsViewForm actionForm = new CustomerMyOrderDetailsViewForm();
                actionForm.Show();

            }
        }
    }
}
