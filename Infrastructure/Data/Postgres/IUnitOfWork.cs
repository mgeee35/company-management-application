using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres
{
    public interface IUnitOfWork : IDisposable
    {
        IDepartmentRepository Departments { get; }
        IEmployeeRepository Employees { get; }
        IEmployeeRoleRepository EmployeeRoles { get; }
        IRoleRepository Roles { get; }
        
        Task<int> CompleteAsync();
    }
}
