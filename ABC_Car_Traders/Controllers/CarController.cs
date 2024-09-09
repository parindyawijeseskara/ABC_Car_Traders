using ABC_Car_Traders.DBContext;
using ABC_Car_Traders.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = ABC_Car_Traders.Model.User;

namespace ABC_Car_Traders.Controllers
{
    public class CarController
    {
        private readonly ApplicationDBContext _context;
        public CarController(ApplicationDBContext context) 
        {
            _context = context;
        }

        //Get all Cars
        public List<dynamic> GetAllCars()
        {
            return _context.Cars
                //.Where(car => car.deletedAt == null)
                .Select(car => new {
                car.carId,
                car.image,
                car.Model.modelName,
                car.Model.Brand.brandName,
                car.regNo,
                car.year,
                car.price,
                car.description,
                car.quantity,
                car.transmission,
                car.status
            }).ToList<dynamic>();
        }

        //Get all available cars 
        public List<dynamic> GetAllCarsInCustomerDashBoard()
        {
            return _context.Cars
                .Where(car => car.deletedAt == null)
                .Select(car => new {
                    car.carId,
                    car.image,
                    car.Model.modelName,
                    car.Model.Brand.brandName,
                    car.regNo,
                    car.year,
                    car.price,
                    car.description,
                    car.quantity,
                    car.transmission,
                    car.status
                }).ToList<dynamic>();
        }
        //Get cars by carId
        public Car getcarById(int carId)
        {
            //return _context.Cars.Find(carId);
            return _context.Cars
                  .Include(c => c.Model)
                  .ThenInclude(m => m.Brand)
                  .FirstOrDefault(c => c.carId == carId);
        }
        
