using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CJSW_WebMVC.Test
{
    [TestClass]
    public class RainTest
    {
        [TestMethod]
        public void TodayRainTest()
        {
            List<string> stationIds = new List<string> {"0002", "0003"};
            Models.QueryResult result = DAL.RainService.GetTodayRain(stationIds);
//            int a = 0;
        }
        [TestMethod]
        public void QueryHourRain()
        {
            DateTime from = new DateTime(
                year: 2016,
                month: 05,
                day: 01,
                hour: 08,
                minute: 0,
                second: 0);
            DateTime to = from.AddDays(3);
            List<string> stationIds = new List<string> {"0801", "0003"};
            Models.QueryResult result = DAL.RainService.QueryHourRain(from, to, stationIds);
            Console.ReadKey();
        }
    }
}