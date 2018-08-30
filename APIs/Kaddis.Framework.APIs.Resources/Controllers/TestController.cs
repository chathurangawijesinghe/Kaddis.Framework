using Kaddis.Framework.Common.Entities;
using Kaddis.Framework.Facades.ICommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Kaddis.Framework.APIs.Resources.Controllers
{
    public class TestController : ApiController
    {
        private readonly ITestFacade testFacade;

        public TestController(ITestFacade testFacade)
        {
            this.testFacade = testFacade;
            
        }

        [Route("api/test/getall")]
        public List<TestDto> GetAll()
        {
            return testFacade.GetAll();
        }

        [Route("api/test/getbyid/{id}")]
        public TestDto GetById(int Id)
        {
            return testFacade.GetById(Id);
        }

        [HttpPost]
        [Route("api/test/insert")]
        public void Insert(TestDto testDto)
        {
            testFacade.Insert(testDto);
        }

        [HttpPost]
        [Route("api/test/update")]
        public void Update(TestDto testDto)
        {
            testFacade.Update(testDto);
        }

        [HttpPost]
        [Route("api/test/delete/{Id}")]
        public void Delete(int Id)
        {
            testFacade.Delete(Id);
        }
    }
}
