using ABC_Car_Traders.DBContext;
using ABC_Car_Traders.Model;
using Microsoft.EntityFrameworkCore;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ABC_Car_Traders.Controllers
{
    public class CarPartsController
    {
        private readonly ApplicationDBContext _context;
        public CarPartsController(ApplicationDBContext context)
        { 
            _context = context;
        }

        public List<dynamic> GetAllCarParts()
        {
            return _context.CarParts
                // .Where(carParts => carParts.deletedAt == null)
                .Select(carParts => new
                {
                    carParts.carPartId,
                    carParts.carPartName,
                    carParts.image,
                    carParts.Model.modelName,
                    carParts.Model.Brand.brandName,
                    carParts.price,
                    carParts.quantity,
                    carParts.description,
                    carParts.manufacturer,
                    carParts.warrantyPeriod,
                    carParts.status
                }).ToList<dynamic>();
        }
       
        public CarParts getCarPartById(int carPartId)
        {
            //return _context.CarParts.Find(carPartId);
            return _context.CarParts
                  .Include(c => c.Model)
                  .ThenInclude(m => m.Brand)
                  .FirstOrDefault(c => c.carPartId == carPartId);
        }

        public void AddCarParts(CarParts carParts)
        {
            carParts.createdAt = DateTime.Now;
            carParts.updatedAt = DateTime.Now;
            _context.CarParts.Add(carParts);
            _context.SaveChanges();
        }

        public void UpdateCarParts(CarParts carParts)
        {
            carParts.updatedAt = DateTime.Now;
            var existingCarPart = _context.CarParts.Find(carParts.carPartId);
            if (existingCarPart != null)
            {
                existingCarPart.carPartName = carParts.carPartName;
                existingCarPart.modelId = carParts.modelId;
                existingCarPart.price = carParts.price;
                existingCarPart.quantity = carParts.quantity;
                existingCarPart.description = carParts.description;
                existingCarPart.manufacturer = carParts.manufacturer;
                existingCarPart.warrantyPeriod = carParts.warrantyPeriod;
                existingCarPart.image = carParts.image;
                existingCarPart.status = carParts.status;
                _context.SaveChanges();
            }
        }

        public void DeleteCarPart(int carPartId)
        {
            var partId = _context.CarParts.Find(carPartId);
            if (partId != null)
            {
                partId.deletedAt = DateTime.Now;
                partId.status = "NOT AVAILABLE";
                // _context.Cars.Remove(car);
                _context.SaveChanges();
            }
        }

        ////GetAllCarsByYear
        //public List<dynamic> GetAllCarPartsByName(string carPartName)
        //{
        //    return _context.CarParts
        //    .Where(carPrts => carPrts.deletedAt == null && carPrts.carPartName == carPartName)
        //    .Select(carPrts => new
        //    {

        //    })
        //    .ToList<dynamic>();
        //}
        public Brand GetBrandByName(string brand)
        {
            return _context.Brand.FirstOrDefault(b => b.brandName == brand);
        }

        public Models GetModelByName(string modelName, int brandId)
        {
            return _context.Model.FirstOrDefault(m => m.modelName == modelName && m.brandId == brandId);
        }

        public void AddBrand(Brand brand)
        {
            _context.Brand.Add(brand);
            _context.SaveChanges();
        }
        public void AddModel(Models model)
        {
            _context.Model.Add(model);
            _context.SaveChanges();
        }

        public List<dynamic> SearchCarPartsByBrandAndModel(int brandId, int modelId)
        {
            return _context.CarParts
                .Where(carParts => carParts.Model.brandId == brandId && carParts.Model.modelId == modelId)
                .Select(carParts => new
                {
                    carParts.carPartId,
                    carParts.carPartName,
                    BrandName = carParts.Model.Brand.brandName,
                    ModelName = carParts.Model.modelName,
                    carParts.price,
                    carParts.description,
                    carParts.quantity,
                    carParts.manufacturer,
                    carParts.warrantyPeriod,
                    carParts.status
                })
                .ToList<dynamic>();
        }

        public List<dynamic> GetAllBrands()
        {
            return _context.Brand
            .Select(brand => new
            {
                brand.brandId,
                brand.brandName
            })
            .ToList<dynamic>();
        }

        // Get models by brand
        public List<dynamic> GetModelsByBrand(int brandId)
        {
            return _context.Model
                .Where(model => model.brandId == brandId)
                .Select(model => new
                {
                    model.modelId,
                    model.modelName
                })
                .ToList<dynamic>();
        }

        //get all cars by car part name
        public List<CarParts> GetCarsByPartName(string carPartName)
        {
            return _context.CarParts
                .Where(carPart => carPart.carPartName.Contains(carPartName))
                .ToList();
        }

        // Get all car parts by model ID and part name
        public List<CarParts> GetCarPartsByModelIdAndPartName(int modelId, string carPartName)
        {
            return _context.CarParts
                .Where(carPart => carPart.modelId == modelId && carPart.carPartName.Contains(carPartName))
                .ToList();
        }

        //Get all cars by prices
        public List<dynamic> GetAllCarPartsByPrices(decimal priceFrom, decimal priceTo)
        {
            return _context.CarParts
            .Where(carPart => carPart.deletedAt == null && carPart.price >= priceFrom && carPart.price <= priceTo)
            .Select(carPart => new
            {
                carPart.carPartId,
                carPart.carPartName,
                carPart.Model.modelName,
                carPart.Model.Brand.brandName,
                carPart.price,
                carPart.quantity,
                carPart.description,
                carPart.manufacturer,
                carPart.warrantyPeriod,
                carPart.status
            })
            .ToList<dynamic>();
        }

        public int GetTotalCarParts()
        {
            try
            {
                return _context.CarParts.Count();  // Get the total number of car parts
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving total car parts: {ex.Message}");
            }
        }


        public void GenerateCarPartsInventoryReport()
        {
            var carPartsInventory = _context.CarParts
                .Include(cp => cp.Model)
                .ThenInclude(m => m.Brand)
                .Select(cp => new
                {
                    cp.carPartId,
                    cp.carPartName,
                    cp.Model.modelName,
                    cp.Model.Brand.brandName,
                    cp.quantity,
                    cp.price,
                    cp.status
                })
                .ToList();

            if (carPartsInventory == null || !carPartsInventory.Any())
            {
                MessageBox.Show("No car parts data available to generate the report.");
                return;
            }

            var document = new PdfDocument();
            var page = document.AddPage();
            var gfx = XGraphics.FromPdfPage(page);
            var fontTitle = new XFont("Arial", 18, XFontStyleEx.Bold);
            var fontHeader = new XFont("Arial", 12, XFontStyleEx.Bold);
            var fontRegular = new XFont("Arial", 10, XFontStyleEx.Regular);
            var headerBrush = XBrushes.White;
            var evenRowBrush = XBrushes.LightGray;
            var oddRowBrush = XBrushes.White;
            var headerBackgroundBrush = new XSolidBrush(XColor.FromArgb(0, 51, 102));
            var titleBrush = XBrushes.Black;

            // Title
            gfx.DrawString("Car Parts Inventory Report", fontTitle, titleBrush, new XRect(0, 0, page.Width, 50), XStringFormats.Center);

            // Table Headers
            int yPoint = 70;
            int xPoint = 20;

            double[] columnWidths = { 50, 100, 100, 100, 70, 70, 70 };
            string[] headers = { "Part ID", "Part Name", "Model", "Brand", "Quantity", "Price", "Status" };

            gfx.DrawRectangle(headerBackgroundBrush, xPoint, yPoint, page.Width - 40, 20);

            for (int i = 0; i < headers.Length; i++)
            {
                gfx.DrawString(headers[i], fontHeader, headerBrush, new XRect(xPoint, yPoint, columnWidths[i], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[i];
            }

            yPoint += 20;

            // Draw Rows
            bool isEvenRow = true;
            foreach (var part in carPartsInventory)
            {
                xPoint = 20;
                var rowBrush = isEvenRow ? evenRowBrush : oddRowBrush;
                gfx.DrawRectangle(rowBrush, xPoint, yPoint, page.Width - 40, 20);

                gfx.DrawString(part.carPartId.ToString(), fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[0], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[0];

                gfx.DrawString(part.carPartName, fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[1], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[1];

                gfx.DrawString(part.modelName, fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[2], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[2];

                gfx.DrawString(part.brandName, fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[3], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[3];

                gfx.DrawString(part.quantity.ToString(), fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[4], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[4];

                gfx.DrawString(part.price.ToString("C2"), fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[5], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[5];

                gfx.DrawString(part.status, fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[6], 20), XStringFormats.Center);

                yPoint += 20;
                isEvenRow = !isEvenRow;

                // Add a new page if the content exceeds the page height
                if (yPoint > page.Height - 50)
                {
                    page = document.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    yPoint = 50; // reset yPoint for new page
                }
            }

            // Save the document to the Downloads folder
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string filePath = Path.Combine(downloadsPath, "CarPartsInventoryReport.pdf");
            document.Save(filePath);
            document.Close();

            MessageBox.Show($"Car Parts Inventory Report generated successfully! Saved to: {filePath}");
        }

    }
}
