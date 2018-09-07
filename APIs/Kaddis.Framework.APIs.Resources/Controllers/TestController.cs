using Kaddis.Framework.Common.Entities;
using Kaddis.Framework.Facades.ICommon;
using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Kaddis.Framework.APIs.Resources.Controllers
{
    [ApiVersion("1.0")]
    [RoutePrefix("api/v{version:apiVersion}/test")]
    public class TestController : ApiController
    {
        private readonly ITestFacade testFacade;

        public TestController(ITestFacade testFacade)
        {
            this.testFacade = testFacade;
            
        }

        [Route("getall")]
        public List<TestDto> GetAll()
        {
            return testFacade.GetAll();
        }

        [Route("getbyid/{id}")]
        public TestDto GetById(int Id)
        {
            return testFacade.GetById(Id);
        }

        [HttpPost]
        [Route("insert")]
        public void Insert(TestDto testDto)
        {
            testFacade.Insert(testDto);
        }

        [HttpPost]
        [Route("update")]
        public void Update(TestDto testDto)
        {
            testFacade.Update(testDto);
        }

        [HttpPost]
        [Route("delete/{Id}")]
        public void Delete(int Id)
        {
            testFacade.Delete(Id);
        }
    }
}
