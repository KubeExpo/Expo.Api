using System;
using System.Net.Http;
using System.Threading.Tasks;
using EF = Expo.Api.EF;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Bogus;
using static Bogus.DataSets.Name;

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

            string token = JObject.Parse(responseString).SelectToken("results").First.ToString();
            EF.Person person = JsonConvert.DeserializeObject<EF.Person>(token);
            // await this.context.Person.AddAsync(person);
            // await context.SaveChangesAsync();
            return Ok(person);
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
            var testUsers = new Faker<EF.Person>()
                //Optional: Call for objects that have complex initialization
                // .CustomInstantiator(f => new EF.Person(Guid.NewGuid()))

                .RuleFor(u => u.IdValue, f => f.Random.Uuid())
                //Use an enum outside scope.
                .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())


                //Basic rules using built-in generators
                // .RuleFor(u => u.NameTitle, (f, u) => f.Person.)
                .RuleFor(u => u.NameFirst, (f, u) => f.Name.FirstName(u.Gender))
                .RuleFor(u => u.NameLast, (f, u) => f.Name.LastName(u.Gender))
                .RuleFor(u => u.PictureThumbnail, f => f.Internet.Avatar())
                .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.NameFirst, u.NameLast))

                //Address
                .RuleFor(u => u.LocationStreetNumber, f => f.Address.SecondaryAddress())
                .RuleFor(u => u.LocationStreetName, f => f.Address.StreetAddress())
                .RuleFor(u => u.LocationCity, f => f.Address.City())
                .RuleFor(u => u.LocationState, f => f.Address.State())
                .RuleFor(u => u.LocationPostcode, f => f.Address.ZipCode())
                .RuleFor(u => u.LocationCountry, f => f.Address.Country())
                .RuleFor(u => u.LocationCoordinatesLatitude, f => f.Person.Address.Geo.Lat)
                .RuleFor(u => u.LocationCoordinatesLongitude, f => f.Person.Address.Geo.Lng)

                // .RuleFor(u => u.LocationCoordinatesLongitude, f => f.Date.Random.)


                // .RuleFor(u => u., f => f.Person.Address.Geo.Lat)
                // .RuleFor(u => u, f => f.Address.Latitude())


                //login 
                .RuleFor(u => u.LoginUuid, f => f.Random.Uuid())
                .RuleFor(u => u.LoginUsername, (f, u) => f.Internet.UserName(u.NameFirst, u.NameLast))
                .RuleFor(u => u.LoginPassword, f => f.Internet.Password(10))
                .RuleFor(u => u.LoginSalt, f => f.Random.Hash(20))
                .RuleFor(u => u.LoginMd5, f => f.Random.Hash(50))
                .RuleFor(u => u.LoginSha1, f => f.Random.Hash(128))
                .RuleFor(u => u.LoginSha256, f => f.Random.Hash(256))
                .RuleFor(u => u.DobDate, f => f.Date.Past(30))

                .RuleFor(u => u.RegisteredDate, f => f.Date.Past(1))
                .RuleFor(u => u.Phone, f => f.Person.Phone)
                .RuleFor(u => u.Cell, (f, u) => u.Phone)



                //Use a method outside scope.
                // .RuleFor(u => u.CartId, f => Guid.NewGuid())
                //Compound property with context, use the first/last name properties
                // .RuleFor(u => u.FullName, (f, u) => u.FirstName + " " + u.LastName)
                //And composability of a complex collection.
                // .RuleFor(u => u.Orders, f => testOrders.Generate(3).ToList())
                //Optional: After all rules are applied finish with the following action
                .FinishWith((f, u) =>
                    {
                        Console.WriteLine("User Created! Id={0}", u.IdValue);
                    });

            EF.Person person = testUsers.Generate();

            await this.context.Person.AddAsync(person);
            await context.SaveChangesAsync();
            return Ok(person);
        }
    }
}