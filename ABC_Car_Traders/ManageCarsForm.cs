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
    public partial class ManageCarsForm : Form
    {
        public ManageCarsForm()
        {
            InitializeComponent();
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            AddNewCarForm addNewCarForm = new AddNewCarForm();
            addNewCarForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                ManageCarActionForm actionForm = new ManageCarActionForm();
                actionForm.Show();

            }
        }
    }
}
