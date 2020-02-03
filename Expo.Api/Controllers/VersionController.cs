namespace Expo.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    //using Expo.Api.Models;
    
    namespace Expo.Api.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class VersionController : ControllerBase
        {
            public VersionController()
            {
            }
    
            // GET api/version
            [HttpGet("")]
            public ActionResult<IEnumerable<string>> Getstrings()
            {
                return Ok("Current Version : v0.0.3");
            }
    
            // GET api/version/5
            [HttpGet("{id}")]
            public ActionResult<string> GetstringById(int id)
            {
                return null;
            }
    
            // POST api/version
            [HttpPost("")]
            public void Poststring(string value)
            {
            }
    
            // PUT api/version/5
            [HttpPut("{id}")]
            public void Putstring(int id, string value)
            {
            }
    
            // DELETE api/version/5
            [HttpDelete("{id}")]
            public void DeletestringById(int id)
            {
            }
        }
    }
}