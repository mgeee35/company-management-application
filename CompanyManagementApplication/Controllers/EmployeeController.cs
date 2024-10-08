using Microsoft.AspNetCore.Mvc;
using Business.Services.Interface;
using Business.Models.Response;
using CompanyManagementApplication.Controllers.Base;

namespace CompanyManagementApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : BaseCrudController<EmployeeResponseDto, IEmployeeService>
    {
        public EmployeeController(IEmployeeService service) : base(service) { }
    }
}
