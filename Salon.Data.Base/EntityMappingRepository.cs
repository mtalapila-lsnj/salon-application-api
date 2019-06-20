using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Salon.Data.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Salon.Data.Base
{
    public abstract class EntityMappingRepository<TEntity, TDomain>: IEntityMappingRepository<TEntity, TDomain>
        where TDomain: AbstractDomainEntity
        where TEntity: AbstractDataEntity
    {
        protected readonly IMapper _mapper;
        protected readonly DbContext _context;
        public EntityMappingRepository(DbContext dbContext, IMapper mapper)
        {
            _context = dbContext;
            _mapper = mapper;
        }

        protected virtual TDomain MapFrom(TEntity entity)
        {
            return _mapper.Map<TDomain>(entity);
        }

        protected virtual TEntity MapTo(TDomain domain)
        {
            return _mapper.Map<TEntity>(domain);
        }                

        
        
        public IEnumerable<TDomain> Get(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Where(expression).ToList().Select(x => MapFrom(x));
        }

        public TDomain Get(object key)
        {
            var entity = _context.Set<TEntity>().Find(key);
            return MapFrom(entity);
        }

        public TEntity Add(TDomain domain)
        {
            var entity = _context.Add(MapTo(domain));
            return entity.Entity;
        }

        public void Update(TDomain domain)
        {
            _context.Set<TEntity>().Update(MapTo(domain));
        }

        public void Delete(TDomain domain)
        {
            _context.Set<TEntity>().Remove(MapTo(domain));
        }
    }
}
