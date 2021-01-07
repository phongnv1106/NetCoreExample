using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreExample.Models.Entities;
namespace NetCoreExample.Models.EF
{
    public class MywebDbContext : DbContext
    {
        public MywebDbContext()
        {
        }

        public MywebDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
