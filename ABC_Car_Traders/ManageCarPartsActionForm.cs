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
            txtModel.Text = carParts.model;
            txtPrice.Text = carParts.price.ToString();
            txtQuantity.Text = carParts.quantity.ToString();
            txtDescription.Text = carParts.description;
            txtManufacturer.Text = carParts.manufacturer;
            txtWarrantyPeriod.Text = carParts.warrantyPeriod;
            cmbStatus.SelectedItem = carParts.status;

            if (carParts.image != null && carParts.image.Length > 0)
            {
                using (var ms = new MemoryStream(carParts.image))
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
                carParts.carPartName = txtCarPartName.Text;
                carParts.model = txtModel.Text;
                carParts.price = decimal.Parse(txtPrice.Text);
                carParts.quantity = int.Parse(txtQuantity.Text);
                carParts.description = txtDescription.Text;
                carParts.manufacturer = txtManufacturer.Text;
                carParts.warrantyPeriod = txtWarrantyPeriod.Text;
                carParts.status = cmbStatus.Text;
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
            }catch(Exception ex)
            {
                MessageBox.Show($"An error occured:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
