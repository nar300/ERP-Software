using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpBackend.Data;
using ErpBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Repository
{
    public class SalaryRepoImpl :BaseRepoImpl<Salary> ,ISalaryRepo
    {
        
        public SalaryRepoImpl(ErpDbContext _Db):base(_Db)
        {
            
        }
      

        public async Task<IEnumerable<Salary>> GetAll()
        {
            var list = await _db.Salaries.ToListAsync();
            return list;
        }

        public async Task<Salary> GetById(int id)
        {
           var getbyid= await _db.Salaries.FindAsync(id);
            return getbyid;
            
        }

       
    }
}
