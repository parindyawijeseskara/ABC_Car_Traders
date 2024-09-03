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

        /*public void GenerateReportOnCars()
        {
            try
            {
                var carsInventory = _carController.GetAllCars();

                PdfDocument document = new PdfDocument();
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                var fontRegular = new XFont("Verdana", 12, XFontStyleEx.Regular);
                var fontBold = new XFont("Verdana", 12, XFontStyleEx.Bold);


                // Title
                gfx.DrawString("Inventory Report", fontRegular, XBrushes.Black, new XRect(0, 0, page.Width, 40), XStringFormats.TopCenter);

                // Cars Inventory Table Headers
                int yPoint = 50;
                gfx.DrawString("Cars Inventory", fontRegular, XBrushes.Black, new XRect(20, yPoint, page.Width, 20), XStringFormats.TopLeft);

                yPoint += 25;
                gfx.DrawString("Car ID", fontRegular, XBrushes.Black, new XRect(20, yPoint, page.Width, 20), XStringFormats.TopLeft);
                gfx.DrawString("Model", fontRegular, XBrushes.Black, new XRect(100, yPoint, page.Width, 20), XStringFormats.TopLeft);
                gfx.DrawString("Year", fontRegular, XBrushes.Black, new XRect(180, yPoint, page.Width, 20), XStringFormats.TopLeft);
                gfx.DrawString("Quantity", fontRegular, XBrushes.Black, new XRect(260, yPoint, page.Width, 20), XStringFormats.TopLeft);
                gfx.DrawString("Price", fontRegular, XBrushes.Black, new XRect(340, yPoint, page.Width, 20), XStringFormats.TopLeft);
                gfx.DrawString("Status", fontRegular, XBrushes.Black, new XRect(420, yPoint, page.Width, 20), XStringFormats.TopLeft);

                yPoint += 25;

                foreach (var car in carsInventory)
                {
                    gfx.DrawString(car.carId, fontRegular, XBrushes.Black, new XRect(20, yPoint, page.Width, 20), XStringFormats.TopLeft);
                    gfx.DrawString(car.Model.Name, fontRegular, XBrushes.Black, new XRect(100, yPoint, page.Width, 20), XStringFormats.TopLeft);
                    gfx.DrawString(car.Year.ToString(), fontRegular, XBrushes.Black, new XRect(180, yPoint, page.Width, 20), XStringFormats.TopLeft);
                    gfx.DrawString(car.Quantity, fontRegular, XBrushes.Black, new XRect(260, yPoint, page.Width, 20), XStringFormats.TopLeft);
                    gfx.DrawString(car.Price.ToString("C2"), fontRegular, XBrushes.Black, new XRect(340, yPoint, page.Width, 20), XStringFormats.TopLeft);
                    gfx.DrawString(car.Quantity > 0 ? "In Stock" : "Out of Stock", fontRegular, XBrushes.Black, new XRect(420, yPoint, page.Width, 20), XStringFormats.TopLeft);

                    yPoint += 20;
                }
                var totalCarValue = carsInventory.Sum(c => c.Price * c.Quantity);
                //var totalPartValue = partsInventory.Sum(p => p.Price * p.Quantity);
                //gfx.DrawString($"Total Inventory Value: {(totalCarValue + totalPartValue).ToString("C2")}", fontRegular, XBrushes.Black, new XRect(20, yPoint + 20, page.Width, 20), XStringFormats.TopLeft);

                /// Save the document to the Downloads folder
                string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                string filePath = Path.Combine(downloadsPath, "InventoryReport.pdf");
                document.Save(filePath);
                document.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to generate report: {ex.Message}");
            }

        }*/



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
