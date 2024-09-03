using ABC_Car_Traders.Controllers;
using ABC_Car_Traders.Model;
using ABC_Car_Traders.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABC_Car_Traders
{
    public partial class AddNewCarForm : Form
    {
        private readonly CarController _carController;
        private byte[] _carImage;
        private string _carImageFileName;

        public AddNewCarForm(CarController carController)
        {
            _carController = carController;
            InitializeComponent();
            lblRegNoError.Visible = false;
            lblBrandError.Visible = false;
            lblModelError.Visible = false;
            lblYearError.Visible = false;
            lblPriceError.Visible = false;
            lblDescriptionError.Visible = false;
            lblQuantityError.Visible = false;
            lblTransmissionError.Visible = false;
            lblImageError.Visible = false;
        }

        //Function to save Cars
        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate the form
                if (!IsFormValid())
                {
                    MessageBox.Show("Please correct the highlighted errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var brandName = txtBrand.Text;
                var brand = _carController.GetBrandByName(brandName);
                if (brand == null)
                {
                    brand = new Brand { brandName = brandName };
                    _carController.AddBrand(brand);
                }

                var modelName = txtModel.Text;
                var model = _carController.GetModelByName(modelName, brand.brandId);

                if (model == null)
                {
                    model = new Models { modelName = modelName, brandId = brand.brandId };
                    _carController.AddModel(model);
                }


                var car = new Car()
                {

                    regNo = txtCarName.Text,
                    image = _carImage,
                    modelId = model.modelId,
                    year = txtYear.Text,
                    price = decimal.Parse(txtPrice.Text),
                    description = txtDescription.Text,
                    quantity = int.Parse(txtQuantity.Text),
                    transmission = cmbTransmission.Text,
                    status = "AVAILABLE"
                };
                _carController.AddCar(car);
                //Show successfull saved message
                MessageBox.Show("Car saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // show error message 
                MessageBox.Show($"An error occured:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void btnUploadImage_Click(object sender, EventArgs e)
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

                    // Resize the image
                    _carImage = ResizeImage(originalImage, 200, 200);

                    // Display the resized image in a PictureBox
                    using (var ms = new MemoryStream(_carImage))
                    {
                        pictureBoxCarImage.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        private bool IsFormValid()
        {
            bool isValid = true;

            // Validate Registration Number
            if (string.IsNullOrWhiteSpace(txtCarName.Text) || !Regex.IsMatch(txtCarName.Text, PatternValidation.regNoPattern))
            {
                lblRegNoError.Text = "** Please enter a valid registration number.";
                lblRegNoError.Visible = true;
                isValid = false;
            }
            else
            {
                lblRegNoError.Visible = false;
            }

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

            // Validate Model Name
            if (string.IsNullOrWhiteSpace(txtModel.Text) || !Regex.IsMatch(txtModel.Text, PatternValidation.namePattern))
            {
                lblModelError.Text = "Please enter a valid model name.";
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

            // Validate Image
            if (string.IsNullOrWhiteSpace(_carImageFileName) || !Regex.IsMatch(_carImageFileName, PatternValidation.imagePattern, RegexOptions.IgnoreCase))
            {
                lblImageError.Text = "Please upload a valid image file (jpg, jpeg, png, gif).";
                lblImageError.Visible = true;
                isValid = false;
            }
            else
            {
                lblImageError.Visible = false;
            }

            return isValid;
        }



    }
}
