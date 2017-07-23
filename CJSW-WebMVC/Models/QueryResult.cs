using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CJSW_WebMVC.Models
{
    public class QueryResult
    {
        public QueryResult()
        {
            records = new List<Record>();
        }
        public List<Record> records;
    }
}