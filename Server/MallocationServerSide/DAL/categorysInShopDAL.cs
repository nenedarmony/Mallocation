using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class CategorysInShopDAL
    {

        DatabaseEntities DB = new DatabaseEntities();
        public void Add(categorys_in_shop categorysInShop)
        {
            DB.categorys_in_shop.Add(categorysInShop);
            DB.SaveChanges();
        }
        public List<categorys_in_shop> Get()
        {
            return DB.categorys_in_shop.ToList();
        }

        public void Delete(categorys_in_shop categorysInShop)
        {
            DB.categorys_in_shop.Remove(categorysInShop);
            DB.SaveChanges();
        }
    }
}
