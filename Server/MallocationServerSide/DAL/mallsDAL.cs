using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class mallsDAL
    {
        DatabaseEntities DB = new DatabaseEntities();
        public void Add( malls_tbl malls)
        {
            DB.malls_tbl.Add(malls);
            DB.SaveChanges();
        }
    }
}
