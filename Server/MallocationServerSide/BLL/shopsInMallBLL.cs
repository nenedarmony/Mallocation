using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL
{
    public class ShopsInMallBLL
    {
        ShopsInMallDAL ShopsInMall_DAL = new ShopsInMallDAL();


        public void Add(shopsInMall_tbl shopsInMall)
        {
            ShopsInMall_DAL.Add(shopsInMall);
        }

        public List<shopsInMall_tbl> Get()
        {
            return ShopsInMall_DAL.Get();
        }
    }
}
