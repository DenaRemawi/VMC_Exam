using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HR.Data
{
    public class HRContext : DbContext
    {
        IConfiguration iconfiguration;
        public HRContext(IConfiguration configuration)
        {
            iconfiguration = configuration;
        }
        public DbSet<CDepartment> Dep { set; get; }

        public DbSet<CEmployee> Emp { set; get; }

        public DbSet<Country> count { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" data source = localhost; initial catalog= HRSystem; integrated security=true ");
            base.OnConfiguring(optionsBuilder);
        }

    }
}


