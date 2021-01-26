using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class CustumersDAL
    {
        DatabaseEntities DB = new DatabaseEntities();
        public void Add(custumers_tbl custumers)
        {
            DB.custumers_tbl.Add(custumers);
            DB.SaveChanges();
        }


        public List<custumers_tbl> Get()
        {
            return DB.custumers_tbl.ToList();
        }

        public void Delete(custumers_tbl custumers)
        {
            DB.custumers_tbl.Remove(custumers);
            DB.SaveChanges();
        }
    }
}
