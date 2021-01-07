using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreExample.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using NetCoreExample.Models.EF;
using NetCoreExample.Models.Entities;
using NetCoreExample.Models.Repository;

namespace NetCoreExample.Controllers
{
    public class HomeController : Controller
    {

        private readonly MywebDbContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _productRepository;
        public HomeController(MywebDbContext context,
            IProductRepository productRepository,
            ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
            _productRepository = productRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TentityDemo()
        {
            Product p = new Product();
            p.ProductName = "dsds";
            p.UnitPrice = 10;
           _productRepository.AddAsync(p);
            //_context.Products.ToList()
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
