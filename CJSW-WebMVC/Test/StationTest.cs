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
        public void ListStationTest()
        {
            List<int> subcenters = new List<int> {11};
            List<Station> stations = StationService.ListStationBySubcenterId(subcenters);
            Console.ReadKey();
        }

        [TestMethod]
        public void ListStationAllTest()
        {
            List<Station> stations = StationService.ListStationAll();
            foreach (Station station in stations)
            {
                Console.WriteLine(station.stationId);
            }
            Console.WriteLine("共" + stations.Count + "行");
            Console.ReadKey();
        }
    }
}