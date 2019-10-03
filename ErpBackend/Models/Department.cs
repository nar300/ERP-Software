using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Department Name Required")]
        public string DepartmentName { get; set; }
        
        public string Description { get; set; }

        public ICollection<Employee> Employees { get; set; } = new Collection<Employee>();
    }
}
