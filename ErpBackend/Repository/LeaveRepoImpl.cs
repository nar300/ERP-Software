using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpBackend.Data;
using ErpBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Repository
{
    public class LeaveRepoImpl : ILeaveRepo
    {
        private readonly ErpDbContext _db;

        public LeaveRepoImpl(ErpDbContext _Db)
        {
            _db = _Db;
        }
        public async Task<Leave> Create(Leave body)
        {
            _db.Leaves.Add(body);
            await _db.SaveChangesAsync();
            return body;
        }

        public async Task<Leave> Delete(Leave body)
        {
            _db.Leaves.Remove(body);
            await _db.SaveChangesAsync();
            return body;
        }

        public async Task<IEnumerable<Leave>> GetAll()
        {
         var leavelist= await  _db.Leaves.ToListAsync();
            return leavelist;
        }

        public async Task<Leave> GetById(int id)
        {
          var GetById = await _db.Leaves.FindAsync(id);
            return GetById;
        }

        public async Task<bool> IsSaved()
        {
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<Leave> Update(Leave body, int id)
        {
            _db.Entry(body).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return body;
        }
    }
}
