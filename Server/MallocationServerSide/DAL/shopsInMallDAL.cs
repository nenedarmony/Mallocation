using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    class shopsInMallDAL
    {
        DatabaseEntities DB = new DatabaseEntities();
        public void Add(shopsInMall_tbl shopsInMall)
        {
            DB.shopsInMall_tbl.Add(shopsInMall);
            DB.SaveChanges();
        }
    }
}
