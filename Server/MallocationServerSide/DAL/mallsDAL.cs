using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class MallsDAL
    {
        DatabaseEntities DB = new DatabaseEntities();
        public void Add( malls_tbl malls)
        {
            DB.malls_tbl.Add(malls);
            DB.SaveChanges();
        }
        public List<malls_tbl> Get()
        {
            return DB.malls_tbl.ToList();
        }


        public void Delete(malls_tbl malls)
        {
            DB.malls_tbl.Remove(malls);
            DB.SaveChanges();
        }
    }
}
