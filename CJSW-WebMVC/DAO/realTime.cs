using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CJSW_WebMVC.Models;
namespace CJSW_WebMVC.DAO
{
    public class realTime
    {
        public static QueryResult queryTodayRain(DateTime today, List<long> stations)
        {
            //初始化查询条件
            DateTime from = new DateTime(
                year: today.Year,
                month: today.Month,
                day: today.Day,
                hour: 8,
                minute: 0,
                second: 0
            );
            DateTime to = new DateTime(
                year: today.Year,
                month: today.Month,
                day: today.Day,
                hour: DateTime.Now.Hour,
                minute: 0,
                second: 0
            );
            //初始化查询结果
            QueryResult result = new QueryResult();
            //为查询结果添加表头
            result.dataTitles.Add("站号");
            result.dataTitles.Add("站名");
            result.dataTitles.Add("站类");
            result.dataTitles.Add("所在地");
            int endHour = DateTime.Now.Hour;
            int current = 8;
            while (current < endHour)
            {
                result.dataTitles.Add((endHour-1) + "-" + endHour);
                endHour--;
            }
            foreach(long stationId in stations)
            {
                DAL.RainHandler.singleRainRecord(from, to, stationId).
                result.records.Add();
            }
        }
    }
}