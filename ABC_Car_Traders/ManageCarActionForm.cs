using ABC_Car_Traders.Controllers;
using ABC_Car_Traders.Model;
using ABC_Car_Traders.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class ManageCarActionForm : Form
    {
        private readonly CarController _carController;
        private readonly int _carId;
        private Car _car;
        private byte[] _updatedCarImage; // Store the updated image


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

                if (_updatedCarImage != null)
                {
                    _car.image = _updatedCarImage;  // Update the image if a new one has been uploaded
                }

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

            // Validate Brand Name
            if (string.IsNullOrWhiteSpace(txtBrand.Text) || !Regex.IsMatch(txtBrand.Text, PatternValidation.namePattern))
            {
                lblBrandError.Text = "Please enter a valid brand name.";
                lblBrandError.Visible = true;
                isValid = false;
            }
            else
            {
                lblBrandError.Visible = false;
            }

            // Validate Year
            if (!int.TryParse(txtYear.Text, out int year) || txtYear.Text.Length != 4)
            {
                lblYear.Text = "Please enter a valid 4-digit year.";
                lblYear.Visible = true;
                isValid = false;
            }
            else
            {
                lblYear.Visible = false;
            }

            // Validate Price
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                lblYear.Text = "Please enter a valid price.";
                lblYear.Visible = true;
                isValid = false;
            }
            else
            {
                lblYear.Visible = false;
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

        private void uploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Load the original image
                    Image originalImage = Image.FromFile(filePath);

                    _updatedCarImage = ResizeImage(originalImage, 502, 246);

                    // Display the resized image in the PictureBox
                    using (var ms = new MemoryStream(_updatedCarImage))
                    {
                        pictureBoxImage.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        private byte[] ResizeImage(Image originalImage, int width, int height)
        {
            var resizedImage = new Bitmap(width, height);
            using (var graphics = Graphics.FromImage(resizedImage))
            {
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.DrawImage(originalImage, 0, 0, width, height);
            }

            using (var ms = new MemoryStream())
            {
                resizedImage.Save(ms, originalImage.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
