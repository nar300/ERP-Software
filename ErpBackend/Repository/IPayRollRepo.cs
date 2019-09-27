using ErpBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Repository
{
   public interface IPayRollRepo :BaseRepo<PayRoll> 
    {
        Task<IEnumerable<PayRoll>> GetAll();
        Task<PayRoll> GetById(int id);
    }
}
