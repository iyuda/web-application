using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureDataLayer
{
    public class DepartmentEmployee
    {
        public int BusinessEntityID { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentName { get; set; }
        public string GroupName { get; set; }
        public DateTime StartDate { get; set; }
    }
}
