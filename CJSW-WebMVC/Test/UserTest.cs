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
            string message;
            bool result;
            result = DAL.UserService.login(wrongUsername, realPassword,out message);
            Console.WriteLine("登陆结果" + (result ? "成功！" : "失败！") + "消息：" + message);
            result = DAL.UserService.login(realUsername, wrongPassword, out message);
            Console.WriteLine("登陆结果" + (result ? "成功！" : "失败！") + "消息：" + message);
            result = DAL.UserService.login(realUsername, realPassword, out message);
            Console.WriteLine("登陆结果" + (result ? "成功！" : "失败！") + "消息：" + message);
            Console.ReadLine();
        }
    }
}