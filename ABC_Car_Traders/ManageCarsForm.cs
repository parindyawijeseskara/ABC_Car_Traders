using ABC_Car_Traders.Controllers;
using ABC_Car_Traders.DBContext;
using ABC_Car_Traders.Model;
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
        private readonly CarController _carController;
        public ManageCarsForm(CarController carController)
        {
            InitializeComponent();
            _carController = carController;
            loadCars();
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            AddNewCarForm addNewCarForm = new AddNewCarForm(_carController);
            addNewCarForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {

                //int carId = (int)dataGridViewCars.Rows[e.RowIndex].Cells["Column1"].Value;
                //Car car = _carController.getcarById(carId);


                //if (car != null)
                //{
                //var carId = (int)dataGridViewCars.Rows[e.RowIndex].Cells["Column1"].Value;
                //ManageCarActionForm actionForm = new ManageCarActionForm(_carController, carId);
                //actionForm.Show();
                //}
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Ensure the cell value is not null
                    if (dataGridViewCars.Rows[e.RowIndex].Cells[1].Value != null)
                    {
                        int carId = (int)dataGridViewCars.Rows[e.RowIndex].Cells[1].Value;
                        ManageCarActionForm actionForm = new ManageCarActionForm(_carController, carId);
                        actionForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Selected car ID is null. Please select a valid car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void dataGridViewCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* var cars = _carController.GetAllCars();
             dataGridViewCars.DataSource = cars;*/
            //loadCars();
        }

        private void loadCars()
        {
            var cars = _carController.GetAllCars();
            dataGridViewCars.DataSource = cars;
        }
    }
}
