using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CJSW_WebMVC.Models;
namespace CJSW_WebMVC.DAL
{
    public class StationService
    {
        public static List<Station> ListStationBySubcenterId(List<int> subcenterIds)
        {
            List<Station> result = new List<Station>();
            foreach(int subcenterId in subcenterIds)
            {
                List<Station> current = StationHandler.ListStationBySubcenterId(subcenterId);
                result.InsertRange(0,current);
            }
            return result;
        }

        public static List<Station> ListStationAll()
        {
            IQueryable<SubCenter> subcenters = SubCenterHandler.ListCenter();
            List<int> subcenterIds =(from subcenter in subcenters select subcenter.SubCenterID).ToList();
            return ListStationBySubcenterId(subcenterIds);
        }
    }
}