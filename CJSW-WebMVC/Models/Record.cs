using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CJSW_WebMVC.Models
{
    /// <summary>
    /// 一条查询记录，主要包括站点信息和数据条目
    /// </summary>
    public class Record
    {
        public Record()
        {
            datas = new List<HourRain>();
        }
        public Station station;
        public List<HourRain> datas;
    }
}