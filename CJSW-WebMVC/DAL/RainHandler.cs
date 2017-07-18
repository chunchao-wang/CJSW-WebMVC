using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CJSW_WebMVC.DAL
{
    public class RainHandler
    {
        ///时间格式：YYYYMMDDhh
        /// int.max=2147483647(够用到2147年)
        /// <summary>
        /// 查找多站的降雨记录结果<see cref="Models.Record"/>
        /// </summary>
        /// <param name="from">查询的开始时间</param>
        /// <param name="to">查询的结束时间</param>
        /// <param name="subcenter">分中心的限定，为可变参数。如果没有填写则返回所有站点在给定时间内的记录</param>
        public static List<Models.Record> multiRainRecord(DateTime from, DateTime to,int? subcenter)
        {
            IQueryable<Models.rain> queryResult = null;
            if (subcenter.HasValue)
            {
                ////在数据库中做查询
                //IQueryable<string> stations = DBContext.db.hydlstation.Where(s => s.SubCenterID == subcenter).Select(s => s.StationID); 
                //queryResult = DBContext.db.rain.Where(r => stations.Contains(r.stationid) && r.datatime >= from && r.datatime <= to);
                //将查询结果改写为目标格式
                List<Models.Station> stations = DAL.StationHandler.station(subcenter.Value);
            }
            else
            {
                //在数据库中做查询
                queryResult = DBContext.db.rain.Where(r => r.datatime >= from && r.datatime <= to);
                //将查询结果改写为目标格式

            }

            // TODO 根据站点的信息查询记录
            return null;


        }
        /// <summary>
        /// 查找单站的雨量数据结果，查询结果与数据库中rain表结构相同。
        /// </summary>
        /// <param name="from">查询起始时间</param>
        /// <param name="to">查询结束时间点</param>
        /// <param name="station">站点编号</param>
        /// <returns>可以再次进行筛选的结果集</returns>
        public static IQueryable<Models.rain> singleRainRecord(DateTime from, DateTime to, long stationId)
        {
            return DBContext.db.rain.Where(r => r.stationid == stationId.ToString() && r.datatime >= from && r.datatime <= to);
        }
    }
}