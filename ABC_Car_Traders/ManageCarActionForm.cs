using ABC_Car_Traders.Controllers;
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
    public partial class ManageCarActionForm : Form
    {
        private readonly CarController _carController;
        private readonly int _carId;
        private Car _car;


        public ManageCarActionForm(CarController carController, int carId)
        {
            InitializeComponent();
            _carController = carController;
            _carId = carId;
            loadCarDetails();
        }

        public void loadCarDetails()
        {
            _car = _carController.getcarById(_carId);

            if (_car == null)
            {
                MessageBox.Show("Car not found. Please select a valid car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtCarName.Text = _car.carName;
            txtModel.Text = _car.model;
            txtBrand.Text = _car.brand;
            txtYear.Text = _car.year;
            txtPrice.Text = _car.price.ToString();
            txtDescription.Text = _car.description;
            txtQuantity.Text = _car.quantity.ToString();
            cmbTransmission.SelectedItem = _car.transmission;
            cmbStatus.SelectedItem = _car.status;


            if (_car.image != null && _car.image.Length > 0)
            {
                using (var ms = new MemoryStream(_car.image))
                {
                    pictureBoxImage.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBoxImage.Image = null; // Or set a default image
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _car.carName = txtCarName.Text;
                _car.model = txtModel.Text;
                _car.brand = txtBrand.Text;
                _car.year = txtYear.Text;
                _car.price = decimal.Parse(txtPrice.Text);
                _car.description = txtDescription.Text;
                _car.quantity = int.Parse(txtQuantity.Text);
                _car.transmission = cmbTransmission.Text;
                _car.status = cmbStatus.Text;
                _carController.UpdateCar(_car);
                this.Close();
                MessageBox.Show("Car Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _carController.DeleteCar(_carId);
                this.Close();
                MessageBox.Show("Car Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
