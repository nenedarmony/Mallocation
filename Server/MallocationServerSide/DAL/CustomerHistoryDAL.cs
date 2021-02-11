
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerHistoryDAL
    {


        public static int Add(custumer_historys_tbl custumerHistorys)
        {
            using (var context = new DatabaseEntities())
            {
                context.custumer_historys_tbl.Add(custumerHistorys);
                context.SaveChanges();
                int code = 0;
                foreach (custumer_historys_tbl item in context.custumer_historys_tbl)
                {
                    code = item.CustumerHistorysID;
                }
                return code;
            }

        }
        public static List<custumer_historys_tbl> GetAll()
        {
            using (var context = new DatabaseEntities())
            {
                List<custumer_historys_tbl> listcustumer_Historys = context.custumer_historys_tbl.ToList();
                return listcustumer_Historys;
            }

        }
        public static Boolean delete(int custumerHistorysID)
        {
            using (var context = new DatabaseEntities())
            {
                try
                {
                    custumer_historys_tbl toDel = context.custumer_historys_tbl.FirstOrDefault(x => x.CustumerHistorysID == custumerHistorysID);
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
        public static bool update(custumer_historys_tbl Custumer_Historys_tbl)
        {
            using (var context = new DatabaseEntities())
            {
                try
                {
                    custumer_historys_tbl old = context.custumer_historys_tbl.FirstOrDefault(x => x.CustumerHistorysID == Custumer_Historys_tbl.CustumerHistorysID);

                    if (old != null)
                    {
                        old.IDFromShop = Custumer_Historys_tbl.IDFromShop;
                        old.IDfromUser = Custumer_Historys_tbl.IDfromUser;
                        old.NumOfTimeGoToShope = Custumer_Historys_tbl.NumOfTimeGoToShope;
                        old.NumOfTimeWasSatified = Custumer_Historys_tbl.NumOfTimeWasSatified;
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
