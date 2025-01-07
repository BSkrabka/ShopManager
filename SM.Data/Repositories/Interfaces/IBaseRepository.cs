using SM.Data.Models;
using System.Linq.Expressions;

namespace SM.Data.Repositories.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false);
    Task<TEntity> GetAsyncExtended(Guid id);
    Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, bool asNoTracking = false);
    Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate);
    Task AddAndSaveAsync(TEntity entity);
    Task AddRangeAndSaveAsync(ICollection<TEntity> entities);
    Task UpdateAndSaveAsync(TEntity entity);
    Task UpdateRangeAndSaveAsync(ICollection<TEntity> entities);
    Task DeleteAndSaveAsync(TEntity entity);
    Task DeleteRangeAndSaveAsync(ICollection<TEntity> entities);
    Task SaveChangesAsync();
}