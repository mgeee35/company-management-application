using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.EntityFramework.Configurations;

namespace Infrastructure.Data.Postgres.EntityFramework
{
    public class PostgresContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public PostgresContext(DbContextOptions<PostgresContext> options, IConfiguration configuration ) : base( options )
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeRoleConfiguration());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (_configuration["EnviromentAlias"] == "DEV")
            {
                optionsBuilder.LogTo(Console.Write);
            }
        }

        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<EmployeeRole> EmployeeRoles => Set<EmployeeRole>();
    }
}
