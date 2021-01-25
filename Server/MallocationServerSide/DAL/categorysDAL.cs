using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class categorysDAL
    {
        DatabaseEntities DB = new DatabaseEntities();
        public void Add(categorys_tbl categorys)
        {
            DB.categorys_tbl.Add(categorys);
            DB.SaveChanges();
        }
    }
}
