using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CJSW_WebMVC.Controllers
{
    public class loginController : Controller
    {
        // 登陆页面
        public ActionResult Index()
        {
            return View();
        }
        // 登陆操作
        public ActionResult login()
        {
            string username = Request.Params.Get("username");
            string password = Request.Params.Get("password");
            string message;
            bool result = DAL.UserService.Login(username, password, out message);
            if (result)
            {
                //使用session保存用户登陆信息，不需要手动维护。
                Session["username"] = username;
                Response.Redirect("/rain/realTime", true);

            }
            else
            {
                ViewBag.Title = "登陆失败！";
                ViewBag.Message = message;
            }
            return View();
        }
    }
}