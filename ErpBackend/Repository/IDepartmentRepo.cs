using ErpBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Repository
{
  public  interface IDepartmentRepo:BaseRepo<Department>
    {
        Task<IEnumerable<Department>> GetAll();
        Task<Department> GetById(int id);
    }
}
