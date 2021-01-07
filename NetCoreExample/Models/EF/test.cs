using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreExample.Models.EF
{
    public class test : IDesignTimeDbContextFactory<MywebDbContext>
    {
        public MywebDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("MywebDb");

            var optionsBuilder = new DbContextOptionsBuilder<MywebDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MywebDbContext(optionsBuilder.Options);
        }
    }
}
