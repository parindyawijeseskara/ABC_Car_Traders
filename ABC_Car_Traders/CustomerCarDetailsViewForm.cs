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
    public partial class CustomerCarDetailsViewForm : Form
    {
        private readonly CarController _carController;
        private readonly int _carId;
        private Car _car;
        public CustomerCarDetailsViewForm(CarController carController, int carId)
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
            txtCarName.Text = _car.regNo;
            txtModel.Text = _car.Model.modelName;
            txtCarBrand.Text = _car.Model.Brand.brandName;
            txtYear.Text = _car.year;
            txtPrice.Text = _car.price.ToString();
            txtDescription.Text = _car.description;
            txtTransmission.Text = _car.transmission;

            if (_car.image != null && _car.image.Length > 0)
            {
                using (var ms = new MemoryStream(_car.image))
                {
                    //pictureBoxImage.Image = Image.FromStream(ms);
                    Image originalImage = Image.FromStream(ms);

                    Image resizedImage = new Bitmap(originalImage, new Size(502, 246));
                    pictureBoxImage.Image = resizedImage;
                }
            }
            else
            {
                pictureBoxImage.Image = null;
            }

        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {

        }

        private void txtCarName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTransmission_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
