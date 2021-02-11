using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class audiencesBLL
    {

        public int Add(AudiencesDTO audiences)
        {
          
         return   AudiencesDAL.Add(Convert(audiences));
           
        }
        public List<AudiencesDTO> GetAll()
        {
            List<AudiencesDTO> listAudiencesDTO = new List<AudiencesDTO>();
            List<audiences_tbl> listAudiences_tbl = AudiencesDAL.GetAll();
            foreach (var item in listAudiences_tbl)
            {
                listAudiencesDTO.Add(Convert(item));
            }
            return listAudiencesDTO;
        }

        public bool Delete(int audiencesID)
        {
          return  AudiencesDAL.Delete(audiencesID);
        }

        public bool update(AudiencesDTO audiencesDTO)
        {
            audiences_tbl Audiences_Tbl = new audiences_tbl();
            Audiences_Tbl = Convert(audiencesDTO);
            return AudiencesDAL.update(Audiences_Tbl);
        }

        public audiences_tbl Convert(AudiencesDTO audiencesDTO)
        {
            audiences_tbl Audiences_Tbl = new audiences_tbl();
            Audiences_Tbl.AudienceID = audiencesDTO.AudienceID;
            Audiences_Tbl.AudienceName = audiencesDTO.AudienceName;
            return Audiences_Tbl;
        }
        public AudiencesDTO Convert(audiences_tbl audiences_Tbl)
        {
            AudiencesDTO audiencesDTO = new AudiencesDTO();
            audiencesDTO.AudienceID = audiences_Tbl.AudienceID;
            audiencesDTO.AudienceName = audiences_Tbl.AudienceName;
            return audiencesDTO;
        }
    }
}
