using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Services
{
    public class RoleService : BaseService<RoleResponseDto, Role>, IRoleService
    {
        public RoleService(IUnitOfWork unitOfWork) : base(unitOfWork) { }
        
    }
}
