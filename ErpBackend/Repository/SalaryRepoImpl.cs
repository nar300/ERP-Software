using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpBackend.Data;
using ErpBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Repository
{
    public class SalaryRepoImpl : ISalaryRepo
    {
        private readonly ErpDbContext _db;
        public SalaryRepoImpl(ErpDbContext _Db)
        {
            _db = _Db;
        }
        public async Task<Salary> Create(Salary body)
        {
            _db.Salaries.Add(body);
            await _db.SaveChangesAsync();
            return body;
        }

        public async Task<Salary> Delete(Salary body)
        {
            _db.Salaries.Remove(body);
            await _db.SaveChangesAsync();
            return body;
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

        public async Task<bool> IsSaved()
        {
          return  await _db.SaveChangesAsync() > 0;
        }

        public async Task<Salary> Update(Salary body, int id)
        {
            _db.Entry(body).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return body;
        }
    }
}
