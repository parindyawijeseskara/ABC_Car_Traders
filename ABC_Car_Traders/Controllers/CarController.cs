using ABC_Car_Traders.DBContext;
using ABC_Car_Traders.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders.Controllers
{
    public class CarController
    {
        private readonly ApplicationDBContext _context;
        public CarController(ApplicationDBContext context) 
        {
            _context = context;
        }

        public List<dynamic> GetAllCars()
        {
            return _context.Cars
                //.Where(car => car.deletedAt == null)
                .Select(car => new {
                car.carId,
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

        public Car getcarById(int carId)
        {
            //return _context.Cars.Find(carId);
            return _context.Cars
                  .Include(c => c.Model)
                  .ThenInclude(m => m.Brand)
                  .FirstOrDefault(c => c.carId == carId);


        }

         

        public void AddCar(Car car) 
        {
            car.createdAt = DateTime.Now;
            car.updatedAt = DateTime.Now;
            _context.Cars.Add(car);
            _context.SaveChanges();
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

        public void DeleteCar(int carId)
        {
            var car = _context.Cars.Find(carId);
            if (car != null)
            {
                car.deletedAt = DateTime.Now;
                car.status = "NOT AVAILABLE";
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

        public Brand GetBrandByName(string brand)
        {
            return _context.Brand.FirstOrDefault(b=>b.brandName == brand);
        }

        public Models GetModelByName(string modelName, int brandId)
        {
            return _context.Model.FirstOrDefault(m => m.modelName == modelName && m.brandId == brandId);
        }

        //get all cars by regNo
        public List<Car> GetCarsByRegNo(string regNo)
        {
            return _context.Cars
                .Where(car => car.regNo.Contains(regNo))
                .ToList();
        }

        public List<Car> GetCarsByStatus(string status)
        {
            return _context.Cars
                .Where (car => car.status.Contains(status))
                .ToList();
        }

        public dynamic GetCarOrCarPartDetails(string input)
        {
            var car = _context.Cars
            .Where(c => c.regNo == input)
            .Select(c => new
            {
                Brand = c.Model.Brand.brandName,
                Model = c.Model.modelName,
                ItemName = c.regNo,
                Price = c.price,
                Quantity = c.quantity
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


    }
}
