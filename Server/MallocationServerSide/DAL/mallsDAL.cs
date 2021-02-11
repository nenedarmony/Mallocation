using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class MallsDAL
    {


        public static int Add(malls_tbl malls)
        {
            using (var context = new DatabaseEntities())
            {
                context.malls_tbl.Add(malls);
                context.SaveChanges();
                int code = 0;
                foreach (malls_tbl item in context.malls_tbl)
                {
                    code = item.MallID;
                }
                return code;
            }

        }
        public static List<malls_tbl> GetAll()
        {
            using (var context = new DatabaseEntities())
            {
                List<malls_tbl> listmalls = context.malls_tbl.ToList();
                return listmalls;
            }

        }
        public static Boolean delete(int mallsID)
        {
            using (var context = new DatabaseEntities())
            {
                try
                {
                    malls_tbl toDel = context.malls_tbl.FirstOrDefault(x => x.MallID == mallsID);
                    if (toDel != null)
                    {
                        context.Entry(toDel).State = System.Data.Entity.EntityState.Deleted;
                        context.SaveChanges();
                    }
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }

            }
        }
        public static bool update(malls_tbl malls)
        {
            using (var context = new DatabaseEntities())
            {
                try
                {
                    malls_tbl old = context.malls_tbl.FirstOrDefault(x => x.MallID == malls.MallID);

                    if (old != null)
                    {
                        old.MallName = malls.MallName;
                        old.CurentLat = malls.CurentLat;
                        old.CurentLang = malls.CurentLang;

                        context.SaveChanges();
                    }
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }

            }
        }
    }
}
