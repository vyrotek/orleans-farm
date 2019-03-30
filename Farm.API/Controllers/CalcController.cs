using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Farm.Core;
using Microsoft.AspNetCore.Mvc;
using Orleans;

namespace Farm.API.Controllers
{
    [Route("api/[controller]")]
    public class CalcController : Controller
    {
        private IClusterClient client;
        
        public CalcController(IClusterClient client)
        {
            this.client = client;
        }

        // GET api/calc/5
        [HttpGet("{id}")]
        public async Task<int> Get(Guid id)
        {
            var grain = this.client.GetGrain<ICalcGrain>(id);
            return await grain.GetCount();
        }

        // PUT api/calc/5
        [HttpPost("{id}")]
        public async Task Post(Guid id, [FromBody]int input)
        {
            var grain = this.client.GetGrain<ICalcGrain>(id);
            await grain.CalcValue(input);
        }
    }
}
