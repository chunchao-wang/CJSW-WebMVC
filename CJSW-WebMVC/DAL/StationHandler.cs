using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace CJSW_WebMVC.DAL
{
    public class StationHandler
    {
        public static List<Models.Station> station(long? SubCenterID)
        {
            //查询
            IQueryable<Models.hydlstation> queryResult = null;
            if (SubCenterID.HasValue)
            {
                queryResult = DBContext.db.hydlstation.Where(s => s.SubCenterID == SubCenterID.Value);
            }
            else
            {
                queryResult = DBContext.db.hydlstation;
            }
            //将查询结果填充进List返回
            List<Models.Station> stations = new List<Models.Station>();
            foreach(Models.hydlstation station in queryResult)
            {
                stations.Add(new Models.Station(station));
            }
            return stations;
        }
    }
}