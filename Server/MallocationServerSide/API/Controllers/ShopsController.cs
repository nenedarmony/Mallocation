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
    [RoutePrefix("api/Shops")]
    public class ShopsController : ApiController
    {
        // GET: api/Shops
        [Route("GetAll")]
        [HttpGet]
        public List<ShopsDTO> GetAll()
        {
            ShopsBLL shopsBLL = new ShopsBLL();
            return shopsBLL.GetAll();
        }

        //// GET: api/Shops/5
        //[Route("Get")]
        //[HttpGet]
        //public string GetBy(int id)
        //{
        //    return "value";
        //}

        // POST: api/Shops
        [Route("insertShops")]
        [HttpPost]
        public int Post(ShopsDTO insertShops)
        {
            ShopsBLL shopsBLL = new ShopsBLL();
            return shopsBLL.Add(insertShops);
        }

        // PUT: api/Shops/5
        [Route("updateShops")]
        [HttpPost]
        public bool Put(ShopsDTO updateShops)
        {
            ShopsBLL shopsBLL = new ShopsBLL();
            return shopsBLL.update(updateShops);
        }

        // DELETE: api/Shops/5
        [Route("delete/{id}")]
        [HttpPost]
        public bool delete(int id)
        {
            ShopsBLL shopsBLL = new ShopsBLL();
            return shopsBLL.delete(id);
        }
    }
}
