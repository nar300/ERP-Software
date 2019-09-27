using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpBackend.Data;
using ErpBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Repository
{
    public class DepartmentImpl :BaseRepoImpl<Department> ,IDepartmentRepo
    {
       
        public DepartmentImpl(ErpDbContext db):base(db)
        {
            
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

       
    }
}
