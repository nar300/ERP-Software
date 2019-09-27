using ErpBackend.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Repository
{
    public  class BaseRepoImpl <T>: BaseRepo<T> where T:class
    {
        protected readonly ErpDbContext _db;

        public BaseRepoImpl(ErpDbContext db)
        {
            _db = db;
        }
        public async Task<T> Create(T body)
        {
            _db.Add<T>(body);
          await  _db.SaveChangesAsync();
            return body;
        }

        public async Task<T> Delete(T body)
        {
            _db.Remove<T>(body);
            await _db.SaveChangesAsync();
            return body;

        }

        

        public async Task<bool> IsSaved()
        {
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<T> Update(T body, int id)
        {
            _db.Update<T>(body);
            await _db.SaveChangesAsync();
            return body;
        }
    }
}
