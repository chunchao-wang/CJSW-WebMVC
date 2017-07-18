using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using System.Linq.Expressions;

namespace CJSW_WebMVC.DAL.Local
{
    public class LocationHandler
    {
        public readonly static string JSON_SAVE_PATH = "location.json";
        /// <summary>
        /// 从<see cref="JSON_SAVE_PATH"/>文件读取站点信息，并作为List返回。
        /// </summary>
        /// <returns></returns>
        public static Models.StationLocationList getStationLocations()
        {
            try
            {
                string json = File.ReadAllText(JSON_SAVE_PATH);
                JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                Models.StationLocationList locations = jsonSerializer.Deserialize<Models.StationLocationList>(json);
                return locations;
            }
            catch (Exception e)
            {
                Console.WriteLine("读取json文件失败！" + e.ToString());
                return new Models.StationLocationList();
            }

        }
        /// <summary>
        /// 按照站号顺序将站点信息写入json文件。路径保存为：<see cref="JSON_SAVE_PATH"/>
        /// </summary>
        /// <param name="stations"></param>
        /// <returns></returns>
        public static bool setStationLocations(Models.StationLocationList stations)
        {
            try
            {
                stations.list = stations.list.OrderBy(station => station.stationId).ToList();
                JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                string json = jsonSerializer.Serialize(stations);
                File.WriteAllText(JSON_SAVE_PATH,json);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("写入json文件失败！" + e.ToString());
                return false;
            }
        }
    }
}