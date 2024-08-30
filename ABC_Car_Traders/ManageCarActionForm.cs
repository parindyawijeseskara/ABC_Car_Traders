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
            lblRegNoError.Visible = false;
            lblBrandError.Visible = false;
            lblModelError.Visible = false;
            lblYearError.Visible = false;
            lblPriceError.Visible = false;
            lblDescriptionError.Visible = false;
            lblQuantityError.Visible = false;
            lblTransmissionError.Visible = false;
            


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
            txtBrand.Text = _car.Model.Brand.brandName;
            txtModel.Text = _car.Model.modelName.ToString();
            txtYear.Text = _car.year;
            txtPrice.Text = _car.price.ToString();
            txtDescription.Text = _car.description;
            txtQuantity.Text = _car.quantity.ToString();
            cmbTransmission.Text = _car.transmission;
            


            if (_car.image != null && _car.image.Length > 0)
            {
                using (var ms = new MemoryStream(_car.image))
                {
                    pictureBoxImage.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBoxImage.Image = null;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate the form
                if (!IsFormValid())
                {
                    MessageBox.Show("Please correct the highlighted errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _car.regNo = txtCarName.Text;
                _car.Model.Brand.brandName = txtBrand.Text;
                _car.Model.modelName = txtModel.Text;
                _car.year = txtYear.Text;
                _car.price = decimal.Parse(txtPrice.Text);
                _car.description = txtDescription.Text;
                _car.quantity = int.Parse(txtQuantity.Text);
                _car.transmission = cmbTransmission.Text;
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

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsFormValid()
        {
            bool isValid = true;

            // Validate Registration Number
            if (string.IsNullOrWhiteSpace(txtCarName.Text))
            {
                lblRegNoError.Text = "** Please enter the registration number.";
                lblRegNoError.Visible = true;
                isValid = false;
            }
            else
            {
                lblRegNoError.Visible = false;
            }

            // Validate Brand Name
            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                lblBrandError.Text = "Please enter the brand name.";
                lblBrandError.Visible = true;
                isValid = false;
            }
            else
            {
                lblBrandError.Visible = false;
            }

            // Validate Model Name
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                lblModelError.Text = "Please enter the model name.";
                lblModelError.Visible = true;
                isValid = false;
            }
            else
            {
                lblModelError.Visible = false;
            }

            // Validate Year
            if (!int.TryParse(txtYear.Text, out int year) || txtYear.Text.Length != 4)
            {
                lblYearError.Text = "Please enter a valid 4-digit year.";
                lblYearError.Visible = true;
                isValid = false;
            }
            else
            {
                lblYearError.Visible = false;
            }

            // Validate Price
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                lblPriceError.Text = "Please enter a valid price.";
                lblPriceError.Visible = true;
                isValid = false;
            }
            else
            {
                lblPriceError.Visible = false;
            }

            // Validate Quantity
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                lblQuantityError.Text = "Please enter a valid quantity.";
                lblQuantityError.Visible = true;
                isValid = false;
            }
            else
            {
                lblQuantityError.Visible = false;
            }

            // Validate Transmission
            if (string.IsNullOrWhiteSpace(cmbTransmission.Text))
            {
                lblTransmissionError.Text = "Please select a transmission type.";
                lblTransmissionError.Visible = true;
                isValid = false;
            }
            else
            {
                lblTransmissionError.Visible = false;
            }

            return isValid;
        }
    }
}
