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
    public partial class CustomerDashboardCarDetailsForm : Form
    {
        public CustomerDashboardCarDetailsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridView1.Columns["Column11"].Index || e.ColumnIndex == dataGridView1.Columns["Column12"].Index))
             {
                if (e.ColumnIndex == dataGridView1.Columns["Column11"].Index)
                {
                    OpenForm1();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Column12"].Index)
                {
                    OpenForm2();
                }
             }

        }

        private void OpenForm1()
        {
            CustomerCarDetailsViewForm form1 = new CustomerCarDetailsViewForm();
            form1.Show();
        }

        private void OpenForm2()
        {
            CustomerCarPlaceOrderForm form2 = new CustomerCarPlaceOrderForm();
            form2.Show();
        }
    }
}
