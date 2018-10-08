using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BaseApiCore.Repository
{
   public class Repository<T> : IRepository<T> where T:class
    {
        private readonly IDbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public Repository(IDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            T existing = _dbContext.Set<T>().Find(entity);
            if (existing != null) _dbContext.Set<T>().Remove(existing);
        }

        public IEnumerable<T> Get()
        {
            return _dbContext.Set<T>().AsEnumerable<T>();
        }

        public IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate).AsEnumerable<T>();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.Set<T>().Attach(entity);
        }
    }
}
