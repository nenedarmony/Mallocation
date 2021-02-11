using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class categorysBLL
    {
        public int Add(CategoryDTO categorys)
        {
           return CategorysDAL.Add(Convert(categorys));
        }

        public List<CategoryDTO> GetAll()
        {
            List<CategoryDTO> listCategoryDTO = new List<CategoryDTO>();
            List<categorys_tbl> listcategorys = CategorysDAL.GetAll();
            foreach (var item in listcategorys)
            {
                listCategoryDTO.Add(Convert(item));
            }
            return listCategoryDTO;
        }

        public bool delete(int categoryID)
        {
            return CategorysDAL.delete(categoryID);
        }

        public bool update(CategoryDTO categoryDTO)
        {
            categorys_tbl categorys_Tbl = new categorys_tbl();
            categorys_Tbl = Convert(categoryDTO);
            return CategorysDAL.update(categorys_Tbl);
        }
        public categorys_tbl Convert(CategoryDTO categoryDTO)
        {
            categorys_tbl categorys_Tbl = new categorys_tbl();
            categorys_Tbl.CategoryID = categoryDTO.CategoryID;
            categorys_Tbl.Category = categoryDTO.Category;
            return categorys_Tbl;
        }
        public CategoryDTO Convert(categorys_tbl categorys_Tbl)
        {
            CategoryDTO categoryDTO = new CategoryDTO();
            categoryDTO.CategoryID = categorys_Tbl.CategoryID;
            categoryDTO.Category = categorys_Tbl.Category;
            return categoryDTO;
        }

    }
}
