﻿using ErpBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpBackend.Data
{
    public class ErpDbContext:DbContext
    {
        public ErpDbContext(DbContextOptions<ErpDbContext> options) : base(options) { } 
            
      
        public DbSet<Employee> Employees { get; set; }
    }
}
