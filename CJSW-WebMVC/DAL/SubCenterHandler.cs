using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CJSW_WebMVC.DAL
{
    public class SubCenterHandler
    {
        public static IQueryable<Models.SubCenter> allCenter()
        {
            return DBContext.db.SubCenter;
        }
    }
}