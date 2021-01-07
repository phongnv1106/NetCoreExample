using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreExample.Models.Entities;
namespace NetCoreExample.Models.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        void zion();
    }
}
