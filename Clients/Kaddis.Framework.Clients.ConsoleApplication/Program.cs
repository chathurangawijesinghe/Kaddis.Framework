using Kaddis.Framework.Common.Mappers;
using Kaddis.Framework.Common.Mappers.Admin;
using Kaddis.Framework.Common.Patterns.UnitOfWork;
using Kaddis.Framework.Data.KaddisFrameworkModel.Model;
using Kaddis.Framework.DataServices.Admin;
using Kaddis.Framework.DataServices.IAdmin;
using Kaddis.Framework.Services.Admin;
using Kaddis.Framework.Services.IAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaddis.Framework.Clients.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            ITestService testService = new TestService(unitOfWork, new TestMapper());
            var test = testService.GetAll();
        }
    }
}
