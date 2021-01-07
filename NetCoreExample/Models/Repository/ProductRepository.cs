using NetCoreExample.Models.EF;
using NetCoreExample.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreExample.Models.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(MywebDbContext mywebDbContext) : base(mywebDbContext)
        {
        }
        public void zion()
        {
            Console.WriteLine("neo");
        }
    }
}
