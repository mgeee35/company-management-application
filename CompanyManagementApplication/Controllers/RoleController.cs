using Microsoft.AspNetCore.Mvc;
using Business.Services.Interface;
using Business.Models.Response;
using CompanyManagementApplication.Controllers.Base;

namespace CompanyManagementApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : BaseCrudController<RoleResponseDto, IRoleService>
    {
        public RoleController(IRoleService service) : base(service) { }
    }
}
