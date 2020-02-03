using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Expo.Api.Messaging;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Expo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private readonly ILogger<TrackController> logger;
        private readonly ExpoEntityContext context;

        public TrackController(ILogger<TrackController> logger,
        ExpoEntityContext context)
        {
            this.logger = logger;
            this.context = context;
        }

        // GET api/track
        [HttpGet("")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new List<string> { };
        }

        // GET api/track/5
        [HttpGet("{id}")]
        public ActionResult<string> GetstringById(int id)
        {
            return null;
        }

        // POST api/track
        [HttpPost("")]
        public async Task<IActionResult> Post(string message)
        {
            // logger.LogInformation(message);
            // TopicHelper helper = new TopicHelper();
            // Console.WriteLine("Hello");
            // helper.SendMessage(message);
            Test test = new Test
            {
                FirstName = "Joy",
                LastName = "Roy",
                BirthDate = DateTime.Parse("1985/11/26")
            };
            context.Add(test);
            await context.SaveChangesAsync();
            return Ok(test);
        }

        // PUT api/track/5
        [HttpPut("{id}")]
        public void Put(int id, string value)
        {
        }

        // DELETE api/track/5
        [HttpDelete("{id}")]
        public void DeletestringById(int id)
        {
        }
    }
}