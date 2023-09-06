using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Data
{
    public class EMSContext : DbContext
    {
        public EMSContext (DbContextOptions<EMSContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeManagementSystem.Models.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<EmployeeManagementSystem.Models.EmpProfile>? EmpProfile { get; set; }
    }
}
