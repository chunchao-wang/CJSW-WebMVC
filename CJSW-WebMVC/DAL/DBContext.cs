using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CJSW_WebMVC.DAL
{
    //数据库所有操作需要访问的对象：Entites
    public class DBContext
    {
        public static Models.Entities db = new Models.Entities();
    }
}