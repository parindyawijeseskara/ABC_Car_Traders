﻿using ABC_Car_Traders.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders.DBContext
{
    internal class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder(); // nuget pakage extenstion.configaration use
            builder.SetBasePath(Directory.GetCurrentDirectory()); // user nuget pakage configaraion .json
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true); // get json file conection string
            var configuration = builder.Build();
            optionsBuilder.UseMySql(configuration.GetConnectionString("DefaultConnection"),
            new MySqlServerVersion(new Version(8, 0, 21))); //  MySQL version here

        }
        public DbSet<abc> abc {get; set;}   
    }
}
