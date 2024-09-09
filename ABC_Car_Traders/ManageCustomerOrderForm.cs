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
using static System.Windows.Forms.DataFormats;

namespace ABC_Car_Traders
{
    public partial class ManageCustomerOrderForm : Form
    {
        private readonly CarController _carController;
        private OrdersController _ordersController;
        public ManageCustomerOrderForm(CarController carController, OrdersController ordersController)
        {
            InitializeComponent();
            _carController = carController;
            _ordersController = ordersController;
            orderDetailsGird.AutoGenerateColumns = false;
            loadOrderDetails();
        }

        public void loadOrderDetails()
        {
            var orderdetails = _ordersController.GetAllOrders();
            orderDetailsGird.DataSource = orderdetails;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == orderDetailsGird.Columns["Column5"].Index ))
            {
                if (e.ColumnIndex == orderDetailsGird.Columns["Column5"].Index)
                {
                    //OpenForm2();
                    var valueAtZeroIndex = orderDetailsGird.Rows[e.RowIndex].Cells[0].Value.ToString();
                    var valueAtfIRSTIndex = orderDetailsGird.Rows[e.RowIndex].Cells[1].Value.ToString();
                    var valueAtForthIndex = orderDetailsGird.Rows[e.RowIndex].Cells[7].Value.ToString();
                    OpenForm2(valueAtZeroIndex, valueAtfIRSTIndex, valueAtForthIndex);
                }
            }
        }

        private void OpenForm2(String value, String value2, String value3)
        {
            ManageCustomerOrderActionForm form2 = new ManageCustomerOrderActionForm(value, _ordersController, value2, value3);
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the customer name from the TextBox
            string firstName = txtCustomerName.Text.Trim();

            var orders = _ordersController.GetOrdersByUserFirstName(firstName);

            // If orders are found, display them in the DataGridView
            if (orders != null && orders.Count > 0)
            {
                orderDetailsGird.DataSource = orders;
            }
            else
            {
                MessageBox.Show("No orders found for the given first name.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                orderDetailsGird.DataSource = null; // Clear the grid if no results
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
