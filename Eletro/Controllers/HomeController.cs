using Microsoft.AspNetCore.Mvc;

namespace Eletro.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "API is working!" });
        }
    }
}
