using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CJSW_WebMVC.Models;
namespace CJSW_WebMVC.DAL
{
    public class RealTimeService
    {
        /// <summary>
        /// 根据起始时间和结束时间获取按小时为单位的降雨量信息。可以包含多站的信息
        /// </summary>
        /// <param name="stations"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static QueryResult GetTodayRain(List<string> stationIds)
        {
            //查询为空
            if (stationIds == null || stationIds.Count == 0)
            {
                return new QueryResult();
            }
            DateTime now = DateTime.Now;
            DateTime fromTime = new DateTime(
                year: now.Year,
                month: now.Month,
                day: now.Day,
                hour: 8,
                minute: 0,
                second: 0
                );
            DateTime toTime = new DateTime(
                year: now.Year,
                month: now.Month,
                day: now.Day,
                hour: now.Hour,
                minute: 0,
                second: 0
                );
            //早上8点之前，起始时间往前推一天
            if (now.Hour < Conf.Constants.DAYBOUNDARY)
                fromTime = fromTime.AddDays(-1);
            QueryResult result = new QueryResult();
            //构造时间节点列表
            List<DateTime> times = new List<DateTime>();
            for (DateTime t = toTime; t >= fromTime; t = t.AddHours(-1))
            {
                times.Add(t);
            }
            IQueryable<rain> records = RainHandler.ListHourRain(fromTime, toTime, stationIds);
            foreach (string stationId in stationIds)
            {
                IQueryable<rain> singleStationRecords = records.Where(r => r.stationid.Equals(stationId));
                Record stationInfo = new Record();
                stationInfo.station = StationHandler.getStationById(stationId);
                foreach (DateTime t in times)
                {
                    //没有元素不能First()!
                    IQueryable<decimal?> datas = from rain in singleStationRecords where rain.datatime == t select rain.totalrain;
                    decimal? data = datas.Count() > 0 ? datas.First() : null;
                    stationInfo.datas.Add(new HourRain(t, data));
                }
                result.records.Add(stationInfo);
            }
            return result;
        }
        /// <summary>
        /// 根据给定时间查询
        /// </summary>
        /// <param name="fromTime"></param>
        /// <param name="toTime"></param>
        /// <param name="stationIds"></param>
        /// <returns></returns>
        public static QueryResult QueryHourRain(DateTime fromTime, DateTime toTime, List<string> stationIds)
        {
            //查询为空
            if (stationIds == null || stationIds.Count == 0)
            {
                return new QueryResult();
            }
            //时间条件异常
            if (fromTime >= toTime.AddHours(-1))
            {
                return new QueryResult();
            }
            //构建时间列表
            List<DateTime> times = new List<DateTime>();
            DateTime current = new DateTime(
                year: toTime.Year,
                month: toTime.Month,
                day: toTime.Day,
                hour: toTime.Hour,
                minute: 0,
                second: 0);
            for (; current >= fromTime; current = current.AddHours(-1))
            {
                times.Add(current);
            }
            //获取数据
            IQueryable<Models.rain> records = RainHandler.ListHourRain(fromTime, toTime, stationIds);
            QueryResult result = new QueryResult();
            foreach (string stationId in stationIds)
            {
                IQueryable<rain> singleStationRecords = records.Where(r => r.stationid.Equals(stationId));
                Record record = new Record();
                record.station = StationHandler.getStationById(stationId);
                foreach(DateTime t in times)
                {
                    decimal? data;
                    IQueryable<decimal?> datas = from rain in singleStationRecords where rain.datatime == t select rain.periodrain;
                    if(datas == null || datas.Count() == 0)
                    {
                        data = null;
                    }
                    else
                    {
                        data = datas.First();
                    }
                    record.datas.Add(new HourRain(t, data));
                }
                result.records.Add(record);
            }
            return result;
        }
    }
}