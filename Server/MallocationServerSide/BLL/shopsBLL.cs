using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class ShopsBLL
    {
       
        public int Add(ShopsDTO shopsDTO)
        {
          return  ShopsDAL.Add(Convert(shopsDTO));
        }

        public List<ShopsDTO> GetAll()
        {
            List<ShopsDTO> listShopsDTO = new List<ShopsDTO>();
            List<shops_tbl> listShops_tbl = ShopsDAL.GetAll();
            foreach (var item in listShops_tbl)
            {
                listShopsDTO.Add(Convert(item));
            }
            return listShopsDTO;
        }

        public bool delete(int ShopID)
        {
            return ShopsDAL.delete(ShopID);
        }

        public bool update(ShopsDTO shopsDTO)
        {
            shops_tbl shops_Tbl = new shops_tbl();
            shops_Tbl = Convert(shopsDTO);
            return ShopsDAL.update(shops_Tbl);
        }
        public shops_tbl Convert(ShopsDTO shopsDTO)
        {
            shops_tbl shops_Tbl = new shops_tbl();
            shops_Tbl.ShopID = shopsDTO.ShopID;
            shops_Tbl.ShopName = shopsDTO.ShopName;
            shops_Tbl.IdFromAudience = shopsDTO.IdFromAudience;

            return shops_Tbl;
        }
        public ShopsDTO Convert(shops_tbl shops_Tbl)
        {
            ShopsDTO shopsDTO = new ShopsDTO();
            shopsDTO.ShopID = shops_Tbl.ShopID;
            shopsDTO.ShopName = shops_Tbl.ShopName;
            shopsDTO.IdFromAudience = shops_Tbl.IdFromAudience;

            return shopsDTO;
        }
    }
}
