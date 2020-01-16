using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;

namespace Expo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FakeApiController: ControllerBase
    {
        HttpClient client ;
        public FakeApiController()
        {
            client = new HttpClient();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            
            client.BaseAddress = new Uri("https://randomuser.me");
            HttpResponseMessage responseMessage = await client.GetAsync("/api/?results=1");
            string responseString = await responseMessage.Content.ReadAsStringAsync();
            return Ok(responseString);
        }   
    }
}