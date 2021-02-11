
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class ShopsDAL
    {


        public static int Add(shops_tbl shops)
        {
            using (var context = new DatabaseEntities())
            {
                context.shops_tbl.Add(shops);
                context.SaveChanges();
                int code = 0;
                foreach (shops_tbl item in context.shops_tbl)
                {
                    code = item.ShopID;
                }
                return code;
            }

        }
        public static List<shops_tbl> GetAll()
        {
            using (var context = new DatabaseEntities())
            {
                List<shops_tbl> listShops = context.shops_tbl.ToList();
                return listShops;
            }

        }
        public static Boolean delete(int shopID)
        {
            using (var context = new DatabaseEntities())
            {
                try
                {
                    shops_tbl toDel = context.shops_tbl.FirstOrDefault(x => x.ShopID == shopID);
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
        public static bool update(shops_tbl shops1)
        {
            using (var context = new DatabaseEntities())
            {
                try
                {
                    shops_tbl old = context.shops_tbl.FirstOrDefault(x => x.ShopID == shops1.ShopID);

                    if (old != null)
                    {
                        old.ShopName = shops1.ShopName;
                        old.IdFromAudience = shops1.IdFromAudience;

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
