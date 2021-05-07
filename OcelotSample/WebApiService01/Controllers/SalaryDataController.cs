using Consul;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalaryDataController : ControllerBase
    {
        private readonly IConsulClient _consulClient;

        public SalaryDataController(IConsulClient consulClient)
        {
            this._consulClient = consulClient;
        }

        [HttpGet]
        public async Task<List<SalaryData>> Get(string id)
        {
            DateTime ReqdateTime = DateTime.Now;
            var list = new List<SalaryData>
            {
                new SalaryData{PersonId="1", Month=1,Salaty =1000 },
                new SalaryData{PersonId="2", Month=1,Salaty =1100 },
                new SalaryData{PersonId="3", Month=1,Salaty =1200 },
                new SalaryData{PersonId="4", Month=1,Salaty =1000 },
                new SalaryData{PersonId="1", Month=2,Salaty =1500},
                new SalaryData{PersonId="2", Month=2,Salaty =1000},
            };
            List<SalaryData> items = list.Where(x => x.PersonId == id).ToList();
            foreach (var item in items)
            {
                item.RequestDateTime = ReqdateTime;
            }
            return items;
        }
    }
}
