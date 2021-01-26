using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class CustumerHistorysDAL
    {
        DatabaseEntities DB = new DatabaseEntities();

        public void Add(custumer_historys_tbl custumerHistorys)
        {
            DB.custumer_historys_tbl.Add(custumerHistorys);
            DB.SaveChanges();
        }

        public List<custumer_historys_tbl> Get()
        {
            return DB.custumer_historys_tbl.ToList();
        }

        public void Delete(custumer_historys_tbl custumerHistorys)
        {
            DB.custumer_historys_tbl.Remove(custumerHistorys);
            DB.SaveChanges();
        }
    }
}
