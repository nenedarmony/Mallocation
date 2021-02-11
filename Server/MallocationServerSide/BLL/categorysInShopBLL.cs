using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
  public  class categorysInShopBLL
    {
       
        public  int Add(CategorysInShopDTO categorysInShop)
        {
          return  CategorysInShopDAL.Add(Convert(categorysInShop));
        }

        public List<CategorysInShopDTO> GetAll()
        {
            List<CategorysInShopDTO> categorysInShopDTO = new List<CategorysInShopDTO>();
            List<categorys_in_shop> listcategorysInShop = CategorysInShopDAL.GetAll();
            foreach (var item in listcategorysInShop)
            {
                categorysInShopDTO.Add(Convert(item));
            }
            return categorysInShopDTO;
        }

        public bool update(CategorysInShopDTO categorysInShopDTO)
        {
            categorys_in_shop categorysInShop_Tbl = new categorys_in_shop();
            categorysInShop_Tbl = Convert(categorysInShopDTO);
            return CategorysInShopDAL.update(categorysInShop_Tbl);
        }

        public bool delete(int audiencesID)
        {
            return CategorysInShopDAL.delete(audiencesID);
        }


        public categorys_in_shop Convert(CategorysInShopDTO categorysInShopDTO)
        {
            categorys_in_shop categorysInShop_Tbl = new categorys_in_shop();
            categorysInShop_Tbl.categoryInShopID = categorysInShopDTO.categoryInShopID;
            categorysInShop_Tbl.IdFromCategory = categorysInShopDTO.IdFromCategory;
            categorysInShop_Tbl.IdFromShop = categorysInShopDTO.IdFromShop;

            return categorysInShop_Tbl;
        }

        public CategorysInShopDTO Convert(categorys_in_shop categorysInShop_Tbl)
        {
            CategorysInShopDTO categorysInShopDTO = new CategorysInShopDTO();
            categorysInShopDTO.categoryInShopID = categorysInShop_Tbl.categoryInShopID;
            categorysInShopDTO.IdFromCategory = categorysInShop_Tbl.IdFromCategory;
            categorysInShopDTO.IdFromShop = categorysInShop_Tbl.IdFromShop;

            return categorysInShopDTO;
        }

    }
}
