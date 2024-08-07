using ABC_Car_Traders.Controllers;
using ABC_Car_Traders.DBContext;
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
                ManageCarActionForm actionForm = new ManageCarActionForm();
                actionForm.Show();

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
