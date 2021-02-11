using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BLL;
namespace API.Controllers
{
    [RoutePrefix("api/Custumers")]
    public class CustumersController : ApiController
    {
        // GET: api/Custumers
        [Route("GetAll")]
        [HttpGet]
        public List<CustomerDTO> GetAll()
        {
            CustumersBLL custumersBLL = new CustumersBLL();
            return custumersBLL.GetAll();
        }

        //// GET: api/Custumers
        //[Route("Get")]
        //[HttpGet]
        //public string GetBy(int id)
        //{
        //    return "value";
        //}

        // POST: api/Custumers
        [Route("insertCustumers")]
        [HttpPost]
        public int Post(CustomerDTO insertCustumers)
        {
            CustumersBLL custumersBLL = new CustumersBLL();
            return custumersBLL.Add(insertCustumers);
        }

        // PUT: api/Custumers/5
        [Route("updateCustumers")]
        [HttpPost]
        public bool Put(CustomerDTO updateCustumers)
        {
            CustumersBLL custumersBLL = new CustumersBLL();
            return custumersBLL.update(updateCustumers);
        }

        // DELETE: api/Custumers/5
        [Route("delete/{id}")]
        [HttpPost]
        public bool delete(int id)
        {
            CustumersBLL custumersBLL = new CustumersBLL();
            return custumersBLL.delete(id);
        }
    }
}
