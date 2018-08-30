using Kaddis.Framework.DataServices.IAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaddis.Framework.Common.Patterns.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ITestRepository Tests { get; }

        int Complete();
    }
}
