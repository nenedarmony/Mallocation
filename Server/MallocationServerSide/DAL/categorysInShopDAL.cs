using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategorysInShopDAL
    {


        public static int Add(categorys_in_shop CategorysInShop )
        {
            using (var context = new DatabaseEntities())
            {
                context.categorys_in_shop.Add(CategorysInShop);
                context.SaveChanges();
                int code = 0;
                foreach (categorys_in_shop item in context.categorys_in_shop)
                {
                    code = item.categoryInShopID;
                }
                return code;
            }

        }
        public static List<categorys_in_shop> GetAll()
        {
            using (var context = new DatabaseEntities())
            {
                List<categorys_in_shop> listCategorysInShop = context.categorys_in_shop.ToList();
                return listCategorysInShop;
            }

        }
        public static Boolean delete(int categoryInShopID)
        {
            using (var context = new DatabaseEntities())
            {
                try
                {
                    categorys_in_shop toDel = context.categorys_in_shop.FirstOrDefault(x => x.categoryInShopID == categoryInShopID);
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
        public static bool update(categorys_in_shop categorys)
        {
            using (var context = new DatabaseEntities())
            {
                try
                {
                    categorys_in_shop old = context.categorys_in_shop.FirstOrDefault(x => x.categoryInShopID == categorys.categoryInShopID);

                    if (old != null)
                    {
                        old.IdFromCategory = categorys.IdFromCategory;
                        old.IdFromShop = categorys.IdFromShop;
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
