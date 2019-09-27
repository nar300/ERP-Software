using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Models
{
    [Table("Employee")]
    public class Employee: Address
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="First Name Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Phone Required")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "NI number Required")]
        public string NiNumber { get; set; }
        [Required(ErrorMessage = "FirstName Required")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "D.O.B Required")]
        public DateTime DateofBirth { get; set; }
        [Required(ErrorMessage = "Marital status Required")]
        public string MaritalStatus { get; set; }


        [Required(ErrorMessage = "Employee Type Required")]
        public string EmployeeType { get; set; } = "Permanent";


        [Required(ErrorMessage = "Date of Join Required")]
        public DateTime DateofJoin { get; set; }
        [Required(ErrorMessage = "Mode of Recruitment Required")]
        public string  ModeofRecruitment  { get; set; }
        [Required(ErrorMessage = "Employee Stauts Required")]
        public string Status { get; set; }

        [Display(Name ="Education Details")]
        [Required(ErrorMessage = "Education Details Required")]
        public string Education { get; set; }
        [Display(Name = "Experience Details")]
        [Required(ErrorMessage = "Experience details Required")]
        public string Experience { get; set; }

        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public ICollection<Attendance> Attendances { get; set; } = new Collection<Attendance>();
        public ICollection<Leave> Leaves { get; set; } = new Collection<Leave>();
        public ICollection<Salary> Salaries { get; set; } = new Collection<Salary>();
        public ICollection<PayRoll> PayRolls { get; set; } = new Collection<PayRoll>();
        
        public Department Department { get; set; }
        public Designation  Designation { get; set; }
    }
   


}
