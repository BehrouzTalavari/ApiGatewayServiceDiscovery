using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;

namespace CachedDataApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CachedPersonDataController : ControllerBase
    {


        private readonly ILogger<CachedPersonDataController> _logger;

        public CachedPersonDataController(ILogger<CachedPersonDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet] 
        public IEnumerable<PersonData> Get()
        {
            var result = new List<PersonData>();
            result.Add(new PersonData { PersonName = "Behrouz Talavari", DateRead = DateTime.Now, Id = 1 });
            result.Add(new PersonData { PersonName = "Homan Omidi", DateRead = DateTime.Now, Id = 2 });
            result.Add(new PersonData { PersonName = "Ali Abolhasani", DateRead = DateTime.Now, Id = 3 });
            result.Add(new PersonData { PersonName = "Mehrdad Sholouhi nia", DateRead = DateTime.Now, Id = 4 });
            System.Threading.Thread.Sleep(5);
            return result;
        }
    }
}
