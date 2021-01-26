using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class ShopsInMallDAL
    {
        DatabaseEntities DB = new DatabaseEntities();
        public void Add(shopsInMall_tbl shopsInMall)
        {
            DB.shopsInMall_tbl.Add(shopsInMall);
            DB.SaveChanges();
        }
        public List<shopsInMall_tbl> Get()
        {
            return DB.shopsInMall_tbl.ToList();
        }
        public void Delete(shopsInMall_tbl shopsInMall)
        {
            DB.shopsInMall_tbl.Remove(shopsInMall);
            DB.SaveChanges();
        }
    }
}
