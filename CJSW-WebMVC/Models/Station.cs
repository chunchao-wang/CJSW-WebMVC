using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CJSW_WebMVC.Models
{
    /// <summary>
    /// 站点信息的数据结构
    /// </summary>
    public class Station
    {
        public Station(hydlstation raw)
        {
            stationName = raw.CName;
            stationId = long.Parse(raw.StationID);
            subCenter = raw.SubCenter;
            switch (Int32.Parse(raw.CType))
            {
                case (int)StationTypes.rainStation : stationType = StationTypes.rainStation;break;
                case (int)StationTypes.waterStation: stationType = StationTypes.waterStation; break;
                case (int)StationTypes.hydroStation: stationType = StationTypes.hydroStation; break;

                default : stationType = StationTypes.unknownStation; break;
            }
        }
        /// <summary>
        /// 站点类型<see cref="Models.StationType"/>
        /// </summary>
        public StationTypes stationType;
        /// <summary>
        /// 站点编号
        /// </summary>
        public long stationId;
        /// <summary>
        /// 站点名称
        /// </summary>
        public String stationName;
        /// <summary>
        /// 从属于哪个分中心
        /// </summary>
        public SubCenter subCenter;


    }
}