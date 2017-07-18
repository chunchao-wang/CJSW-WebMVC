using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CJSW_WebMVC.Controllers
{
    public class rainController : Controller
    {
        //private Models.Entities db = new Models.Entities();
        public ActionResult Index()
        {
            return monitor();
        }
        // GET: Rain
        //降雨分布图，默认的首页
        public ActionResult monitor()
        {

            ViewBag.Content = "这里显示降雨分布地图。";
            return View();
        }
        // GET:rain/realTime
        //TODO 实时降雨的查询
        public ActionResult realTime()
        {
            //DateTime from = Convert.ToDateTime(Request.Params.Get("from"));
            //DateTime to = Convert.ToDateTime(Request.Params.Get("to"));
            //string stationId = Request.Params.Get("station-id");
            //var list = new List<KeyValuePair<string, IQueryable<Models.rain>>>();
            //list.Add(new KeyValuePair<string, IQueryable<Models.rain>>("data", DAL.RainHandler.singleRainRecord(from, to, stationId)));
            //ViewData.Add("data",list);
            //ViewBag.Title = "实时降雨信息";
            //return View();

            /*显示所有站点的今日降雨*/
            #region 初始化查询条件
            DateTime today = DateTime.Now;
            //还不到8点，今日按照从昨天早上8点开始计算
            if (today.Hour <= 8)
            {
                today = today.AddDays(-1);
            }
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
                day: today.Day+1,
                hour: DateTime.Now.Hour,
                minute: 0,
                second: 0
            );
            long? subcenterId = null;
            List<Models.Station> stations = DAL.StationHandler.station(subcenterId);
            #endregion
            //初始化查询结果
            Models.QueryResult result = new Models.QueryResult();

            //为查询结果添加表头
            result.dataTitles.Add("站号");
            result.dataTitles.Add("站名");
            result.dataTitles.Add("站类");
            result.dataTitles.Add("所在地");
            result.dataTitles.Add("累计");
            DateTime current = DateTime.Now;
            List<DateTime> period = new List<DateTime>();
            while (from < current)
            {
                period.Add(current);
                result.dataTitles.Add((current.AddHours(-1).Hour) + "-" + current.Hour);
                current = current.AddHours(-1);
            }
            foreach (Models.Station station in stations)
            {
                IQueryable<Models.rain> queryResult = DAL.RainHandler.singleRainRecord(from, to, station.stationId);
                //添加累计和
                Models.Record record = new Models.Record();
                decimal sum = queryResult.Where(r => r.datatime <= period.First() && r.datatime >= period.Last()).Sum(r => r.periodrain).Value;
                record.station = station;
                record.datas.Add(sum);
                //每个时间段都分别求出结果
                foreach(DateTime time in period)
                {
                    decimal data = queryResult.Where(r => r.datatime < time.AddHours(1) && r.datatime >= time).Sum(r => r.periodrain).Value;
                    record.datas.Add(data);
                }
                result.records.Add(record);
                ViewData.Add("table",result);
            }
            return View();
        }
    public ActionResult rainReport()
    {
        ViewBag.Content = "显示降雨报表";
        return View();
    }

    public ActionResult rainAreaStatistic()
    {
        ViewBag.Content = "面雨量统计";
        return View();
    }

    //public ActionResult rainPointQuery()
    //{
    //    ViewBag.Content = "点雨量查询";
    //    return View();
    //}
    //提供点雨量查询功能，参数包括：
    /**
     * type：查询条件：累计查询，日查询，时段，旬
     * substation：分中心筛选
     * from：起始时间
     * to：结束时间
     * standard：雨量标准，超过这个标准的才会返回。
     * **/
    public ActionResult rainPointQuery()
    {
        string type = Request.Params.Get("type");
        return View();
    }
}
}