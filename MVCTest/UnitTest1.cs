using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace CJSW_WebMVC
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void TestMethod1()
        {
            List<string> stationIds = new List<string>();
            stationIds.Add("1001");
            Models.QueryResult result = DAL.RealTimeService.GetTodayRain(stationIds);
        }
    }
}
