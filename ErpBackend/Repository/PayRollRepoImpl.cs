using ErpBackend.Data;
using ErpBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Repository
{
    public class PayRollRepoImpl :BaseRepoImpl<PayRoll>,IPayRollRepo
    {
        public PayRollRepoImpl(ErpDbContext db) : base(db)
        {

        }

        public async Task<IEnumerable<PayRoll>> GetAll()
        {
            var list = await _db.PayRolls.ToListAsync();
            return list;
        }

        public async Task<PayRoll> GetById(int id)
        {
            var getbyid = await _db.PayRolls.FirstOrDefaultAsync(e => e.Id == id);
            return getbyid;
        }
    }
}
