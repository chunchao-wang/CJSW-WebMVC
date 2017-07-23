using Microsoft.VisualStudio.TestTools.UnitTesting;
using CJSW_WebMVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJSW_WebMVC.DAL.Tests
{
    [TestClass()]
    public class StationHandlerTests
    {
        [TestMethod()]
        [TestProperty("TestCategory", "Developer"),
            DataSource("System.Data.SqlClient",
            "Data Source=localhost;" +
            "Initial Catalog=version1_9;" +
            "User id=sa;" +
            "Password=123456;" +
            "Integrated Security=True",
            "version1_9",
            DataAccessMethod.Sequential)]
        public void listStationIdTest()
        {
            Nullable<int> subcenterId = null;
            List<string> ids = StationHandler.listStationId(subcenterId);
            foreach (string id in ids)
            {
                Console.WriteLine("站点ID:" + id);
            }
            Console.ReadKey();
        }
    }
}