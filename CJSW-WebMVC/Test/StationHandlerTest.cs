using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CJSW_WebMVC.DAL;
namespace CJSW_WebMVC.Test
{
    public class StationHandlerTest
    {

        public static void listStationIdTest()
        {
            Nullable<int> subcenterId = null;
            List<string> ids = StationHandler.listStationId(subcenterId);
            foreach(string id in ids)
            {
                Console.WriteLine("站点ID:"+id);
            }

        }
    }
}