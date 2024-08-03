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
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            AddNewCustomerForm addNewCustomerForm = new AddNewCustomerForm();
            addNewCustomerForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
               /* DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "Action";
                btn.HeaderText = "Action";
                btn.Text = "Action";
                btn.UseColumnTextForButtonValue = true;*/
                ManageCustomerActionForm actionForm = new ManageCustomerActionForm();
                actionForm.Show();
                
            }
        }
    }
}
