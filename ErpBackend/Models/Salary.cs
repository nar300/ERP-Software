using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Models
{
    [Table("Salary")]
    public class Salary
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Pay Rate required")]
        public double Rate { get; set; }
        [Required(ErrorMessage = "Rate type required")]
        public string RateType { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Pay type required")]
        public string PayType { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }

   
}
