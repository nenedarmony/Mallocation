using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class custumerHistorysBLL
    {

        public int Add(CostumerHistorysDTO costumerHistorysDTO)
        {
          return  CustomerHistoryDAL.Add(Convert(costumerHistorysDTO));
        }

        public List<CostumerHistorysDTO> GetAll()
        {
            List<CostumerHistorysDTO> costumerHistorysDTO = new List<CostumerHistorysDTO>();
            List<custumer_historys_tbl> custumer_historys_tbl = CustomerHistoryDAL.GetAll();
            foreach (var item in custumer_historys_tbl)
            {
                costumerHistorysDTO.Add(Convert(item));
            }
            return costumerHistorysDTO;
        }

        public bool delete(int custumer_HistorysID)
        {
            return CustomerHistoryDAL.delete(custumer_HistorysID);
        }

        public bool update(CostumerHistorysDTO costumerHistorysDTO)
        {
            custumer_historys_tbl custumerhistorystbl = new custumer_historys_tbl();
            custumerhistorystbl = Convert(costumerHistorysDTO);
            return CustomerHistoryDAL.update(custumerhistorystbl);
        }

        public custumer_historys_tbl Convert(CostumerHistorysDTO costumerHistorysDTO)
        {
            custumer_historys_tbl custumerhistorystbl = new custumer_historys_tbl();
            custumerhistorystbl.CustumerHistorysID = costumerHistorysDTO.CustumerHistorysID;
            custumerhistorystbl.IDFromShop = costumerHistorysDTO.IDFromShop;
            custumerhistorystbl.IDfromUser = costumerHistorysDTO.IDfromUser;
            custumerhistorystbl.NumOfTimeGoToShope = costumerHistorysDTO.NumOfTimeGoToShope;
            custumerhistorystbl.NumOfTimeWasSatified = costumerHistorysDTO.NumOfTimeWasSatified;

            return custumerhistorystbl;
        }

        public CostumerHistorysDTO Convert(custumer_historys_tbl custumerhistorystbl)
        {
            CostumerHistorysDTO costumerHistorysDTO = new CostumerHistorysDTO();
            costumerHistorysDTO.CustumerHistorysID = custumerhistorystbl.CustumerHistorysID;
            costumerHistorysDTO.IDFromShop = custumerhistorystbl.IDFromShop;
            costumerHistorysDTO.IDfromUser = custumerhistorystbl.IDfromUser;
            costumerHistorysDTO.NumOfTimeGoToShope = custumerhistorystbl.NumOfTimeGoToShope;
            costumerHistorysDTO.NumOfTimeWasSatified = custumerhistorystbl.NumOfTimeWasSatified;
            return costumerHistorysDTO;
        }
    }
}
