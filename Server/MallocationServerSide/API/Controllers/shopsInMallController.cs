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
    [RoutePrefix("api/shopsInMall")]
    public class shopsInMallController : ApiController
    {
        // GET: api/shopsInMall
        [Route("GetAll")]
        [HttpGet]
        public List<ShopsInMallDTO> GetAll()
        {
            ShopsInMallBLL shopsInMallBLL = new ShopsInMallBLL();
            return shopsInMallBLL.GetAll();
        }

        //// GET: api/shopsInMall/5
        //[Route("Get")]
        //[HttpGet]
        //public string GetBy(int id)
        //{
        //    return "value";
        //}

        // POST: api/shopsInMall
        [Route("insertshopsInMall")]
        [HttpPost]
        public int Post(ShopsInMallDTO insertshopsInMall)
        {
            ShopsInMallBLL shopsInMallBLL = new ShopsInMallBLL();
            return shopsInMallBLL.Add(insertshopsInMall);
        }

        // PUT: api/shopsInMall/5
        [Route("updateshopsInMall")]
        [HttpPost]
        public bool Put(ShopsInMallDTO updateshopsInMall)
        {
            ShopsInMallBLL shopsInMallBLL = new ShopsInMallBLL();
            return shopsInMallBLL.update(updateshopsInMall);
        }

        // DELETE: api/shopsInMall/5
        [Route("delete/{id}")]
        [HttpPost]
        public bool delete(int id)
        {
            ShopsInMallBLL shopsInMallBLL = new ShopsInMallBLL();
            return shopsInMallBLL.delete(id);
        }

    }
}
