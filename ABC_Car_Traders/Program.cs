using ABC_Car_Traders.Controllers;
using ABC_Car_Traders.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ABC_Car_Traders
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();
            optionsBuilder.UseMySql(configuration.GetConnectionString("DefaultConnection"),
                                    new MySqlServerVersion(new Version(8, 0, 21)));

            var context = new ApplicationDBContext(optionsBuilder.Options);
            var carController = new CarController(context);
            var carPartController = new CarPartsController(context);
            //var loginController = new LoginController(context);

            Application.Run(new AdminDashboard(carController, carPartController));
            //Application.Run(new LoginForm());
            //AdminDashboard

        }

    }
}