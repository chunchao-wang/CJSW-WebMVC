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
    }
}