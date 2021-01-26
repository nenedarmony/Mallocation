using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL
{
    class MallsBLL
    {


        MallsDAL Malls_DAL = new MallsDAL();


        public void Add(malls_tbl malls)
        {
            Malls_DAL.Add(malls);
        }

        public List<malls_tbl> Get()
        {
            return Malls_DAL.Get();
        }
    }
}
