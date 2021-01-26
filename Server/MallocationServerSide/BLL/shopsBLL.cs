using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL
{
    public class ShopsBLL
    {
        ShopsDAL Shops_DAL = new ShopsDAL();


        public void Add(shops_tbl shops)
        {
            Shops_DAL.Add(shops);
        }

        public List<shops_tbl> Get()
        {
            return Shops_DAL.Get();
        }
    }
}
