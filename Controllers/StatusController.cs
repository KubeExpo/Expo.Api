using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GCloud.GraphQL.Controllers
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
