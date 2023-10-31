using Microsoft.AspNetCore.Mvc;

namespace Week10_real.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

  /*      [HttpGet(Name = "GetMyName")]
        public IActionResult GetMyName()
        {
            var myName = new { Name = "Nick Bernloehr v2" };
            return Ok(myName);
        }*/
    }
}