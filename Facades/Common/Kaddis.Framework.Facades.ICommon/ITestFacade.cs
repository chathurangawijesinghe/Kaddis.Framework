using Kaddis.Framework.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaddis.Framework.Facades.ICommon
{
    public interface ITestFacade
    {
        List<TestDto> GetAll();

        TestDto GetById(int Id);

        void Insert(TestDto testDto);

        void Update(TestDto testDto);

        void Delete(int Id);
    }
}
