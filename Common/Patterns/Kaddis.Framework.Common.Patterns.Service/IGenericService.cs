using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaddis.Framework.Common.Patterns.Repository
{
    public interface IGenericService<D> where D: class
    {
        IEnumerable<D> GetAll();

        D GetById(object Id);

        D Insert(D obj);

        void Delete(object Id);

        D Update(D obj);

        void Save();
    }
}
