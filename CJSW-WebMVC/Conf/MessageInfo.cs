using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CJSW_WebMVC.Conf
{
    /// <summary>
    /// 显示给用户看的提示信息，可根据需要国际化。
    /// </summary>
    public class MessageInfo
    {
        /** 登陆相关 **/
        public static readonly string USER_NOT_EXIST = "用户不存在！";
        public static readonly string WRONG_PASSWORD = "密码错误！";
        public static readonly string LOGIN_SUCCESS = "登陆成功！";
        public static readonly string USER_NOT_LOGEDIN = "用户未登陆！";
        public static readonly string LOGIN_TIMEOUT = "登陆超时！";
        public static readonly string LOGIN_OK = "登陆正常！";


        /** 页面显示相关 **/
        public static readonly string HYDROSTATION = "水文站";
        public static readonly string RAINSTATION = "雨量站";
        public static readonly string WATERSTATION = "水位站";
        public static readonly string UNKNOWNSTATION = "未知站";
        public static string GetStationTypeDisplay(Models.StationTypes typeCode)
        {
            switch (typeCode)
            {
                case Models.StationTypes.hydroStation: return HYDROSTATION;
                case Models.StationTypes.rainStation:return RAINSTATION;
                case Models.StationTypes.waterStation:return WATERSTATION;
                case Models.StationTypes.unknownStation: return UNKNOWNSTATION;
                default: return UNKNOWNSTATION;
            }
        }
    }
}