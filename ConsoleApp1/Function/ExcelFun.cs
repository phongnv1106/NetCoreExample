using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Function
{
    class ExcelFun
    {
        public static void readExcel()
        {
            string path = @"C:\Users\PC\Desktop\Mycode\user.xlsx";
            FileInfo fileInfo = new FileInfo(path);
        //    ExcelPackage.LicenseContext = LicenseContext.Commercial;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
                int rows = worksheet.Dimension.Rows;
                int columns = worksheet.Dimension.Columns;

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= columns; j++)
                    {
                        string content = worksheet.Cells[rows, 1].Value.ToString();
                        Console.WriteLine("user : " + content);
                        string pass = worksheet.Cells[rows, 2].Value.ToString();
                        Console.WriteLine("pass : " + pass);
                        Console.WriteLine("_______________ ");
                    }
                }
            }
        }
    }
}
