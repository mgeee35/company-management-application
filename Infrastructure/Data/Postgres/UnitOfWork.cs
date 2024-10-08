using Infrastructure.Data.Postgres.Repositories;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Postgres
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public UnitOfWork(DbContext context)
        {
            _context = context;
            Departments = new DepartmentRepository(_context);
            Employees = new EmployeeRepository(_context);
            EmployeeRoles = new EmployeeRoleRepository(_context);
            Roles = new RoleRepository(_context);
        }

        public IDepartmentRepository Departments { get; private set; }
        public IEmployeeRepository Employees { get; private set; }
        public IEmployeeRoleRepository EmployeeRoles { get; private set; }
        public IRoleRepository Roles { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
