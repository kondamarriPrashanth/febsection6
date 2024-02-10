using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Feb12MainPrj1.Models;

namespace Feb12MainPrj1.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext (DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Feb12MainPrj1.Models.Employee> Employee { get; set; } = default!;
    }
}
