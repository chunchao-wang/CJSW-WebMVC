using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CJSW_WebMVC.DAL
{
    public class RainStationHandler
    {
        public static IQueryable<Models.hydlstation> rainStation(int? SubCenterID)
        {
            if (SubCenterID.HasValue)
            {
                return DBContext.db.hydlstation.Where(s => s.SubCenterID == SubCenterID.Value);
            }
            else
            {
                return DBContext.db.hydlstation;
            }
        }
    }
}