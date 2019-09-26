using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpBackend.Data;
using ErpBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Repository
{
    public class DepartmentImpl : IDepartmentRepo
    {
       private readonly ErpDbContext _db;
        public DepartmentImpl(ErpDbContext db)
        {
            _db = db;
        }
        public async Task<Department> Create(Department body)
        {
            _db.Departments.Add(body);
           await _db.SaveChangesAsync();
            return body;
            
        }

        public async Task<Department> Delete(Department body)
        {
            _db.Departments.Remove(body);
            await _db.SaveChangesAsync();
            return body;
        }

        public async Task<IEnumerable<Department>> GetAll()
        {
            var dpt = await _db.Departments.ToListAsync();
            return dpt;
        }

        public async Task<Department> GetById(int id)
        {
          var dptbyid= await _db.Departments.FindAsync(id);
            return dptbyid;

        }

        public async Task<bool> IsSaved()
        {
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<Department> Update(Department body, int id)
        {
            _db.Entry(body).State = EntityState.Modified;
           await _db.SaveChangesAsync();
            return body;
        }
    }
}
