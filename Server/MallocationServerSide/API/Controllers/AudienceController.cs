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
    [RoutePrefix("api/Audience")]
    public class AudienceController : ApiController
    {
        // GET: api/Audience
        [Route("GetAll")]
        [HttpGet]
        public List<AudiencesDTO> GetAll()
        {
            audiencesBLL audiencesBLL = new audiencesBLL();
            return audiencesBLL.GetAll();
        }

        //// GET: api/Audience/5
        //[Route("Get")]
        //[HttpGet]
        //public string GetBy(int id)
        //{
        //    return "value";
        //}

        // POST: api/Audience
        [Route("insertaudiences")]
        [HttpPost]
        public int Post(AudiencesDTO insertaudiences)
        {
            audiencesBLL audiencesBLL = new audiencesBLL();
            return audiencesBLL.Add(insertaudiences);
        }

        // PUT: api/Audience/5
        [Route("updateaudiences")]
        [HttpPost]
        public bool Put(AudiencesDTO updateaudiences)
        {
            audiencesBLL audiencesBLL = new audiencesBLL();
            return audiencesBLL.update(updateaudiences);
        }

        // DELETE: api/Audience/5
        [Route("delete/{id}")]
        [HttpPost]
        public bool delete(int id)
        {
            audiencesBLL audiencesBLL = new audiencesBLL();
            return audiencesBLL.Delete(id);
        }
    }
}
