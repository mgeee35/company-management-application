using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Services
{
    public class EmployeeRoleService : BaseService<EmployeeRoleResponseDto, EmployeeRole>, IEmployeeRoleService
    {
        public EmployeeRoleService(IUnitOfWork unitOfWork) : base(unitOfWork) { }
        
    }
}
