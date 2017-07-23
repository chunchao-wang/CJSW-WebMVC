using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CJSW_WebMVC.Models;
namespace CJSW_WebMVC.DAL
{
    public class realTime
    {
        /// <summary>
        /// 根据起始时间和结束时间获取按小时为单位的降雨量信息。可以包含多站的信息
        /// </summary>
        /// <param name="stations"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static QueryResult getRainByHour(List<string> stations, DateTime from, DateTime to)
        {
            if (stations == null || stations.Count == 0)
            {
                return new QueryResult();
            }
            if (to <= from)
            {
                Console.WriteLine("查询时间设置错误！");
                return new QueryResult();
            }
            QueryResult result = new QueryResult();
            IQueryable<HourRain> records = RainHandler.ListHourRain(from, to, stations);
            foreach(string station in stations)
            {

            }
            return result;
        }
        //public static QueryResult queryTodayRain(DateTime today, List<long> stations)
        //{
        //    //初始化查询条件
        //    DateTime from = new DateTime(
        //        year: today.Year,
        //        month: today.Month,
        //        day: today.Day,
        //        hour: 8,
        //        minute: 0,
        //        second: 0
        //    );
        //    DateTime to = new DateTime(
        //        year: today.Year,
        //        month: today.Month,
        //        day: today.Day,
        //        hour: DateTime.Now.Hour,
        //        minute: 0,
        //        second: 0
        //    );
        //    //初始化查询结果
        //    QueryResult result = new QueryResult();
        //    //为查询结果添加表头
        //    result.dataTitles.Add("站号");
        //    result.dataTitles.Add("站名");
        //    result.dataTitles.Add("站类");
        //    result.dataTitles.Add("所在地");
        //    int endHour = DateTime.Now.Hour;
        //    int current = 8;
        //    while (current < endHour)
        //    {
        //        result.dataTitles.Add((endHour-1) + "-" + endHour);
        //        endHour--;
        //    }
        //    foreach(long stationId in stations)
        //    {
        //        DAL.RainHandler.singleRainRecord(from, to, stationId);
        //        //TODO 添加站点雨量信息
        //        //result.records.Add();
        //    }
        //    return result;
        //}
    }
}