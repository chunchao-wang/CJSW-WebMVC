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
            List<string> stationIds = new List<string>();
            stationIds.Add("0002");
            stationIds.Add("0003");
            Models.QueryResult result = DAL.RealTimeService.GetTodayRain(stationIds);
            int a = 0;
        }
    }
}