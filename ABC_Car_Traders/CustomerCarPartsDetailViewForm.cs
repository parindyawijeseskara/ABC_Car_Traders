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
    public partial class CustomerCarPartsDetailViewForm : Form
    {
        private readonly CarPartsController _carPartsController;
        private readonly int _carPartId;
        private CarParts _carParts;
        public CustomerCarPartsDetailViewForm(CarPartsController carPartsController, int carPartId)
        {
            InitializeComponent();
            _carPartsController = carPartsController;
            _carPartId = carPartId;
            loadCarPartDetails();
        }

        public void loadCarPartDetails()
        {
            _carParts = _carPartsController.getCarPartById(_carPartId);
            if (_carParts == null)
            {
                MessageBox.Show("Car not found. Please select a valid car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txtModel.Text = _carParts.modelId.ToString();
            //txtBrand.Text = _carParts.Model.Brand.brandId.ToString();
            txtCarPartName.Text = _carParts.carPartName;
            txtPrice.Text = _carParts.price.ToString();
            txtQuantity.Text = _carParts.quantity.ToString();
            txtDescription.Text = _carParts.description;
            txtManufacturer.Text = _carParts.manufacturer;
            txtWarrantyPeriod.Text = _carParts.warrantyPeriod;
            txtStatus.Text = _carParts.status;

            if (_carParts.image != null && _carParts.image.Length > 0)
            {
                using (var ms = new MemoryStream(_carParts.image))
                {
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

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCarPartName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
