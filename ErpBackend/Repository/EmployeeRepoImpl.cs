using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpBackend.Data;
using ErpBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Repository
{
    public class EmployeeRepoImpl : EmployeeRepo
    {
       private readonly ErpDbContext _db;
        public EmployeeRepoImpl(ErpDbContext db)
        {
            _db = db;
        }
        public async Task< Employee> Create(Employee body)
        {
            _db.Employees.Add(body);
            await _db.SaveChangesAsync();
            return body;
        }

        public async Task<Employee> Delete(Employee body)
        {
            _db.Employees.Remove(body);
            await _db.SaveChangesAsync();
            return body;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
           var emplist = await _db.Employees.
                Include(emp=>emp.Attendances ).Include(emp=>emp.Leaves).
                Include(emp=>emp.Salaries).ToListAsync();
            return emplist;
        }

        public async Task<Employee> GetById(int id)
        {
           var Emp= await _db.Employees.FirstOrDefaultAsync(emp => emp.Id == id);
            return Emp;
        }

        public async Task<bool> IsSaved()
        {
           
            return  await _db.SaveChangesAsync()>0;
        }

        public async Task<Employee> Update(Employee body, int id)
        {

            _db.Entry(body).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return body;
        }
    }
}
