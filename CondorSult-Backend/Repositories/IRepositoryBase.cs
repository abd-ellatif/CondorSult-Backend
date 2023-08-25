using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CondorSult_Backend.Repositories
{
    // This is a generic repository for all entities

    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Delete(TEntity entity);



        void SaveChanges();
    }

}
