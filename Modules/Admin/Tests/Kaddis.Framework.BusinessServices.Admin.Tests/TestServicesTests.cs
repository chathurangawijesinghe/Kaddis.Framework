using System;
using Kaddis.Framework.BusinessServices.IAdmin;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaddis.Framework.BusinessServices.Admin.Tests
{
    [TestClass]
    public class TestServicesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestService testService = new TestService();
            var test = testService.GetAll();
        }
    }
}
