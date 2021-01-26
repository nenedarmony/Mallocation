using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class CategorysDAL
    {
        DatabaseEntities DB = new DatabaseEntities();
        public void Add(categorys_tbl categorys)
        {
            DB.categorys_tbl.Add(categorys);
            DB.SaveChanges();
        }
        public List<categorys_tbl> Get()
        {
            return DB.categorys_tbl.ToList();
        }

        public void Delete(categorys_tbl categorys)
        {
            DB.categorys_tbl.Remove(categorys);
            DB.SaveChanges();
        }
    }
}
