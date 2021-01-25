using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MalLocation_App.Controllers
{
    public class MallsController : ApiController
    {
        // GET: api/Malls
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Malls/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Malls
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Malls/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Malls/5
        public void Delete(int id)
        {
        }
    }
}
