using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Models
{
    [Table("Designation")]
    public class Designation
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Job Title Required")]
        [Display(Name ="Job Title")]
        public string JobTitle { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Division  Required")]
        public string Division { get; set; }

        [Required(ErrorMessage = "Report To  Required")]
        [Display(Name = "Report To")]
        public int ReportTo { get; set; }

        public ICollection<Employee> Employees { get; set; } = new Collection<Employee>();



    }
}
