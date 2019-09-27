using ErpBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Repository
{
  public interface IDesignationRepo:BaseRepo<Designation>
    {
        Task<IEnumerable<Designation>> GetAll();
        Task<Designation> GetById(int id);
    }
}
