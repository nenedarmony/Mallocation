using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL
{
    public class custumerHistorysBLL
    {
        CustumerHistorysDAL CustumerHistorys_DAL = new CustumerHistorysDAL();


        public void Add(custumer_historys_tbl custumerHistorys)
        {
            CustumerHistorys_DAL.Add(custumerHistorys);
        }

        public List<custumer_historys_tbl> Get()
        {
            return CustumerHistorys_DAL.Get();
        }
    }
}
