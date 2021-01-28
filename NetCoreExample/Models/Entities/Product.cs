using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreExample.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public float UnitPrice { get; set; }
        public double doubleTest { get; set; }
        public string Description { get; set; }
        public string _company { get; set; }                 // công ty
        public string _employeeCode { get; set; }           // mã nhân viên
      //  public List<int> _verticalBranch { get; set; }
    }
}
