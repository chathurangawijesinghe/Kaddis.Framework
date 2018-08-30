using Kaddis.Framework.Data.KaddisFrameworkModel.Model;
using Kaddis.Framework.DataServices.Admin;
using Kaddis.Framework.DataServices.IAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaddis.Framework.Common.Patterns.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly KaddisFrameworkContext context = new KaddisFrameworkContext();

        public UnitOfWork()
        {
            Tests = new TestRepository(context);
        }

        public ITestRepository Tests { get; private set; }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}