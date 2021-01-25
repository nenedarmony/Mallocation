using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class custumerHistorysDAL
    {
        DatabaseEntities DB = new DatabaseEntities();
        public void Add(custumer_historys_tbl custumerHistorys)
        {
            DB.custumer_historys_tbl.Add(custumerHistorys);
            DB.SaveChanges();
        }
    }
}
