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
    public partial class ManageCarPartsForm : Form
    {
        private readonly CarPartsController _controller;

        public ManageCarPartsForm(CarPartsController carPartsController)
        {
            _controller = carPartsController;
            InitializeComponent();
            loadCarParts();
        }

        private void btnAddNewCarPart_Click(object sender, EventArgs e)
        {
            AddNewCarPartsForm addNewCarPartsForm = new AddNewCarPartsForm(_controller);
            addNewCarPartsForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Ensure the cell value is not null
                    if (dataGridViewCarParts.Rows[e.RowIndex].Cells[1].Value != null)
                    {
                        int carPartId = (int)dataGridViewCarParts.Rows[e.RowIndex].Cells[1].Value;
                        ManageCarPartsActionForm actionForm = new ManageCarPartsActionForm(_controller, carPartId);
                        actionForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selected carPart ID is null. Please select a valid car part Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void loadCarParts()
        {
            var carParts = _controller.GetAllCarParts();
            dataGridViewCarParts.DataSource = carParts;
        }
    }
}
