﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AudiencesDAL
    {


        public static int Add(audiences_tbl audiences)
        {
            using (var context = new DatabaseEntities())
            {
                context.audiences_tbl.Add(audiences);
                context.SaveChanges();
                int code = 0;
                foreach (audiences_tbl item in context.audiences_tbl)
                {
                    code = item.AudienceID;
                }
                return code;
            }

        }
        public static List<audiences_tbl> GetAll()
        {
            using (var context = new DatabaseEntities())
            {
                List<audiences_tbl> listAudiences = context.audiences_tbl.ToList();
                return listAudiences;
            }

        }
        public static bool Delete(int adienceID)
        {
            using (var context = new DatabaseEntities())
            {
                try
                {
                    audiences_tbl toDel = context.audiences_tbl.FirstOrDefault(x => x.AudienceID ==adienceID );
                    if (toDel != null)
                    {
                        context.Entry(toDel).State = System.Data.Entity.EntityState.Deleted;
                        context.SaveChanges();
                    }
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }

            }
        }
        public static bool update(audiences_tbl audiences)
        {
            using (var context = new DatabaseEntities())
            {
                try
                {
                    audiences_tbl old = context.audiences_tbl.FirstOrDefault(x => x.AudienceID == audiences.AudienceID);

                    if (old != null)
                    {
                        old.AudienceName = audiences.AudienceName;
                        
                        context.SaveChanges();
                    }
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }

            }
        }
    }
}
