using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    class shopsDAL
    {
        DatabaseEntities DB = new DatabaseEntities();
        public void Add(shops_tbl shops)
        {
            DB.shops_tbl.Add(shops);
            DB.SaveChanges();
        }
    }
}
