using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpBackend.Data;
using ErpBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ErpBackend.Repository
{
    public class AttendanceRepoImpl : IAttendanceRepo
    {
        private readonly ErpDbContext _db;
        public AttendanceRepoImpl(ErpDbContext db)
        {
            _db = db;
        }
        public async Task<Attendance> Create(Attendance body)
        {
           _db.Attendances.Add(body);
           await _db.SaveChangesAsync();
            return body;
        }

        public async Task<Attendance> Delete(Attendance body)
        {
            _db.Attendances.Remove(body);
           await _db.SaveChangesAsync();
            return body;
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

        public async Task<bool> IsSaved()
        {
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<Attendance> Update(Attendance body, int id)
        {
            _db.Entry(body).State = EntityState.Modified;
           await _db.SaveChangesAsync();
            return body;
        }
    }
}
