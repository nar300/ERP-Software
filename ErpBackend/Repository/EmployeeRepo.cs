using ErpBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Repository
{
   public interface EmployeeRepo:BaseRepo<Employee>
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> GetById(int id);
    }
}
