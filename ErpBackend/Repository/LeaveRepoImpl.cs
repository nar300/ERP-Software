using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpBackend.Data;
using ErpBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Repository
{
    public class LeaveRepoImpl : BaseRepoImpl<Leave>,ILeaveRepo
    {
        

        public LeaveRepoImpl(ErpDbContext _Db):base(_Db)
        {
           
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

       
    }
}
