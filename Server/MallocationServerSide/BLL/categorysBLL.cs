using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL
{
    public class categorysBLL
    {
        CategorysDAL Categorys_DAL = new CategorysDAL();


        public void Add(categorys_tbl categorys)
        {
            Categorys_DAL.Add(categorys);
        }

        public List<categorys_tbl> Get()
        {
            return Categorys_DAL.Get();
        }
    }
}
