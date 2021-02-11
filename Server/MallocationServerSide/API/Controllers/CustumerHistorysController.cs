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
    [RoutePrefix("api/CustumerHistorys")]
    public class CustumerHistorysController : ApiController
    {
        // GET: api/CustumerHistorys
        [Route("GetAll")]
        [HttpGet]
        public List<CostumerHistorysDTO> GetAll()
        {
            custumerHistorysBLL custumerHistorysBLL = new custumerHistorysBLL();
            return custumerHistorysBLL.GetAll();
        }

        //// GET: api/CustumerHistorys
        //[Route("Get")]
        //[HttpGet]
        //public string GetBy(int id)
        //{
        //    return "value";
        //}

        // POST: api/CustumerHistorys
        [Route("insertcostumerHistorysDTO")]
        [HttpPost]
        public int Post(CostumerHistorysDTO insertcostumerHistorysDTO)
        {
            custumerHistorysBLL custumerHistorysBLL = new custumerHistorysBLL();
            return custumerHistorysBLL.Add(insertcostumerHistorysDTO);
        }

        // PUT: api/CustumerHistorys
        [Route("updateCostumerHistorys")]
        [HttpPost]
        public bool Put(CostumerHistorysDTO updateCostumerHistorys)
        {
            custumerHistorysBLL custumerHistorysBLL = new custumerHistorysBLL();
            return custumerHistorysBLL.update(updateCostumerHistorys);
        }

        // DELETE: api/CustumerHistorys
        [Route("delete/{id}")]
        [HttpPost]
        public bool delete(int id)
        {
            custumerHistorysBLL custumerHistorysBLL = new custumerHistorysBLL();
            return custumerHistorysBLL.delete(id);
        }

    }
}
