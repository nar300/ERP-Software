using ErpBackend.Data;
using ErpBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Repository
{
    public class DesignationRepoImpl:BaseRepoImpl<Designation>,IDesignationRepo
    {
        public DesignationRepoImpl(ErpDbContext db):base(db)
        {
            
        }

        public async Task<IEnumerable<Designation>> GetAll()
        {
           var list= await _db.Designations.ToListAsync();
            return list;
        }

        public async Task<Designation> GetById(int id)
        {
            var getbyid = await _db.Designations.FirstOrDefaultAsync(des=>des.Id == id);
            return getbyid;
        }
    }
}
