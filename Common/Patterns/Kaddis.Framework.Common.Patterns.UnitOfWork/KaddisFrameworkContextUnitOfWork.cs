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
    public class KaddisFrameworkContextUnitOfWork : IDisposable
    {
        private KaddisFrameworkContext context = new KaddisFrameworkContext();

        private ITestRepository testRepository;

        public ITestRepository TestRepository
        {
            get
            {
                if (this.testRepository == null)
                {
                    this.testRepository = new TestRepository(context);
                }
                return this.testRepository;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
