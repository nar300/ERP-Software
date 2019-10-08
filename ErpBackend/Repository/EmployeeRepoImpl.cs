using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpBackend.Data;
using ErpBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Repository
{
    public class EmployeeRepoImpl : BaseRepoImpl<Employee>,EmployeeRepo
    {
      
        public EmployeeRepoImpl(ErpDbContext db):base(db)
        {
            
        }
       

        public async Task<IEnumerable<Employee>> GetAll()
        {
           var emplist = await _db.Employees.
                Include(emp=>emp.Attendances ).Include(emp=>emp.Leaves).
                Include(emp=>emp.Salaries).Include(emp=>emp.Designation).ToListAsync();
            return emplist;
        }

        public async Task<Employee> GetById(int id)
        {
           var Emp= await _db.Employees.Include(emp=>emp.Attendances).FirstOrDefaultAsync(emp => emp.Id == id);
            return Emp;
        }

       
    }
}
