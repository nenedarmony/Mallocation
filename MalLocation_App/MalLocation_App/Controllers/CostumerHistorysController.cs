using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MalLocation_App.Controllers
{
    public class CostumerHistorysController : ApiController
    {
        // GET: api/CostumerHistorys
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CostumerHistorys/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CostumerHistorys
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CostumerHistorys/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CostumerHistorys/5
        public void Delete(int id)
        {
        }
    }
}
