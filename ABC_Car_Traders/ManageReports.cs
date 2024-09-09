using ABC_Car_Traders.Controllers;
using Microsoft.EntityFrameworkCore;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ABC_Car_Traders
{
    public partial class ManageReports : Form
    {
        private readonly CarController _carController;
        private readonly CarPartsController _carPartsController;
         private readonly UserController _userController;

        public ManageReports(CarController carController, CarPartsController carPartsController, UserController userController)
        {
            InitializeComponent();
            _carController = carController;
            _carPartsController = carPartsController;
            _userController = userController;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


        private void btnGenerateCarReports_Click(object sender, EventArgs e)
        {
            ////GenerateReportOnCars();
            _carController.GenerateCarInventoryReport();
            //MessageBox.Show("Inventory Report generated successfully!");
        }

        private void btnGenerateCarPartsReport_Click_1(object sender, EventArgs e)
        {
            _carPartsController.GenerateCarPartsInventoryReport();
        }

        private void btnGenerateCustomerReports_Click(object sender, EventArgs e)
        {
            _userController.GenerateCustomerReport();
        }
    }
}
