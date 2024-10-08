using Microsoft.AspNetCore.Mvc;
using Business.Services.Interface;
using Business.Models.Response;
using CompanyManagementApplication.Controllers.Base;

namespace CompanyManagementApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : BaseCrudController<DepartmentResponseDto, IDepartmentService>
    {
        public DepartmentController(IDepartmentService service) : base(service) { }
    }
}
