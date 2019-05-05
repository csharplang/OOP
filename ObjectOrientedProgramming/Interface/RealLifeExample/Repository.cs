using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OOP.Interface
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected RepositoryContext _dbContext;

        public Repository(RepositoryContext repositoryContext)
        {
            _dbContext = repositoryContext;
        }


        public async Task<IEnumerable<TEntity>> FindAllAsync()
        {
            return await this._dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> FindByConditionAync(Expression<Func<TEntity, bool>> expression)
        {
            return await this._dbContext.Set<TEntity>().Where(expression).ToListAsync();
        }

        public void Create(TEntity entity)
        {
            this._dbContext.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            this._dbContext.Set<TEntity>().Update(entity);
        }

        public void Delete(TEntity entity)
        {
            this._dbContext.Set<TEntity>().Remove(entity);
        }

        public async Task SaveAsync()
        {
            await this._dbContext.SaveChangesAsync();
        }

    }
}
