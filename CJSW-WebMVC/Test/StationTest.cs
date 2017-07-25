using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CJSW_WebMVC.Models;
using CJSW_WebMVC.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CJSW_WebMVC.Test
{
    [TestClass]
    public class StationTest
    {
        [TestMethod]
        public void listStationTest()
        {
            List<int> subcenters = new List<int>();
            subcenters.Add(11);
            List<Station> stations = StationService.listStationBySubcenterId(subcenters);
            Console.ReadKey();
        }
    }
}