using Domain.Entities;
using System.Linq.Expressions;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        Task<T?> GetByIdAsync(Guid id);
        IAsyncEnumerable<T> GetAllAsync();
        IAsyncEnumerable<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
    }
}
