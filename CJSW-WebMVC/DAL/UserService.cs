using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CJSW_WebMVC.Models;
namespace CJSW_WebMVC.DAL
{
    public class UserService
    {
        /// <summary>
        /// 用户登陆操作，需要用户名和密码，返回的是登陆状态和提示信息。获取用户信息则需要使用<see cref="getUser(string)"/>
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static bool login(string username,string password,out string errorMessage)
        {
            User user = UserHandler.getUser(username);
            if(user == null)
            {
                errorMessage = Conf.MessageInfo.USER_NOT_EXIST;
                return false;
            }
            else
            {
                if (!password.Equals(user.Password))
                {
                    errorMessage = Conf.MessageInfo.WRONG_PASSWORD;
                    return false;
                }
                else
                {
                    errorMessage = Conf.MessageInfo.LOGIN_SUCCESS;
                    return true;
                }
            }
        }
        /// <summary>
        /// 获取指定用户信息。登陆验证在login的时候处理。这里只获取用户。
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static User getUser(string username)
        {
            return UserHandler.getUser(username);
        }
    }
}