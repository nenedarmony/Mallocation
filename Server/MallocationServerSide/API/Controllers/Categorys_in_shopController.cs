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
    [RoutePrefix("api/Categorys_in_shop")]
    public class Categorys_in_shopController : ApiController
    {
        // GET: api/Categorys_in_shop
        [Route("GetAll")]
        [HttpGet]
        public List<CategorysInShopDTO> GetAll()
        {
            categorysInShopBLL categorysInShopBLL = new categorysInShopBLL();
            return categorysInShopBLL.GetAll();
        }

        // GET: api/Categorys_in_shop/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Categorys_in_shop
        [Route("insertcategorysInShop")]
        [HttpPost]
        public int Post(CategorysInShopDTO insertcategorysInShop)
        {
            categorysInShopBLL categorysInShopBLL = new categorysInShopBLL();
            return categorysInShopBLL.Add(insertcategorysInShop);
        }

        // POST: api/Categorys_in_shop
        [Route("updateCategorysInShop")]
        [HttpPost]
        public bool Put(CategorysInShopDTO updateCategorysInShop)
        {
            categorysInShopBLL categorysInShopBLL = new categorysInShopBLL();
            return categorysInShopBLL.update(updateCategorysInShop);
        }

        // POST: api/Categorys_in_shop
        [Route("delete/{id}")]
        [HttpPost]
        public bool delete(int id)
        {
            categorysInShopBLL categorysInShopBLL = new categorysInShopBLL();
            return categorysInShopBLL.delete(id);
        }
    }
}
