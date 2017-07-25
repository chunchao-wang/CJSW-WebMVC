using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CJSW_WebMVC.Test;
namespace MVCUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            UserTest.LoginTest();
            Console.ReadKey();
        }
    }
}
