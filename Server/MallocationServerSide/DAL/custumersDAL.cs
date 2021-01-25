using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class custumersDAL
    {
        DatabaseEntities DB = new DatabaseEntities();
        public void Add(custumers_tbl custumers)
        {
            DB.custumers_tbl.Add(custumers);
            DB.SaveChanges();
        }
    }
}
