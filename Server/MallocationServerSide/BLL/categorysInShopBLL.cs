using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL
{
  public  class categorysInShopBLL
    {
        CategorysInShopDAL CategorysInShop_DAL = new CategorysInShopDAL();


        public void Add(categorys_in_shop categorysInShop)
        {
            CategorysInShop_DAL.Add(categorysInShop);
        }

        public List<categorys_in_shop> Get()
        {
            return CategorysInShop_DAL.Get();
        }
    }
}
