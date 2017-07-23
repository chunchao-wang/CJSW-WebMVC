using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CJSW_WebMVC.DAL
{
    public class SubCenterHandler
    {
        /// <summary>
        /// 获取所有分中心的信息
        /// </summary>
        /// <returns></returns>
        public static IQueryable<Models.SubCenter> ListCenter()
        {
            return DBContext.db.SubCenter;
        }
        /// <summary>
        /// 根据id取唯一的subcenter信息
        /// </summary>
        /// <param name="subcenterId"></param>
        /// <returns></returns>
        public static Models.SubCenter GetSubcenter(int subcenterId)
        {
            return DBContext.db.SubCenter.Where(s => s.SubCenterID == subcenterId).First();
        }
    }
}