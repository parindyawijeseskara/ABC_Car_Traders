using ABC_Car_Traders.Controllers;
using ABC_Car_Traders.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using User = ABC_Car_Traders.Model.User;

namespace ABC_Car_Traders
{
    public partial class CustomerDashboardMyOrdersForm : Form
    {
        private readonly CarController _carController;
        private OrdersController _ordersController;
        private int total = 0;
        private User user;
        private Car car;
        private List<OrderDetail> orderDetailsList = null;
        public int selectedCarModelIdVal = 0;

        public CustomerDashboardMyOrdersForm(CarController carController, OrdersController ordersController)
        {
            InitializeComponent();
            _carController = carController;
            _ordersController = ordersController;
            dataGridPlaceOrder.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                CustomerMyOrderDetailsViewForm actionForm = new CustomerMyOrderDetailsViewForm();
                actionForm.Show();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCarRegNoOrPartName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCarRegNoOrPartName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                string input = txtCarRegNoOrPartName.Text.Trim();

                if (string.IsNullOrEmpty(input))
                {
                    ClearCarDetailsFields();
                    MessageBox.Show("Please enter a Car RegNo or Car Part Name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var details = _carController.GetCarOrCarPartDetails(input);

                if (details != null)
                {
                    txtBrand.Text = details.Brand;
                    txtCarModel.Text = details.Model;
                    txtCarRegNoOrPartName.Text = details.ItemName;
                    txtUnitPrice.Text = details.Price.ToString();
                    txtQuantityOnHand.Text = details.Quantity.ToString();
                    this.selectedCarModelIdVal = details.modelId;

                    this.car = _carController.getcarByRegNo(input);
                }
                else
                {
                    MessageBox.Show("No matching car or car part found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearCarDetailsFields();
                }
            }
        }

        //clear the car detail fields
        private void ClearCarDetailsFields()
        {
            txtBrand.Text = string.Empty;
            txtCarModel.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtQuantityOnHand.Text = string.Empty;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Models model = _carController.GetModelById(this.selectedCarModelIdVal);
            int qty_on_hand = int.Parse(txtQuantityOnHand.Text);
            int qty = int.Parse(txtQuantity.Text);

            if (qty > qty_on_hand)
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
                newRow.Cells[0].Value = txtCarRegNoOrPartName.Text.Trim();
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
                orderDetail.CarParts = null;
                orderDetail.Car = this.car;
                orderDetail.qty = int.Parse(txtQuantity.Text.Trim());
                orderDetail.created_at = DateTime.Now;
                orderDetail.status = "PEN";
                orderDetail.unitPrice = int.Parse(txtUnitPrice.Text.Trim());
                //orderDetail.Model.modelId = this.selectedCarModelIdVal;
                orderDetail.Model = model;
                orderDetail.Model.modelId = model.modelId;

                // Add the new OrderDetail to the list
                orderDetailsList.Add(orderDetail);


            }
        }

        private void txtQuantityOnHand_TextChanged(object sender, EventArgs e)
        {

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
                    orderDetail.carId = item.Car.carId;
                    orderDetail.CarParts = null;
                    orderDetail.Order = order;
                    orderDetail.created_at = txtDate.Value;
                    orderDetail.qty = item.qty;
                    orderDetail.unitPrice = int.Parse(txtUnitPrice.Text);
                    //orderDetail.modelId = item.modelId;
                    orderDetail.status = "PEN";
                    _ordersController.SaveOrderDetails(orderDetail);
                    _carController.UpdateCarQty(item.Car.carId, item.qty);
                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Order placed Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridPlaceOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
