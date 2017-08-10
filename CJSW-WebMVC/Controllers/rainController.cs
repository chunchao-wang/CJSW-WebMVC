using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CJSW_WebMVC.Models;

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
        public ActionResult RealTime()
        {
            //List<Station> stations = DAL.StationService.ListStationAll();
            List<int> subcenter = new List<int>();
            subcenter.Add(2);
            List<Station> stations = DAL.StationService.ListStationBySubcenterId(subcenter);
            List<string> stationIds = (from station in stations select station.stationId).ToList();
            ViewData["realTimeRain"] = DAL.RainService.GetTodayRain(stationIds);
            return View();
        }
    public ActionResult RainReport()
    {
        ViewBag.Content = "显示降雨报表";
        return View();
    }

    public ActionResult RainAreaStatistic()
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
    public ActionResult RainPointQuery()
    {
        string type = Request.Params.Get("type");
        return View();
    }
}
}