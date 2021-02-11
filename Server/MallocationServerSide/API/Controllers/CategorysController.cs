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
    [RoutePrefix("api/Categorys")]
    public class CategorysController : ApiController
    {
        // GET: api/Categorys
        [Route("GetAll")]
        [HttpGet]
        public List<CategoryDTO> GetAll()
        {
            categorysBLL categorysBLL = new categorysBLL();
            return categorysBLL.GetAll();
        }

        //// api/Categorys
        //[Route("Get")]
        //[HttpGet]
        //public string GetBy(int id)
        //{
        //    return "value";
        //}

        // POST: api/Categorys
        [Route("insertaudiences")]
        [HttpPost]
        public int Post(CategoryDTO categoryDTO)
        {
            categorysBLL categorysBLL = new categorysBLL();
            return categorysBLL.Add(categoryDTO);
        }

        // PUT: api/Categorys
        [Route("updateaudiences")]
        [HttpPost]
        public bool Put(CategoryDTO categoryDTO)
        {
            categorysBLL categorysBLL = new categorysBLL();
            return categorysBLL.update(categoryDTO);
        }

        // DELETE: api/Categorys
        [Route("delete/{id}")]
        [HttpPost]
        public bool delete(int id)
        {
            categorysBLL categorysBLL = new categorysBLL();
            return categorysBLL.delete(id);
        }
    }
}
