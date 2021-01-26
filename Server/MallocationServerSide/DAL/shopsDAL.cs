using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class ShopsDAL
    {
        DatabaseEntities DB = new DatabaseEntities();
        public void Add(shops_tbl shops)
        {
            DB.shops_tbl.Add(shops);
            DB.SaveChanges();
        }
        public List<shops_tbl> Get()
        {
            return DB.shops_tbl.ToList();
        }

        public void Delete(shops_tbl shops)
        {
            DB.shops_tbl.Remove(shops);
            DB.SaveChanges();
        }
    }
}
