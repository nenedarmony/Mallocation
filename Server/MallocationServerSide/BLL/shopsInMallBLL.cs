using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class ShopsInMallBLL
    {
    
        public int Add(ShopsInMallDTO shopsInMallDTO)
        {
          return  ShopsInMallDAL.Add(Convert(shopsInMallDTO));
        }

        public List<ShopsInMallDTO> GetAll()
        {
            List<ShopsInMallDTO> listshopsInMallDTO = new List<ShopsInMallDTO>();
            List<shopsInMall_tbl> listShopsInMall_tbl = ShopsInMallDAL.GetAll();
            foreach (var item in listShopsInMall_tbl)
            {
                listshopsInMallDTO.Add(Convert(item));
            }
            return listshopsInMallDTO;
        }

        public bool delete(int shopsInMallDTO)
        {
            return ShopsInMallDAL.delete(shopsInMallDTO);
        }

        public bool update(ShopsInMallDTO shopsInMallDTO)
        {
            shopsInMall_tbl shopsInMall_tbl = new shopsInMall_tbl();
            shopsInMall_tbl = Convert(shopsInMallDTO);
            return ShopsInMallDAL.update(shopsInMall_tbl);
        }
        public shopsInMall_tbl Convert(ShopsInMallDTO shopsInMallDTO)
        {
            shopsInMall_tbl shopsInMall_tbl = new shopsInMall_tbl();
            shopsInMall_tbl.shopInMallID = shopsInMallDTO.shopInMallID;
            shopsInMall_tbl.IdFromMall = shopsInMallDTO.IdFromMall;
            shopsInMall_tbl.IdFromShop = shopsInMallDTO.IdFromShop;

            return shopsInMall_tbl;
        }
        public ShopsInMallDTO Convert(shopsInMall_tbl shopsInMall_tbl)
        {
            ShopsInMallDTO shopsInMallDTO = new ShopsInMallDTO();
            shopsInMallDTO.shopInMallID = shopsInMall_tbl.shopInMallID;
            shopsInMallDTO.IdFromMall = shopsInMall_tbl.IdFromMall;
            shopsInMallDTO.IdFromShop = shopsInMall_tbl.IdFromShop;
            return shopsInMallDTO;
        }
    }
}
