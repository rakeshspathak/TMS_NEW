using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TMS.Repository.Interface
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity GetById(object id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
