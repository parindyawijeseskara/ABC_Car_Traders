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
using User = ABC_Car_Traders.Model.User;

namespace ABC_Car_Traders
{
    public partial class CustomerDashboardCarPartsOrderForm : Form
    {
        private readonly CarPartsController _carPartsController;
        private readonly CarController _carController;
        private OrdersController _ordersController;
        private int total = 0;
        private User user;
        private CarParts carPart;
        private List<OrderDetail> orderDetailsList = null;
        public int selectedCarModelIdVal = 0;
        public CustomerDashboardCarPartsOrderForm(CarPartsController carPartsController, CarController carController, OrdersController ordersController)
        {
            InitializeComponent();
            _carPartsController = carPartsController;
            loadBrands();
            _carController = carController;
            _ordersController = ordersController;
            dataGridPlaceOrder.AutoGenerateColumns = false;
        }
        // load all brands in combo box
        private void loadBrands()
        {
            var carBrands = _carPartsController.GetAllBrands();
            cmbCarBrand.DataSource = carBrands;
            cmbCarBrand.DisplayMember = "brandName";
            cmbCarBrand.ValueMember = "brandId";
            cmbCarBrand.SelectedIndex = -1;
        }
        // load all models in combo box
        public void loadModels(int brandId)
        {
            var carModels = _carPartsController.GetModelsByBrand(brandId);

            if (carModels.Count == 0)
            {
                MessageBox.Show("No models found for the selected brand.");
            }
            else
            {
                cmbCarModel.DataSource = carModels;
                cmbCarModel.DisplayMember = "modelName";
                cmbCarModel.ValueMember = "modelId";
                cmbCarModel.SelectedIndex = -1;
            }
        }

        // load car part names by model
        public void loadCarPartNames(int modelId)
        {
            this.selectedCarModelIdVal = modelId;
            var carParts = _carPartsController.GetCarPartsByModel(modelId);

            if (carParts.Count == 0)
            {
                MessageBox.Show("No carparts found for the selected model.");
            }
            else
            {
                cmbCarPartName.DataSource = carParts;
                cmbCarPartName.DisplayMember = "carPartName";
                cmbCarPartName.ValueMember = "carPartId";
                cmbCarPartName.SelectedIndex = -1;
            }
        }

        private void LoadCarPartQuantityandUnitPrice(int carPartId)
        {
            this.carPart = _carPartsController.getCarPartById(carPartId);

            if (carPart != null)
            {
                txtUnitPrice.Text = carPart.price.ToString();
                txtQuantityOnHand.Text = carPart.quantity.ToString();
            }
            else
            {
                MessageBox.Show("Unable to load the quantity for the selected car part.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCarBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCarBrand.SelectedIndex != -1)
            {
                var selectedValue = cmbCarBrand.SelectedValue;
                if (selectedValue is int selectedBrandId)
                {
                    loadModels(selectedBrandId);
                }
            }
        }

        private void cmbCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCarModel.SelectedIndex != -1)
            {
                var selectedCarModel = cmbCarModel.SelectedValue;

                if (selectedCarModel is int selectedCarModelId)
                {
                    loadCarPartNames(selectedCarModelId);
                }
            }

        }

        private void cmbCarPartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCarPartName.SelectedIndex != -1)
            {
                var selectedCarPartId = cmbCarPartName.SelectedValue;
                if (selectedCarPartId is int carPartId)
                {
                    LoadCarPartQuantityandUnitPrice(carPartId);
                }
            }

        }

        private void txtNic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = txtNic.Text.Trim();

                if (string.IsNullOrEmpty(input))
                {
                    ClearCustomerDetailsFields();
                    MessageBox.Show("Please enter Nic.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var details = _carController.GetCustomerDetailsForOrder(input);

                if (details != null)
                {
                    txtCustomerName.Text = details.Name;
                    txtAddress.Text = details.Address;
                    txtNic.Text = details.ItemName;
                    txtEmail.Text = details.Email;
                    txtContactNo.Text = details.ContactNo;

                    this.user = _carController.GetUserByNIC(input);
                }
                else
                {
                    MessageBox.Show("No matching Nic found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearCustomerDetailsFields();
                }
            }
        }

        private void ClearCustomerDetailsFields()
        {
            txtCustomerName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNic.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContactNo.Text = string.Empty;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Models model = _carController.GetModelById(this.selectedCarModelIdVal);
            int qtyOnHand = int.Parse(txtQuantityOnHand.Text);
            int qty = int.Parse(txtQuantity.Text);

            if (qty > qtyOnHand)
            {
                MessageBox.Show("Quantity cannot be greater than Qty On Hand.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //_ordersController.btnSendEmail_Click();
                this.total += int.Parse(txtTotal.Text.Trim());
                int newRowIndex = dataGridPlaceOrder.Rows.Add();

                // Access the newly added row
                DataGridViewRow newRow = dataGridPlaceOrder.Rows[newRowIndex];

                // Set the value for the first cell (column index 0) in the new row
                newRow.Cells[0].Value = cmbCarPartName.Text.Trim();
                newRow.Cells[1].Value = txtDate.Text.Trim();
                newRow.Cells[2].Value = txtQuantity.Text.Trim();
                newRow.Cells[3].Value = txtUnitPrice.Text.Trim();
                newRow.Cells[4].Value = txtTotal.Text.Trim();
                newRow.Cells[5].Value = "PEN";

                txtFinalTotal.Text = this.total.ToString();
                if (orderDetailsList == null)
                {
                    orderDetailsList = new List<OrderDetail>();
                }

                // Create a new OrderDetail instance
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.CarParts = this.carPart;
                orderDetail.Car = null;
                orderDetail.qty = int.Parse(txtQuantity.Text.Trim());
                orderDetail.created_at = DateTime.Now;
                orderDetail.status = "PEN";
                orderDetail.Model = model;
                orderDetail.Model.modelId = model.modelId;
                orderDetail.unitPrice = int.Parse(txtUnitPrice.Text.Trim());

                // Add the new OrderDetail to the list
                orderDetailsList.Add(orderDetail);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = new Order();
                order.User = this.user;
                order.orderDate = txtDate.Value;
                order.status = "PEN";
                order.total = int.Parse(txtTotal.Text.Trim());

                if (this.user.userId != null)
                {
                    _ordersController.SaveOrder(order);
                }
                else
                {
                    MessageBox.Show("xdadas.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                foreach (var item in orderDetailsList)
                {
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.Car = null;
                    //orderDetail.CarParts = this.carPart;
                    orderDetail.CarPartsId = item.CarParts.carPartId;
                    orderDetail.Order = order;
                    orderDetail.created_at = txtDate.Value;
                    orderDetail.qty = item.qty;
                    orderDetail.status = "PEN";
                    orderDetail.unitPrice= int.Parse(txtUnitPrice.Text);
                    orderDetail.modelId = item.Model.modelId;
                    MessageBox.Show(orderDetail.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ordersController.SaveOrderDetails(orderDetail);
                    _carPartsController.UpdateCarPartsQty(this.carPart.carPartId, item.qty);
                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Order placed Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Trim() != "")
            {
                int input = int.Parse(txtQuantity.Text.Trim());
                int price = int.Parse(txtUnitPrice.Text.Trim());
                var totalPrice = input * price;
                txtTotal.Text = totalPrice.ToString();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
