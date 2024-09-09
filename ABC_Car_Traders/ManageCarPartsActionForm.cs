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
    public partial class ManageCarPartsActionForm : Form
    {
        private readonly CarPartsController _carPartsController;
        private readonly int _carPartId;
        private CarParts carParts;
        private byte[] _updatedCarImage; // Store the updated image

        public ManageCarPartsActionForm(CarPartsController carPartsController, int carPartId)
        {
            InitializeComponent();
            _carPartsController = carPartsController;
            _carPartId = carPartId;
            loadCarPartsDetails();

        }

        private void loadCarPartsDetails()
        {
            carParts = _carPartsController.getCarPartById(_carPartId);
            if (carParts == null)
            {
                MessageBox.Show("Car not found. Please select a valid car part.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txtCarPartName.Text = carParts.carPartName;
            //txtBrand.Text = carParts.Model.Brand.brandName;
            //txtModel.Text = carParts.Model.modelName.ToString();
            txtPrice.Text = carParts.price.ToString();
            txtQuantity.Text = carParts.quantity.ToString();
            txtDescription.Text = carParts.description;
            txtManufacturer.Text = carParts.manufacturer;
            txtWarrantyPeriod.Text = carParts.warrantyPeriod;


            if (carParts.image != null && carParts.image.Length > 0)
            {
                using (var ms = new MemoryStream(carParts.image))
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
                carParts.carPartName = txtCarPartName.Text;
                //carParts.Model.Brand.brandName = txtBrand.Text;
               // carParts.Model.modelName = txtModel.Text;
                carParts.price = decimal.Parse(txtPrice.Text);
                carParts.quantity = int.Parse(txtQuantity.Text);
                carParts.description = txtDescription.Text;
                carParts.manufacturer = txtManufacturer.Text;
                carParts.warrantyPeriod = txtWarrantyPeriod.Text;

                if (_updatedCarImage != null)
                {
                    carParts.image = _updatedCarImage;  // Update the image if a new one has been uploaded
                }

                _carPartsController.UpdateCarParts(carParts);
                this.Close();
                MessageBox.Show("Car Parts updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _carPartsController.DeleteCarPart(_carPartId);
                this.Close();
                MessageBox.Show("Car Part Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateUploadImage_Click(object sender, EventArgs e)
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

                    // Resize the image (using the ResizeImage method from your save code)
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
