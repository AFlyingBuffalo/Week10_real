using Microsoft.AspNetCore.Mvc;
namespace Week10_real.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Name : ControllerBase
    {
        [HttpGet(Name = "GetMyName")]
        public IActionResult GetMyName()
        {
            var myName = new { Name = "Nick Bernloehr v2" };
            return Ok(myName);
        }
    }
}
