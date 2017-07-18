using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CJSW_WebMVC.Models
{
    /// <summary>
    /// 为了反序列化方便，必须将列表储存在对象中
    /// </summary>
    public class StationLocationList
    {
        public List<StationLocation> list { get; set; }
    }
}