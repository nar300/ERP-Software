﻿using ErpBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Repository
{
  public  interface IAttendanceRepo:BaseRepo<Attendance>
    {
        Task<IEnumerable<Attendance>> GetAll();
        Task<Attendance> GetById(int id);
    }
}
