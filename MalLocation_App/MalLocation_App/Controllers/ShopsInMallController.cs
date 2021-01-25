using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MalLocation_App.Controllers
{
    public class ShopsInMallController : ApiController
    {
        // GET: api/ShopsInMall
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ShopsInMall/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ShopsInMall
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ShopsInMall/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ShopsInMall/5
        public void Delete(int id)
        {
        }
    }
}
