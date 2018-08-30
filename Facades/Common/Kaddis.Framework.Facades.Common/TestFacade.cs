using Kaddis.Framework.Common.Entities;
using Kaddis.Framework.Facades.ICommon;
using Kaddis.Framework.Services.Admin;
using Kaddis.Framework.Services.IAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaddis.Framework.Facades.Common
{
    public class TestFacade : ITestFacade
    {
        private readonly ITestService testService;

        public TestFacade(ITestService testService)
        {
            this.testService = testService;
        }

        public List<TestDto> GetAll()
        {
            return testService.GetAll().ToList();
        }

        public TestDto GetById(int Id)
        {
            return testService.GetById(Id);
        }

        public void Insert(TestDto testDto)
        {
            testService.Insert(testDto);
        }

        public void Update(TestDto testDto)
        {
            testService.Update(testDto);
        }

        public void Delete(int Id)
        {
            testService.Delete(Id);
        }
        
    }
}
