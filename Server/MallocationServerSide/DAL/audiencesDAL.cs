using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class audiencesDAL
    {
        DatabaseEntities DB = new DatabaseEntities();
        public void Add(audiences_tbl audiences)
        {
            DB.audiences_tbl.Add(audiences);
            DB.SaveChanges();
        }
        public List<audiences_tbl> Get()
        {
            return DB.audiences_tbl.ToList();
        }

        public void Delete(audiences_tbl audiences)
        {
            DB.audiences_tbl.Remove(audiences);
            DB.SaveChanges();
        }
    }
}
