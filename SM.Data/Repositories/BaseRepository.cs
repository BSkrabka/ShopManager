using Microsoft.EntityFrameworkCore;
using SM.Data.Repositories.Interfaces;
using System.Linq.Expressions;
using SM.Data.Context;
using SM.Data.Models;
using Azure.Core;

namespace SM.Data.Repositories;

public abstract class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : BaseEntity
{
    private bool _disposed = false;
    protected SMDbContext Context;

    protected BaseRepository(SMDbContext context)
    {
        Context = context;
    }

    public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false)
    {
        var query = Context.Set<TEntity>().AsQueryable();

        if (asNoTracking)
        {
            query = query.AsNoTracking();
        }

        return await query.FirstOrDefaultAsync(predicate);
    }

    public abstract Task<TEntity> GetAsyncExtended(Guid id);


    public virtual async Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, bool asNoTracking = false)
    {
        var query = Context.Set<TEntity>().AsQueryable();

        if (asNoTracking)
        {
            query = query.AsNoTracking();
        }
        if (predicate != null)
        {
            query = query.Where(predicate);
        }

        return await query.ToListAsync();
    }

    public virtual async Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate)
    {
        var query = Context.Set<TEntity>().AsQueryable();

        return await query.AnyAsync(predicate);
    }

    public virtual async Task AddAndSaveAsync(TEntity entity)
    {
        Context.Set<TEntity>().Add(entity);
        await SaveChangesAsync();
    }

    public virtual async Task AddRangeAndSaveAsync(ICollection<TEntity> entities)
    {
        Context.Set<TEntity>().AddRange(entities);
        await SaveChangesAsync();
    }

    public virtual async Task UpdateAndSaveAsync(TEntity entity)
    {
        Context.Entry(entity).State = EntityState.Modified;
        await SaveChangesAsync();
    }
    public virtual async Task UpdateRangeAndSaveAsync(ICollection<TEntity> entities)
    {
        Context.Set<TEntity>().UpdateRange(entities);
        await SaveChangesAsync();
    }

    public virtual async Task DeleteAndSaveAsync(TEntity entity)
    {
        Context.Set<TEntity>().Remove(entity);
        await SaveChangesAsync();
    }

    public virtual async Task DeleteRangeAndSaveAsync(ICollection<TEntity> entities)
    {
        Context.Set<TEntity>().RemoveRange(entities);
        await SaveChangesAsync();
    }

    public virtual async Task SaveChangesAsync()
    {
        try
        {
            await Context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
            _disposed = true;
    }
}

