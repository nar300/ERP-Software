using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpBackend.Data;
using ErpBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Repository
{
    public class AttendanceRepoImpl :BaseRepoImpl<Attendance> , IAttendanceRepo
    {
        
        public AttendanceRepoImpl(ErpDbContext db) : base(db)
        {
            
        }
       

        public async Task<IEnumerable<Attendance>> GetAll()
        {
           var att= await _db.Attendances.ToListAsync();
            return att;
        }

        public async Task<Attendance> GetById(int id)
        {
           var Ia= await _db.Attendances.FindAsync(id);
            return Ia;
        }

     
    }
}
