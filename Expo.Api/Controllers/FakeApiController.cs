using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Expo.Api.Mock;

namespace Expo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FakeApiController : ControllerBase
    {
        HttpClient client;
        private readonly EF.ExpoDBContext context;
        public FakeApiController(EF.ExpoDBContext context)
        {
            this.context = context;
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

        [HttpGet("company/employee")]
        public async Task<IActionResult> GetEmployee()
        {
            client.BaseAddress = new Uri("http://dummy.restapiexample.com");
            HttpResponseMessage responseMessage = await client.GetAsync("/api/v1/employees");
            string responseString = await responseMessage.Content.ReadAsStringAsync();
            return Ok(responseString);
        }

        [HttpGet("company/dxc")]
        public async Task<IActionResult> GetDXCEmployee()
        {
            EF.Person person = PersonMock.People();
            await this.context.Person.AddAsync(person);
            await context.SaveChangesAsync();
            return Ok(person);
        }
    }
}