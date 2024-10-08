using Microsoft.AspNetCore.Mvc;
using Business.Services.Interface;
using Business.Models.Response;
using CompanyManagementApplication.Controllers.Base;

namespace CompanyManagementApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeRoleController : BaseCrudController<EmployeeRoleResponseDto, IEmployeeRoleService>
    {
        public EmployeeRoleController(IEmployeeRoleService service) : base(service) { }
    }
}
