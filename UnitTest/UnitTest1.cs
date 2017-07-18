using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CJSW_WebMVC.Models;
using System.Collections.Generic;
using CJSW_WebMVC.DAL;
using CJSW_WebMVC.DAL.Local;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// 测试json的写入
        /// </summary>
        [TestMethod]
        public void WriteJson()
        {
            StationLocationList stations = new StationLocationList();
            stations.list = new List<StationLocation>()
            {
                new StationLocation(1001,0.8,0.4),
                new StationLocation(1002,0.1,0.2)
            };
            Assert.AreEqual(true, LocationHandler.setStationLocations(stations));

        }
        /// <summary>
        /// 测试json的读取
        /// </summary>
        [TestMethod]
        public void ReadJson()
        {
            bool expect = true;
            bool actual = false;
            try
            {
                StationLocationList stations = LocationHandler.getStationLocations();
                actual = stations.list[0].stationId == 1001 ? true : false;
            }
            catch(Exception e)
            {
                actual = false;
            }
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void ReadStationsFromDb()
        {
            bool expect = true;
            bool actual = false;
            List<Station> stations = StationHandler.station(null);
            stations.Sort();
            
            if(stations[0].stationId == 0001)
            {
                actual = true;
            }
            Assert.AreEqual(expect, actual);
        }
    }
}
