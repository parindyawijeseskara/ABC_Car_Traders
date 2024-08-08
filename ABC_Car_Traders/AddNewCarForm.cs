using ABC_Car_Traders.Controllers;
using ABC_Car_Traders.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABC_Car_Traders
{
    public partial class AddNewCarForm : Form
    {
        private readonly CarController _carController;
        private byte[] _carImage;

        public AddNewCarForm(CarController carController)
        {
            _carController = carController;
            InitializeComponent();
        }

        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car()
                {
                    carName = txtCarName.Text,
                    image = _carImage,
                    model = textModel.Text,
                    brand = txtBrand.Text,
                    year = txtYear.Text,
                    price = decimal.Parse(txtPrice.Text),
                    description = txtDescription.Text,
                    quantity = int.Parse(txtQuantity.Text),
                    transmission = cmbTransmission.Text,
                    status = txtStatus.Text
                };
                _carController.AddCar(car);
                //Show successfull saved message
                MessageBox.Show("Car saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // show error message if not something went wrong
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

    }
}
