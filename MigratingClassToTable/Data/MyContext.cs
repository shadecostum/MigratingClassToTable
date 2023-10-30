using Microsoft.EntityFrameworkCore;
using MigratingClassToTable.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratingClassToTable.Data
{
    internal class MyContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<WorkStation> WorkStation { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<Project> Projects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.AppSettings["ConnectionString"]);
        }
    }
}
