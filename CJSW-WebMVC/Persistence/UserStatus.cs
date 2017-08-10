using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CJSW_WebMVC.Models;
namespace CJSW_WebMVC.Persistence
{
    public class UserStatus
    {
        private static List<UserPersistence> list = new List<UserPersistence>();
        /// <summary>
        /// 检查用户在登陆表中的情况，返回bool和返回信息。
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool CheckStatus(User user, out string message)
        {
            //用户不存在
            if(user == null)
            {
                message = Conf.MessageInfo.USER_NOT_EXIST;
                return false;
            }
            IEnumerable<UserPersistence> set = list.Where(i => i.Uid == user.UID);
            //未登陆
            if(set == null || !set.Any())
            {
                message = Conf.MessageInfo.USER_NOT_LOGEDIN;
                return false;
            }
            UserPersistence u = set.First();
            //登陆超时
            if (u.LoginTime.AddMinutes(Conf.Config.LOGIN_EFFECTIVE_MINUTE) < DateTime.Now)
            {
                message = Conf.MessageInfo.LOGIN_TIMEOUT;
                return false;
            }
            //已登陆，更新登陆状态。
            UserPersistence newStatus = new UserPersistence
            {
                Uid = u.Uid,
                LoginTime = DateTime.Now
            };
            list.Remove(u);
            list.Add(newStatus);
            message = Conf.MessageInfo.LOGIN_OK;
            return true;
        }

        public static void Add(User user)
        {
            IEnumerable<UserPersistence> set = from up in list where up.Uid == user.UID select up;
            //登陆状态不存在(直接添加状态)
            if(!set.Any())
            {
                UserPersistence newUser = new UserPersistence
                {
                    Uid = user.UID,
                    LoginTime = DateTime.Now
                };
                list.Add(newUser);
            }
            //登陆状态存在(Update一下登陆时间)
            else
            {
                UserPersistence current = list.Find(u => u.Uid == user.UID);
                current.LoginTime = DateTime.Now;
            }
        }
    }

    class UserPersistence
    {
        public int Uid { get; set; }
        public DateTime LoginTime { get; set; }
    }
}