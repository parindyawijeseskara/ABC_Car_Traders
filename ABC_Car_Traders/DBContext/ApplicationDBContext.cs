using ABC_Car_Traders.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders.DBContext
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarParts> CarParts { get; set; }
        public DbSet<CarImages> CarImages { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User > User { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Models> Model { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Payment> Payment { get; set; }


    }
    
}
