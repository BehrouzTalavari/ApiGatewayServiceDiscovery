using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonDataController : ControllerBase
    {

        private readonly ILogger<PersonDataController> _logger;

        public PersonDataController(ILogger<PersonDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<PersonData> Get(string id)
        {
            DateTime ReqdateTime = DateTime.Now;
            var list = new List<PersonData>
            {
                new PersonData{Id="1",FirstName="Behrouz",LastName="Talavari",BirthDate=new DateTime(1988,7,22) },
                new PersonData{Id="2",FirstName="Mehrdad",LastName="Shokouhi Nia",BirthDate=new DateTime(1988,10,22) },
                new PersonData{Id="3",FirstName="Iman",LastName="Solouki",BirthDate=new DateTime(1987,7,22) },
                new PersonData{Id="4",FirstName="Sasan",LastName="Ghafory Fard",BirthDate=new DateTime(1989,7,22) },
            };
            var item = list.FirstOrDefault(x => x.Id == id);
            item.RequestDateTime = ReqdateTime;
            return item;
        }
    }
}
