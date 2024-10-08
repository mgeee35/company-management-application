using AutoMapper;
using Business.Models.Request.Create;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Department, DepartmentResponseDto>();
            CreateMap<Employee, EmployeeResponseDto>();
            CreateMap<Role, RoleResponseDto>();
            CreateMap<EmployeeRole, EmployeeRoleResponseDto>();
            
            CreateMap<DepartmentCreateDto, Department>();
            CreateMap<EmployeeCreateDto, Employee>();
            CreateMap<RoleCreateDto, Role>();

        }
    }
}
