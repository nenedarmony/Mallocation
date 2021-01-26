using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL
{
    public class CustumersBLL
    {
     CustumersDAL  Custumers_DAL = new CustumersDAL();


        public void Add(custumers_tbl custumers)
        {
            Custumers_DAL.Add(custumers);
        }

        public List<custumers_tbl> Get()
        {
            return Custumers_DAL.Get();
        }
    }
}
