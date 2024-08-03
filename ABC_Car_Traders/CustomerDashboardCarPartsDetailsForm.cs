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
    public partial class CustomerDashboardCarPartsDetailsForm : Form
    {
        public CustomerDashboardCarPartsDetailsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridView1.Columns["Column10"].Index || e.ColumnIndex == dataGridView1.Columns["Column11"].Index))
            {
                if (e.ColumnIndex == dataGridView1.Columns["Column10"].Index)
                {
                    OpenForm1();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Column11"].Index)
                {
                    OpenForm2();
                }
            }
        }

        private void OpenForm1()
        {
            CustomerCarPartsDetailViewForm form1 = new CustomerCarPartsDetailViewForm();
            form1.Show();

        }

        private void OpenForm2()
        {
            CustomerCarPartsPlaceOrderForm form2 = new CustomerCarPartsPlaceOrderForm();
            form2.Show();
        }
    }
}
