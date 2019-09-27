using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Models
{
    public class PayRoll
    {
        public int Id { get; set; }
        public int Tax { get; set; }
        public int NationalInsurance { get; set; }
        public int Pension { get; set; }
        public int Total { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}

