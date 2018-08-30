using AutoMapper;
using Kaddis.Framework.Common.Entities;
using Kaddis.Framework.Data.KaddisFrameworkModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaddis.Framework.Common.Mappers.Admin
{
    public class TestMapper : GenericMapper<Test, TestDto>, ITestMapper
    {
    }
}
