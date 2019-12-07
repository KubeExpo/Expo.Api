using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Expo.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public StatusController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("healthz")]
        public IActionResult Get()
        {
           return Ok();
        }
    }
}
