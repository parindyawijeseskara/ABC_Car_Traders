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
            return _context.Cars.Select(car => new {
                car.carId,
                car.model,
                car.brand,
                car.year,
                car.price,
                car.description,
                car.quantity,
                car.transmission
            }).ToList<dynamic>();
        }
        public void AddCar(Car car) 
        {
            car.createdAt = DateTime.Now;
            car.updatedAt = DateTime.Now;
            _context.Cars.Add(car);
            _context.SaveChanges();
        }
    }
}
