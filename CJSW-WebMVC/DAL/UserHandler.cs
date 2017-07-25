using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CJSW_WebMVC.Models;
namespace CJSW_WebMVC.DAL
{
    public class UserHandler
    {
        public static User getUser(string name)
        {
            IQueryable<User> set = DBContext.db.User.Where(u => u.Name == name);
            if(set == null || set.Count() == 0)
            {
                return null;
            }
            else
            {
                return set.First();
            }
        }
    }
}