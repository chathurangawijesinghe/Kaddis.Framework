using Kaddis.Framework.Common.Entities;
using Kaddis.Framework.Common.Mappers;
using Kaddis.Framework.Common.Mappers.Admin;
using Kaddis.Framework.Common.Patterns.Repository;
using Kaddis.Framework.Common.Patterns.UnitOfWork;
using Kaddis.Framework.Data.KaddisFrameworkModel.Model;
using Kaddis.Framework.DataServices.Admin;
using Kaddis.Framework.DataServices.IAdmin;
using Kaddis.Framework.Services.IAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaddis.Framework.Services.Admin
{
    public class TestService : GenericService<TestDto, Test>, ITestService
    {
        private readonly IUnitOfWork unitOfWork;

        public TestService(IUnitOfWork unitOfWork, ITestMapper testMapper) : base (unitOfWork.Tests, testMapper)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Testmethod()
        {
            this.unitOfWork.Complete();
        }
    }
}
