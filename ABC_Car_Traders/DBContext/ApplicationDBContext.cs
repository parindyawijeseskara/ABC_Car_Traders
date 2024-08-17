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
        public DbSet<Role> Role { get; set; }
        public DbSet<User > User { get; set; }
        //public DbSet<Login> Logins { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder(); // nuget pakage extenstion.configaration use
            builder.SetBasePath(Directory.GetCurrentDirectory()); // user nuget pakage configaraion .json
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true); // get json file conection string
            var configuration = builder.Build();
            optionsBuilder.UseMySql(configuration.GetConnectionString("DefaultConnection"),
            new MySqlServerVersion(new Version(8, 0, 21))); //  MySQL version here

        }
        public DbSet<Car> Cars {get; set;}   */


    }
    
}
