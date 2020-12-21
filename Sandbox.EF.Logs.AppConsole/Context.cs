using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Sandbox.EF.Logs.AppConsole
{
    public class Context : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=localhost;Database=ProductsDb;User Id=sa;Password=secret;")
                .LogTo(
                    Console.WriteLine,                          //Target delegate
                    new[] { DbLoggerCategory.Database.Name },   //Filter log messages
                    LogLevel.Information)                       //Control log level
                .EnableSensitiveDataLogging();                  //Show parameters. Watch out with sensitive data on production environment
        }
    }
}