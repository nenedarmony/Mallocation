using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MalLocation_App.Controllers
{
    public class CategorysInShopeController : ApiController
    {
        // GET: api/CategorysInShope
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CategorysInShope/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CategorysInShope
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CategorysInShope/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CategorysInShope/5
        public void Delete(int id)
        {
        }
    }
}
