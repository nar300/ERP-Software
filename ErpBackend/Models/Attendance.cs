using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Models
{
    public class Attendance
    {
        public int id { get; set; }
        [Required(ErrorMessage = "date")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Attendance type eg:halfday Required")]
        public string Type { get; set; }
        public string Description { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}

