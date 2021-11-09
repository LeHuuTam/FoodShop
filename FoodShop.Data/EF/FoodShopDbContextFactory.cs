using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FoodShop.Data.EF
{
    public class FoodShopDbContextFactory : IDesignTimeDbContextFactory<FoodShopDbContext>
    {
        public FoodShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("FoodShopDb");

            var optionsBuilder = new DbContextOptionsBuilder<FoodShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new FoodShopDbContext(optionsBuilder.Options);
        }
    }
}
