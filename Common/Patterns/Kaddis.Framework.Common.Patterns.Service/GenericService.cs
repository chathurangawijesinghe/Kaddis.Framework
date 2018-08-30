using Kaddis.Framework.Common.Mappers;
using Kaddis.Framework.Common.Patterns.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaddis.Framework.Common.Patterns.Repository
{
    public class GenericService<D, E> : IGenericService<D> 
        where D : class 
        where E : class
    {
        private IGenericRepository<E> repository;

        private IGenericMapper<E, D> mapper;

        public GenericService(IGenericRepository<E> repository, IGenericMapper<E, D> mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void Delete(object Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<D> GetAll()
        {
            return mapper.ConvertToDtos(this.repository.GetAll().ToList());
        }

        public D GetById(object Id)
        {
            return mapper.ConvertToDto(this.repository.GetById(Id));
        }

        public D Insert(D obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public D Update(D obj)
        {
            throw new NotImplementedException();
        }
    }
}
