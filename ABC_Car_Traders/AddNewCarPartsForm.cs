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
        }

        private void btnSaveCarParts_Click(object sender, EventArgs e)
        {
            try
            {
                var carParts = new CarParts()
                {
                    carPartName = txtName.Text,
                    model = txtModel.Text,
                    price = decimal.Parse(txtPrice.Text),
                    quantity = int.Parse(txtQuantity.Text),
                    description = txtDescription.Text,
                    manufacturer = txtManufacturer.Text,
                    warrantyPeriod = txtWarrantyPeriod.Text,
                    status = cmbStatus.Text,
                    image = _carPartsImage
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
    }
}
