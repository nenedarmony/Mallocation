using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CostumerHistorysDTO
    {
        public int CustumerHistorysID { get; set; }
        public int IDFromShop { get; set; }
        public int IDfromUser { get; set; }
        public int  NumOfTimeGoToShope { get; set; }
        public int  NumOfTimeWasSatified { get; set; }
    }
}
