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
            if (e.RowIndex >= 0 && (e.ColumnIndex == orderDetailsGird.Columns["Column5"].Index || e.ColumnIndex == orderDetailsGird.Columns["Column6"].Index))
            {
                if (e.ColumnIndex == orderDetailsGird.Columns["Column5"].Index)
                {
                    OpenForm1();
                }
                else if (e.ColumnIndex == orderDetailsGird.Columns["Column6"].Index)
                {
                    OpenForm2();
                }
            }
        }
        private void OpenForm1()
        {
            AdminViewOrderDetailsForm form1 = new AdminViewOrderDetailsForm();
            form1.Show();
        }

        private void OpenForm2()
        {
            ManageCustomerOrderActionForm form2 = new ManageCustomerOrderActionForm();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
