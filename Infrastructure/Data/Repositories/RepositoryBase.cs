using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Data.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
        private readonly ITWareDbContext _dbContext;

        public RepositoryBase(ITWareDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<T?> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<T>().FindAsync([id]);
        }

        public IAsyncEnumerable<T> GetAllAsync()
        {
            var result = _dbContext.Set<T>().AsAsyncEnumerable();
            return result;
        }

        public IAsyncEnumerable<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            var result = _dbContext.Set<T>().Where(predicate).AsAsyncEnumerable();
            return result;
        }

        public Task AddAsync(T entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
            return Task.CompletedTask;
        }

        public Task UpdateAsync(T entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
            return Task.CompletedTask;
        }

        public Task DeleteAsync(T entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
