using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CJSW_WebMVC.Test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void LoginTest()
        {
            string realUsername = "ff";
            string realPassword = "123";
            string wrongUsername = "dd";
            string wrongPassword = "1234";
            var result = DAL.UserService.Login(wrongUsername, realPassword, out string message);
            Console.WriteLine("登陆结果" + (result ? "成功！" : "失败！") + "消息：" + message);
            result = DAL.UserService.Login(realUsername, wrongPassword, out message);
            Console.WriteLine("登陆结果" + (result ? "成功！" : "失败！") + "消息：" + message);
            result = DAL.UserService.Login(realUsername, realPassword, out message);
            Console.WriteLine("登陆结果" + (result ? "成功！" : "失败！") + "消息：" + message);
            Console.ReadLine();
        }

        [TestMethod]
        public void UserStatusTest()
        {
            //【没有用户登陆的情况】
            DAL.UserService.Login("ff", "123", out string msg);
            //【登陆一位账户的情况】
            //等待5S
            DAL.UserService.Login("ff", "123", out msg);
            //【用户重新登陆的情况】
            Console.ReadKey();

        }
    }
}