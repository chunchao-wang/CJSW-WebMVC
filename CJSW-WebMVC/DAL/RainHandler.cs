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
        /// 查找多站的降雨记录结果
        /// 记录与数据库中rain表结构一致
        /// </summary>
        /// <param name="from">查询的开始时间</param>
        /// <param name="to">查询的结束时间</param>
        /// <param name="subcenter">分中心的限定，为可变参数。如果没有填写则返回所有站点在给定时间内的记录</param>
        public static IQueryable<Models.rain> multiRainRecord(DateTime from, DateTime to,int? subcenter)
        {
            if (subcenter.HasValue)
            {
                IQueryable<string> stations = DBContext.db.hydlstation.Where(s => s.SubCenterID == subcenter).Select(s => s.StationID);
                return DBContext.db.rain.Where(r => stations.Contains(r.stationid) && r.datatime >= from && r.datatime <= to);
            }
            else
            {
                return DBContext.db.rain.Where(r => r.datatime >= from && r.datatime <= to);
            }
            
        }
        /// <summary>
        /// 查找单站的雨量数据结果，查询结果与数据库中rain表结构相同。
        /// </summary>
        /// <param name="from">查询起始时间</param>
        /// <param name="to">查询结束时间点</param>
        /// <param name="station">站点编号</param>
        /// <returns>可以再次进行筛选的结果集</returns>
        public static IQueryable<Models.rain> singleRainRecord(DateTime from, DateTime to, string station)
        {
            return DBContext.db.rain.Where(r => r.stationid == station && r.datatime >= from && r.datatime <= to);
        }
    }
}