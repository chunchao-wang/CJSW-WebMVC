using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace CJSW_WebMVC.Models
{
    /// <summary>
    /// 站点位置信息，用于在本地JSON中读取出所有站点信息
    /// </summary>
    public class StationLocation
    {
        public StationLocation()
        {

        }
        public StationLocation(int stationId, double x, double y)
        {
            this.stationId = stationId;
            this.x = x;
            this.y = y;
        }
        public double x { get; set; }
        public double y { get; set; }
        public int stationId { get; set; }
    }
}