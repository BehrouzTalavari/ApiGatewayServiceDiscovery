using ContractApiV2.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;

namespace ContractApiV2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles ="role1")]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<IEnumerable<Contact>> Get()
        {
            var result = new List<Contact>()
            {
            new Contact{ ContactId=1,FirstName="Behrouz",LastName="Talavari",OwnerId=new Guid("b13e59d8-c699-49cb-af28-bc149d8cb481")},
            new Contact{ ContactId=2,FirstName="Mohsen",LastName="Sarebani",OwnerId=new Guid("2a38d154-6a52-4792-8680-da48ec1fbfa5")},
            new Contact{ ContactId=3,FirstName="Ali",LastName="Shahjavan",OwnerId=new Guid("28c31688-786c-4c2d-8eff-d0753aa2d696")},
            };
            return result;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
