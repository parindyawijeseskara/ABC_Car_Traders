using ABC_Car_Traders.DBContext;
using ABC_Car_Traders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                 .Where(carParts => carParts.deletedAt == null)
                .Select(carParts => new
                {
                    carParts.carPartId,
                    carParts.carPartName,
                    carParts.image,
                    carParts.model,
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
            return _context.CarParts.Find(carPartId);
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
                existingCarPart.model = carParts.model;
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
                // _context.Cars.Remove(car);
                _context.SaveChanges();
            }
        }
    }
}
