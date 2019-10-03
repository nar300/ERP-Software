using ErpBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Data
{
    public class ErpDbContext:DbContext
    {
        public ErpDbContext(DbContextOptions<ErpDbContext> options) : base(options) { } 
            
      
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Department> Departments { get; set; }
        
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<PayRoll> PayRolls { get; set; }
       
    }
}
