﻿using ErpBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Repository
{
  public  interface ISalaryRepo:BaseRepo<Salary>
    {
        Task<IEnumerable<Salary>> GetAll();
        Task<Salary> GetById(int id);
    }
}
