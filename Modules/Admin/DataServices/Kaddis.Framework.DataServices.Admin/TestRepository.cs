using Kaddis.Framework.Common.Patterns.Repository;
using Kaddis.Framework.Data.KaddisFrameworkModel.Model;
using Kaddis.Framework.DataServices.IAdmin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaddis.Framework.DataServices.Admin
{
    public class TestRepository : GenericRepository<Test>, ITestRepository
    {
        public TestRepository(DbContext context) : base (context)
        {

        }
    }
}
