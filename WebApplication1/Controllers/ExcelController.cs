using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult Upload()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
                    var rows = worksheet.Dimension.Rows;
                    int columns = worksheet.Dimension.Columns;
                    for (int i = 1; i <= rows; i++)
                    {
                        for (int j = 1; j <= columns; j++)
                        {
                            string content = worksheet.Cells[i, j].Value.ToString();
                            Console.WriteLine(content);
                          
                        }
                    }
                }
            }


           
            return View();
        }
    }
}
