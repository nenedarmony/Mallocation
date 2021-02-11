using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class CustomerDAL
    {


        public static int Add(custumers_tbl custumers)
        {
            using (var context = new DatabaseEntities())
            {
                context.custumers_tbl.Add(custumers);
                context.SaveChanges();
                int code = 0;
                foreach (custumers_tbl item in context.custumers_tbl)
                {
                    code = item.CustumerID;
                }
                return code;
            }

        }
        public static List<custumers_tbl> GetAll()
        {
            using (var context = new DatabaseEntities())
            {
                List<custumers_tbl> listCustumers = context.custumers_tbl.ToList();
                return listCustumers;
            }

        }
        public static Boolean delete(int CustumerID)
        {
            using (var context = new DatabaseEntities())
            {
                try
                {
                    custumers_tbl toDel = context.custumers_tbl.FirstOrDefault(x => x.CustumerID == CustumerID);
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
        public static bool update(custumers_tbl Custumers)
        {
            using (var context = new DatabaseEntities())
            {
                try
                {
                    custumers_tbl old = context.custumers_tbl.FirstOrDefault(x => x.CustumerID == Custumers.CustumerID);

                    if (old != null)
                    {
                        old.CustumerName = Custumers.CustumerName;
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
