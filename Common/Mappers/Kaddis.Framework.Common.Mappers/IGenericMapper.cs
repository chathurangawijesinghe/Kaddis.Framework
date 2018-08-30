using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaddis.Framework.Common.Mappers
{
    public interface IGenericMapper<S, D> where S : class where D : class
    {
        D ConvertToDto(S s);

        List<D> ConvertToDtos(List<S> s);

        S ConvertToEntity(D d);

        List<S> ConvertToEntities(List<D> d);
    }
}
