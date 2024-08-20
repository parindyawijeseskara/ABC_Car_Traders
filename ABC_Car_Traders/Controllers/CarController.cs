using ABC_Car_Traders.DBContext;
using ABC_Car_Traders.Model;
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
                .Where(car => car.deletedAt == null)
                .Select(car => new {
                car.carId,
                car.model,
                car.brand,
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
            return _context.Cars.Find(carId);

           
        }

        public void AddCar(Car car) 
        {
            car.createdAt = DateTime.Now;
            car.updatedAt = DateTime.Now;
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        public void UpdateCar(Car car)
        {
            car.updatedAt = DateTime.Now;
            var existingCar = _context.Cars.Find(car.carId);
            if (existingCar != null)
            {
                existingCar.carName = car.carName;  
                existingCar.brand = car.brand;
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
               // _context.Cars.Remove(car);
                _context.SaveChanges();
            }
        }

        //Get all car models 
        public List<dynamic> GetCarsByModel(string model)
        {
            return _context.Cars
            .Where(car => car.deletedAt == null && car.model == model)
            .Select(car => new {
                car.carId,
                car.model,
                car.brand,
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
                car.model,
                car.brand,
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
                car.model,
                car.brand,
                car.year,
                car.price,
                car.description,
                car.quantity,
                car.transmission,
                car.status
            })
            .ToList<dynamic>();
        }
    }
}
