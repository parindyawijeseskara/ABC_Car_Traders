using ABC_Car_Traders.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABC_Car_Traders
{
    public partial class ManageCustomerOrderActionForm : Form
    {
        private OrdersController _ordersController;
        private string _name;
        private string _date;
        private int orderId;

        public ManageCustomerOrderActionForm(String id, OrdersController ordersController, String name, String date)
        {
            InitializeComponent();
            cmbStatus.Items.Add("PEN");
            cmbStatus.Items.Add("ORDER CONFIRMED");
            cmbStatus.Items.Add("SHIPPED");
            cmbStatus.Items.Add("DELIVERD");


            _ordersController = ordersController;
            _name = name;
            _date = date;
            orderId = int.Parse(id);
            loadOrderDetailsById(id);
        }

        public void loadOrderDetailsById(string id)
        {
            var order = _ordersController.GetAllOrdersDetailsById(int.Parse(id));
            dataGridView1.DataSource = order;
            txtCustomerName.Text = this._name;
            dateTimePicker1.Text = this._date;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem != null)
            {
                // Get the selected item value
                string selectedItem = cmbStatus.SelectedItem.ToString();
                String status = selectedItem;
                _ordersController.UpdateOrderStatus(status, orderId);
                MessageBox.Show("Order status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
        }
    }
}
