using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL
{
    public class audiencesBLL
    {
        AudiencesDAL Audiences_DAL = new AudiencesDAL();

        public void Add(audiences_tbl audiences)
        {
            Audiences_DAL.Add(audiences);
           
        }
        public List<audiences_tbl> Get()
        {
            return Audiences_DAL.Get();
        }
    }
}
