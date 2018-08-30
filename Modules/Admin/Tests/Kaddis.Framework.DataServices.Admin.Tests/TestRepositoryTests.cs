using System;
using Kaddis.Framework.DataServices.IAdmin;
using Kaddis.Framework.DataServices.Admin;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kaddis.Framework.DataServices.Admin.Tests
{
    [TestClass]
    public class TestRepositoryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            ITestRepository testRepository = new TestRepository();
            var test = testRepository.GetAll();

        }
    }
}
