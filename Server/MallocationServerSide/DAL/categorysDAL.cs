using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategorysDAL
    {
        
      
        public static int Add(categorys_tbl categorys)
        {
            using (var context = new DatabaseEntities())
            {
                context.categorys_tbl.Add(categorys);
                context.SaveChanges();
                int code = 0;
                foreach (categorys_tbl item in context.categorys_tbl)
                {
                    code = item.CategoryID;
                }
                return code;
            }
          
        }
        public static List<categorys_tbl> GetAll()
        {
            using (var context = new DatabaseEntities())
            {
                List<categorys_tbl> listCategorys = context.categorys_tbl.ToList();
                return listCategorys;
            }
          
        }
        public static Boolean delete(int categoryID)
        {
            using (var context = new DatabaseEntities())
            {
                try
                {
                    categorys_tbl toDel = context.categorys_tbl.FirstOrDefault(x => x.CategoryID == categoryID);
                    if(toDel!= null)
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
        public static bool update(categorys_tbl categorys)
        {
            using (var context = new DatabaseEntities())
            {
                try
                {
                    categorys_tbl old = context.categorys_tbl.FirstOrDefault(x => x.CategoryID == categorys.CategoryID);

                    if (old != null)
                    {
                        old.Category=categorys.Category;
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
