using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class ShopsInMallDAL
    {


        public static int Add(shopsInMall_tbl shopsInMall)
        {
            using (var context = new DatabaseEntities())
            {
                context.shopsInMall_tbl.Add(shopsInMall);
                context.SaveChanges();
                int code = 0;
                foreach (shopsInMall_tbl item in context.shopsInMall_tbl)
                {
                    code = item.shopInMallID;
                }
                return code;
            }

        }
        public static List<shopsInMall_tbl> GetAll()
        {
            using (var context = new DatabaseEntities())
            {
                List<shopsInMall_tbl> listShopsInMal = context.shopsInMall_tbl.ToList();
                return listShopsInMal;
            }

        }
        public static Boolean delete(int shopInMallID)
        {
            using (var context = new DatabaseEntities())
            {
                try
                {
                    shopsInMall_tbl toDel = context.shopsInMall_tbl.FirstOrDefault(x => x.shopInMallID == shopInMallID);
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
        public static bool update(shopsInMall_tbl shopsInMall1)
        {
            using (var context = new DatabaseEntities())
            {
                try
                {
                    shopsInMall_tbl old = context.shopsInMall_tbl.FirstOrDefault(x => x.shopInMallID == shopsInMall1.shopInMallID);

                    if (old != null)
                    {
                        old.IdFromShop = shopsInMall1.IdFromShop;
                        old.IdFromMall = shopsInMall1.IdFromMall;

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
