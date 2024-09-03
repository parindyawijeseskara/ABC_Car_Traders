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

namespace ABC_Car_Traders
{
    public partial class MyOrdersForm : Form
    {
        private readonly CarController _carController;
        private OrdersController _ordersController;
        public MyOrdersForm(CarController carController, OrdersController ordersController)
        {
            InitializeComponent();
            _carController = carController;
            _ordersController = ordersController;
            orderGridView.AutoGenerateColumns = false;
            loadOrderDetails();
        }

        public void loadOrderDetails()
        {
            var orderdetails = _ordersController.GetAllOrders();
            orderGridView.DataSource = orderdetails;
        }

        private void orderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
