using Microsoft.AspNetCore.Mvc;

namespace CompanyManagementApplication.Controllers.Base
{
    public class BaseController : Controller
    {
        protected IActionResult HandleError(string message)
        {
            return BadRequest(new { Error = message });
        }
    }
}
