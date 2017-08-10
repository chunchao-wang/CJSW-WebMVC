using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CJSW_WebMVC.Conf
{
    public class Config
    {
        /// <summary>
        /// 每一个整天的分隔时间点，在中国通用的是早上8时。
        /// </summary>
        public static readonly int DAYBOUNDARY = 8;
        /// <summary>
        /// 每天的dayrain在数据库中储存的时间节点。
        /// </summary>
        public static readonly int DAY_RAIN_TIMESTAMP = 8;

        /// <summary>
        /// 保持登陆状态的有效时长，单位为分钟。
        /// </summary>
        public static readonly int LOGIN_EFFECTIVE_MINUTE = 60;
    }
}