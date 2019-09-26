using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Models
{
    [Table("Leave")]
    public class Leave
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Leave Type Required")]
        public string LeaveType { get; set; }
        [Required(ErrorMessage = "Leave From date Required")]
        [Display(Name ="Leave From Date")]
        public DateTime LeaveFromDate { get; set; }
        [Required(ErrorMessage = "Leave To date Required")]
        [Display(Name = "Leave To Date")]
        public DateTime LeaveToDate { get; set; }
        public string Description { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
   
}
