using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dyball.ViewModels;

namespace Dyball.Api
{
    [Produces("application/json")]
    [Route("api/SampleData")]
    public class SampleDataController : Controller
    {
        // GET: api/SampleData
        [HttpGet]
        public TestData Get()
        {
            var testData = new TestData
            {
                Username = "BillBloggs",
                EmailAddress = "bill.bloggs@example.com",
                Password = "P@55word",
                Currency = 123.45M
            };

            return testData;
        }

        // GET: api/SampleData/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/SampleData
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/SampleData/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
