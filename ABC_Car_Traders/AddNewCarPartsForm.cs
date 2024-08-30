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
    public partial class AddNewCarPartsForm : Form
    {
        private readonly CarPartsController _carPartsController;
        private byte[] _carPartsImage;

        public AddNewCarPartsForm(CarPartsController carPartsController)
        {
            _carPartsController = carPartsController;
            InitializeComponent();
            lblNameError.Visible = false;
            lblBrandError.Visible = false;
            lblModelError.Visible = false;
            lblPriceError.Visible = false;
            lblQuantityError.Visible = false;
            lblDescriptionError.Visible = false;
            lblManufacturerError.Visible = false;
            lblWarrantyError.Visible = false;
            lblImageError.Visible = false;
        }

        private void btnSaveCarParts_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate the form
                if (!IsFormValid())
                {
                    MessageBox.Show("Please correct the highlighted errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var brandName = txtBrand.Text;
                var brand = _carPartsController.GetBrandByName(brandName);
                if (brand == null)
                {
                    brand = new Brand { brandName = brandName };
                    _carPartsController.AddBrand(brand);
                }

                var modelName = txtModel.Text;
                var model = _carPartsController.GetModelByName(modelName, brand.brandId);

                if (model == null)
                {
                    model = new Models { modelName = modelName, brandId = brand.brandId };
                    _carPartsController.AddModel(model);
                }

                var carParts = new CarParts()
                {
                    carPartName = txtName.Text,
                    image = _carPartsImage,
                    modelId = model.modelId,
                    price = decimal.Parse(txtPrice.Text),
                    quantity = int.Parse(txtQuantity.Text),
                    description = txtDescription.Text,
                    manufacturer = txtManufacturer.Text,
                    warrantyPeriod = txtWarrantyPeriod.Text,
                    status = "Available"
                };
                _carPartsController.AddCarParts(carParts);
                MessageBox.Show("Car Parts saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    _carPartsImage = ResizeImage(originalImage, 200, 200);

                    // Display the resized image in a PictureBox
                    using (var ms = new MemoryStream(_carPartsImage))
                    {
                        pictureBoxCarPartsImage.Image = Image.FromStream(ms);
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

        private bool IsFormValid()
        {
            bool isValid = true;

            // Validate Registration Number
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                lblNameError.Text = "** Please enter the registration number.";
                lblNameError.Visible = true;
                isValid = false;
            }
            else
            {
                lblNameError.Visible = false;
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

            // Validate Description
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                lblDescriptionError.Text = "Please enter the description.";
                lblDescriptionError.Visible = true;
                isValid = false;
            }
            else
            {
                lblDescriptionError.Visible = false;
            }

            // Validate Manufacturer
            if (string.IsNullOrWhiteSpace(txtManufacturer.Text))
            {
                lblManufacturerError.Text = "Please select a transmission type.";
                lblManufacturerError.Visible = true;
                isValid = false;
            }
            else
            {
                lblManufacturerError.Visible = false;
            }


            // Validate Warranty Period
            if (string.IsNullOrWhiteSpace(txtWarrantyPeriod.Text))
            {
                lblWarrantyError.Text = "Please select a warranty period.";
                lblWarrantyError.Visible = true;
                isValid = false;
            }
            else
            {
                lblWarrantyError.Visible = false;
            }

            // Validate Image
            if (_carPartsImage == null || _carPartsImage.Length == 0)
            {
                lblImageError.Text = "Please upload an image.";
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
