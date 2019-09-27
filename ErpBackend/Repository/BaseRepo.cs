using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Repository
{
    public interface BaseRepo <T> where T:class
    {
        
        Task<T> Create(T body);
       
        Task<T> Delete(T body);
        Task<T> Update(T body, int id);
        Task<bool> IsSaved();

    }
}
