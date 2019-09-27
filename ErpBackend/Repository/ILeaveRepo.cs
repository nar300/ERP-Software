using ErpBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Repository
{
  public  interface ILeaveRepo:BaseRepo<Leave>
    {
        Task<IEnumerable<Leave>> GetAll();
        Task<Leave> GetById(int id);
    }
}
