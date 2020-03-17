using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
    }
}
