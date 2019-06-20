using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Salon.Data.Base.Interfaces
{
    public interface IEntityMappingRepository<TEntity, TDomain>
        where TEntity : AbstractDataEntity
        where TDomain: AbstractDomainEntity
    {
        TDomain Get(object key);
        IEnumerable<TDomain> Get(Expression<Func<TEntity, bool>> expression);
        TEntity Add(TDomain domain);
        void Update(TDomain domain);
        void Delete(TDomain domain);
    }
}
