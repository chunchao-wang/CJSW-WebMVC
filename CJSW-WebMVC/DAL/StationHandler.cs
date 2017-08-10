using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace CJSW_WebMVC.DAL
{
    public class StationHandler
    {
        /// <summary>
        /// 根据分中心ID获取下辖所有站点的信息
        /// </summary>
        /// <param name="SubCenterID"></param>
        /// <returns></returns>
        public static List<Models.Station> ListStationBySubcenterId(int? SubCenterID)
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
        /// <summary>
        /// 根据分中心ID获取下辖所有站点的ID
        /// </summary>
        /// <param name="SubCenterID"></param>
        /// <returns></returns>
        public static List<string> ListStationIdBySubcenterId(int? SubCenterID)
        {
            //查询
            IQueryable<Models.hydlstation> queryResult = SubCenterID.HasValue ? DBContext.db.hydlstation.Where(s => s.SubCenterID == SubCenterID.Value) : DBContext.db.hydlstation;
            //将查询结果填充进List返回
            List<string> stationIds = new List<string>();
            stationIds = (from station in queryResult select station.StationID).ToList();
            return stationIds;
        }
        /// <summary>
        /// 根据站点ID返回给定站点信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Models.Station GetStationById(string id)
        {
            return new Models.Station(DBContext.db.hydlstation.First(s => s.StationID == id));
        }
    }
}