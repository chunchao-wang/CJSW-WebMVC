using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CJSW_WebMVC.Models
{
    public class DayRain
    {
        public DayRain(DateTime time,decimal? data)
        {
            this.time = time;
            if (data.HasValue)
            {
                this.data = data.Value;
            }
            else
            {
                this.data = -1;//数据库缺数
            }
        }
        public DateTime time { get; set; }
        public decimal data { get; set; }
    }
}