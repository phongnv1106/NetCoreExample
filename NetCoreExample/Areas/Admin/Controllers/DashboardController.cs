using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreExample.Areas.Admin.Controllers
{
  
    public class DashboardController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        //
        public IActionResult Au()
        {
            var currentUser = HttpContext.User;
            int spendingTimeWithCompany = 0;

            if (currentUser.HasClaim(c => c.Type == "DateOfJoing"))
            {
                DateTime date = DateTime.Parse(currentUser.Claims.FirstOrDefault(c => c.Type == "DateOfJoing").Value);
                spendingTimeWithCompany = DateTime.Today.Year - date.Year;
            }

            if (spendingTimeWithCompany > 5)
            {
                return View();
            }
            else
            {
                return View();
            }
        }

        [Authorize(Policy = "RequireAdminOnly")]
        public IActionResult Analytic()
        {
            return View();
        }

        [Authorize(Policy = "RequireManagerOnly")]
        public IActionResult Data()
        {
            return View();
        }

        [Authorize(Policy = "ShouldBeOnlyEmployee")]
        public IActionResult About()
        {
            return View();
        }
    }
}
