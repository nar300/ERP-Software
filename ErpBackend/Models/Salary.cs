using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public double Rate { get; set; }
        public string Hour { get; set; }
        public string Description { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }

   
}
