using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
   public class MallsBLL
    {


        MallsDAL Malls_DAL = new MallsDAL();


        public int Add(MallsDTO mallsDTO)
        {
          return  MallsDAL.Add(Convert(mallsDTO));
        }

        public List<MallsDTO> GetAll()
        {
            List<MallsDTO> listMallsDTO = new List<MallsDTO>();
            List<malls_tbl> listMalls = MallsDAL.GetAll();
            foreach (var item in listMalls)
            {
                listMallsDTO.Add(Convert(item));
            }
            return listMallsDTO;
        }



        public bool delete(int MallID)
        {
            return MallsDAL.delete(MallID);
        }

        public bool update(MallsDTO mallsDTO)
        {
            malls_tbl malls_Tbl = new malls_tbl();
            malls_Tbl = Convert(mallsDTO);
            return MallsDAL.update(malls_Tbl);
        }
        public malls_tbl Convert(MallsDTO mallsDTO)
        {
            malls_tbl malls_Tbl = new malls_tbl();
            malls_Tbl.MallID = mallsDTO.MallID;
            malls_Tbl.MallName = mallsDTO.MallName;
            malls_Tbl.CurentLang = mallsDTO.CurentLang;
            malls_Tbl.CurentLat = mallsDTO.CurentLat;

            return malls_Tbl;
        }
        public MallsDTO Convert(malls_tbl malls_Tbl)
        {
            MallsDTO mallsDTO = new MallsDTO();
            mallsDTO.MallID = malls_Tbl.MallID;
            mallsDTO.MallName = malls_Tbl.MallName;
            mallsDTO.CurentLang = malls_Tbl.CurentLang;
            mallsDTO.CurentLat = malls_Tbl.CurentLat;

            return mallsDTO;
        }
    }
}
