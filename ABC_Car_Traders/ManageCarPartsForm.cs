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
    public partial class ManageCarPartsForm : Form
    {
        public ManageCarPartsForm()
        {
            InitializeComponent();
        }

        private void btnAddNewCarPart_Click(object sender, EventArgs e)
        {
            AddNewCarPartsForm addNewCarPartsForm = new AddNewCarPartsForm();
            addNewCarPartsForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                ManageCarPartsActionForm actionForm = new ManageCarPartsActionForm();
                actionForm.Show();

            }
        }
    }
}
