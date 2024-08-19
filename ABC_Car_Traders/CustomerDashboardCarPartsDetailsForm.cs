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
    public partial class CustomerDashboardCarPartsDetailsForm : Form
    {
        private readonly CarPartsController _carPartsController;
        public CustomerDashboardCarPartsDetailsForm(CarPartsController carPartsController)
        {
            InitializeComponent();
            _carPartsController = carPartsController;
            loadCarPartDetails();
        }
        private void dataGridViewCarParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridViewCarParts.Columns["Column11"].Index || e.ColumnIndex == dataGridViewCarParts.Columns["Column12"].Index))
            {
                if (e.ColumnIndex == dataGridViewCarParts.Columns["Column11"].Index)
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        // Ensure the cell value is not null
                        if (dataGridViewCarParts.Rows[e.RowIndex].Cells[2].Value != null)
                        {
                            int carPartId = (int)dataGridViewCarParts.Rows[e.RowIndex].Cells[2].Value;
                            CustomerCarPartsDetailViewForm form1 = new CustomerCarPartsDetailViewForm(_carPartsController,carPartId);
                            form1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Selected car ID is null. Please select a valid car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (e.ColumnIndex == dataGridViewCarParts.Columns["Column12"].Index)
                {
                    OpenForm2();
                }
            }
        }

        private void OpenForm1()
        {
            //CustomerCarPartsDetailViewForm form1 = new CustomerCarPartsDetailViewForm();
            //form1.Show();

        }

        private void OpenForm2()
        {
            CustomerCarPartsPlaceOrderForm form2 = new CustomerCarPartsPlaceOrderForm();
            form2.Show();
        }

        private void loadCarPartDetails()
        {
            var carParts = _carPartsController.GetAllCarParts();
            dataGridViewCarParts.DataSource = carParts;

        }

        private void btnSearchByCartPartName_Click(object sender, EventArgs e)
        {

        }

    }
}
