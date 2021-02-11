using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using DTO;
namespace API.Controllers
{
    [RoutePrefix("api/malls")]
    public class mallsController : ApiController
    {
        // GET: api/malls
        [Route("GetAll")]
        [HttpGet]
        public List<MallsDTO> GetAll()
        {
            MallsBLL mallsBLL = new MallsBLL();
            return mallsBLL.GetAll();
        }

        //// GET: api/malls/5
        //[Route("Get")]
        //[HttpGet]
        //public string GetBy(int id)
        //{
        //    return "value";
        //}

        // POST: api/malls
        [Route("insertmalls")]
        [HttpPost]
        public int Post(MallsDTO insertmalls)
        {
            MallsBLL mallsBLL = new MallsBLL();
            return mallsBLL.Add(insertmalls);
        }

        // PUT: api/malls/5
        [Route("updatemalls")]
        [HttpPost]
        public bool Put(MallsDTO updatemalls)
        {
            MallsBLL mallsBLL = new MallsBLL();
            return mallsBLL.update(updatemalls);
        }

        // DELETE: api/malls/5
        [Route("delete/{id}")]
        [HttpPost]
        public bool delete(int id)
        {
            MallsBLL mallsBLL = new MallsBLL();
            return mallsBLL.delete(id);
        }
    }
}
