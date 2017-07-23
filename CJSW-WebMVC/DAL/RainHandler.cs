using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CJSW_WebMVC.DAL
{
    public class RainHandler
    {
        /// 查找多站的降雨记录结果<see cref="Models.Record"/>
        /// </summary>
        /// <param name="from">查询的开始时间</param>
        /// <param name="to">查询的结束时间</param>
        /// <param name="stations">给定的站点限制</param>
        public static IQueryable<Models.HourRain> ListHourRain(DateTime timefrom, DateTime to, List<string> stations)
        {
            return from rain in DBContext.db.rain where (stations.Any(id => id == rain.stationid) && rain.datatime <= to && rain.datatime >= timefrom) select new Models.HourRain(rain.datatime, rain.totalrain) ;
        }
    }
}