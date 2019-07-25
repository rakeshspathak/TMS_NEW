using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TMS.Repository.Interface;

namespace TMS.Dependency.Business
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly SqlDatabase sqlDatabase;

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(object id)
        {
            //return context.Set<TEntity>().Find(id);

            //return sqlDatabase.ExecuteSprocAccessor<TEntity>("");
            return null;

        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }


        //public Repository(TmsContext Context)
        //{
        //    context = Context;
        //}
        //public void Add(TEntity entity)
        //{
        //    context.Set<TEntity>().Add(entity);
        //}

        //public void AddRange(IEnumerable<TEntity> entities)
        //{
        //    context.Set<TEntity>().AddRange(entities);
        //}

        //public void Dispose()
        //{
        //    //if (Dispose != null)
        //    context.Dispose();
        //}

        //public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        //{
        //    return context.Set<TEntity>().Where(predicate);
        //}

        //public IEnumerable<TEntity> GetAll()
        //{
        //    return context.Set<TEntity>().ToList();
        //}

        //public TEntity GetById(object id)
        //{
        //    return context.Set<TEntity>().Find(id);
        //    //return null;
        //}

        //public void Remove(TEntity entity)
        //{
        //    context.Set<TEntity>().Remove(entity);
        //}

        //public void RemoveRange(IEnumerable<TEntity> entities)
        //{
        //    context.Set<TEntity>().RemoveRange(entities);
        //}
    }
}
