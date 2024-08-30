using ABC_Car_Traders.DBContext;
using ABC_Car_Traders.Model;
using Microsoft.EntityFrameworkCore;
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
    }
}
