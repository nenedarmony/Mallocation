using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class categorysInShopDAL
    {

        DatabaseEntities DB = new DatabaseEntities();
        public void Add(categorys_in_shop categorysInShop)
        {
            DB.categorys_in_shop.Add(categorysInShop);
            DB.SaveChanges();
        }
    }
}