        //Get cars by RegNo
        public Car getcarByRegNo(String regNo)
        {
            //return _context.Cars.Find(carId);
            return _context.Cars.FirstOrDefault(b => b.regNo == regNo);


        }
        //Add cars
        public void AddCar(Car car) 
        {
            car.createdAt = DateTime.Now;
            car.updatedAt = DateTime.Now;
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        public void AddCarImage(CarImages carImage)
        {
            // Add the image to the CarImages table in the database
            _context.CarImages.Add(carImage);
            _context.SaveChanges();
        }

        //Get car brand
        public void AddBrand(Brand brand)
        {
            _context.Brand.Add(brand);
            _context.SaveChanges();
        }

        // Add car models
        public void AddModel(Models model)
        {
            _context.Model.Add(model);
            _context.SaveChanges();
        }

        // Update cars
        public void UpdateCar(Car car)
        {
            car.updatedAt = DateTime.Now;
            var existingCar = _context.Cars.Find(car.carId);
            if (existingCar != null)
            {
                existingCar.regNo = car.regNo;  
                existingCar.Model = car.Model;
                existingCar.year = car.year;
                existingCar.price = car.price;
                existingCar.description = car.description;
                existingCar.quantity = car.quantity;
                existingCar.transmission = car.transmission;
                existingCar.image = car.image;
                existingCar.status = car.status;
                _context.SaveChanges();
            }
        }

        //Deelete cars
        public void DeleteCar(int carId)
        {
            var car = _context.Cars.Find(carId);
            if (car != null)
            {
                car.deletedAt = DateTime.Now;
                car.status = "Not Available";
                // _context.Cars.Remove(car);
                _context.SaveChanges();
            }
        }

        //Get all car models 
        public List<dynamic> GetCarsByModel(int model)
        {
            return _context.Cars
            .Where(car => car.deletedAt == null && car.Model.modelId == model)
            .Select(car => new {
                car.carId,
                car.regNo,
                car.Model,
                car.year,
                car.price,
                car.description,
                car.quantity,
                car.transmission,
                car.status
            })
            .ToList<dynamic>();
        }

        //Get all cars by year
        public List<dynamic> GetAllCarsByYear(string year)
        {
            return _context.Cars
            .Where(car => car.deletedAt == null && car.year == year)
            .Select(car => new
            {
                car.carId,
                car.regNo,
                car.Model.modelName,
                car.Model.Brand.brandName,
                car.year,
                car.price,
                car.description,
                car.quantity,
                car.transmission,
                car.status
            })
            .ToList<dynamic>();
        }

        //Get all cars by prices
        public List<dynamic> GetAllCarsByPrice(decimal priceFrom, decimal priceTo)
        {
            return _context.Cars
            .Where(car => car.deletedAt == null && car.price >= priceFrom && car.price <= priceTo) 
            .Select(car => new
            {
                car.carId,
                car.regNo,
                car.Model.modelName,
                car.Model.Brand.brandName,
                car.year,
                car.price,
                car.description,
                car.quantity,
                car.transmission,
                car.status
            })
            .ToList<dynamic>();
        }

        //Get all models
        public List<dynamic> GetAllModel()
        {
            return _context.Model
            .Select(model => new
            {
                model.modelId,
                model.modelName
            })
            .ToList<dynamic>();
        }

        //Get all car brands
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

        //Get cars by brand and model
        public List<dynamic> SearchCarsByBrandAndModel(int brandId, int modelId)
        {
            return _context.Cars
                .Where(car => car.Model.brandId == brandId && car.Model.modelId == modelId)
                .Select(car => new
                {
                    car.carId,
                    BrandName = car.Model.Brand.brandName,
                    ModelName = car.Model.modelName,
                    car.year,
                    car.price,
                    car.description,
                    car.quantity,
                    car.transmission,
                    car.regNo,
                    car.status
                })
                .ToList<dynamic>();
        }

        //Get cars by brand Name
        public Brand GetBrandByName(string brand)
        {
            return _context.Brand.FirstOrDefault(b=>b.brandName == brand);
        }

        //Get cars by model name
        public Models GetModelByName(string modelName, int brandId)
        {
            return _context.Model.FirstOrDefault(m => m.modelName == modelName && m.brandId == brandId);
        }

        //Get cars by regNo
        public List<Car> GetCarsByRegNo(string regNo)
        {
            return _context.Cars
                .Where(car => car.regNo.Contains(regNo))
                .ToList();
        }
        //Get caras by status
        public List<Car> GetCarsByStatus(string status)
        {
            return _context.Cars
                .Where (car => car.status.Contains(status))
                .ToList();
        }

        // Get related Car or Car part details by regno or car part name
        public dynamic GetCarOrCarPartDetails(string input)
        {
            var car = _context.Cars
            .Where(c => c.regNo == input)
            .Select(c => new
            {
                Brand = c.Model.Brand.brandName ?? string.Empty,  // Handle potential NULL for Brand
                Model = c.Model.modelName ?? string.Empty,        // Handle potential NULL for Model
                ItemName = c.regNo ?? string.Empty,               // Handle potential NULL for regNo
                Price = c.price,                             // Handle potential NULL for Price (assuming it's nullable)
                Quantity = c.quantity, 
                modelId = c.Model.modelId// Handle potential NULL for Quantity (assuming it's nullable)
            })
            .FirstOrDefault();

            if (car != null)
            {
                return car;
            }

            var carPart = _context.CarParts
            .Where(cp => cp.carPartName == input)
            .Select(cp => new
            {
                Brand = cp.Model.Brand.brandName,
                Model = cp.Model.modelName,
                ItemName = cp.carPartName,
                Price = cp.price,
                Quantity = cp.quantity
            })
            .FirstOrDefault();

            return carPart;
        }

        // Get customer details for order by nic
        public dynamic GetCustomerDetailsForOrder(string input)
        {
            var userDeatils = _context.User
            .Where(user => user.nic == input)
            .Select(user => new
            {
                Name = user.firstName,
                Address = user.address,
                ItemName = user.nic,
                Email = user.email,
                ContactNo = user.contactNo
            })
            .FirstOrDefault();

            return userDeatils;
        }

        // Get user by nic
        public User GetUserByNIC(String nic)
        {
            return _context.User.FirstOrDefault(b => b.nic == nic);
        }

        // Get total no of cars
        public int GetTotalCars()
        {
            try
            {
                return _context.Cars.Count();  // Get the total number of cars
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving total cars: {ex.Message}");
            }
        }

        // Function to generate car inventory report
        public void GenerateCarInventoryReport()
        {
            var carsInventory = GetAllCars();

            if (carsInventory == null || !carsInventory.Any())
            {
                MessageBox.Show("No car data available to generate the report.");
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
            gfx.DrawString("Car Inventory Report", fontTitle, titleBrush, new XRect(0, 0, page.Width, 50), XStringFormats.Center);

            // Table Headers
            int yPoint = 70;
            int xPoint = 20;

            double[] columnWidths = { 50, 100, 100, 60, 50, 70, 50, 70 };
            string[] headers = { "Car ID", "Model", "Brand", "Reg No", "Year", "Price", "Quantity", "Status" };

            gfx.DrawRectangle(headerBackgroundBrush, xPoint, yPoint, page.Width - 40, 20);

            for (int i = 0; i < headers.Length; i++)
            {
                gfx.DrawString(headers[i], fontHeader, headerBrush, new XRect(xPoint, yPoint, columnWidths[i], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[i];
            }

            yPoint += 20;

            // Draw Rows
            bool isEvenRow = true;
            foreach (var car in carsInventory)
            {
                xPoint = 20;
                var rowBrush = isEvenRow ? evenRowBrush : oddRowBrush;
                gfx.DrawRectangle(rowBrush, xPoint, yPoint, page.Width - 40, 20);

                gfx.DrawString(car.carId.ToString(), fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[0], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[0];

                gfx.DrawString(car.modelName, fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[1], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[1];

                gfx.DrawString(car.brandName, fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[2], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[2];

                gfx.DrawString(car.regNo, fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[3], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[3];

                gfx.DrawString(car.year.ToString(), fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[4], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[4];

                gfx.DrawString(car.price.ToString("C2"), fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[5], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[5];

                gfx.DrawString(car.quantity.ToString(), fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[6], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[6];

                gfx.DrawString(car.status, fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[7], 20), XStringFormats.Center);

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
            string filePath = Path.Combine(downloadsPath, "CarInventoryReport.pdf");
            document.Save(filePath);
            document.Close();

            MessageBox.Show($"Car Inventory Report generated successfully! Saved to: {filePath}");
        }

        // Update Car Qty in Order
        public void UpdateCarQty(int carId, int qty)
        {
            var existingCar = _context.Cars.Find(carId);
            if (existingCar != null)
            {
                existingCar.updatedAt = DateTime.Now;
                existingCar.quantity = (existingCar.quantity - qty);
                _context.SaveChanges();
            }
        }

        public Models GetModelById(int modelId)
        {
            return _context.Model.Find(modelId);
        }


    }
}
