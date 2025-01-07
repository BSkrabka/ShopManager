using SM.Core.Models.Responses;
using SM.Core.Services.Interfaces;
using SM.Data.Models;
using SM.Data.Repositories.Interfaces;

namespace SM.Core.Services;

public abstract class BaseService<TEntity, TRequest, TResponse>
    : IBaseService<TRequest, TResponse>
    where TEntity : BaseEntity
    where TRequest : class
    where TResponse : BaseResponse
{
    protected readonly IBaseRepository<TEntity> Repository;

    protected BaseService(IBaseRepository<TEntity> repository)
    {
        Repository = repository;
    }

    protected abstract TEntity MapToEntity(TRequest request);

    protected abstract TResponse MapToResponse(TEntity entity);

    public async Task<Guid> AddAsync(TRequest request)
    {
        var entity = MapToEntity(request);
        await Repository.AddAndSaveAsync(entity);

        return entity.Id;
    }

    public async Task UpdateAsync(TRequest request, Guid id)
    {
        var entity = await Repository.GetAsync(x => x.Id == id);
        if (entity == null)
        {
            throw new KeyNotFoundException("Entity not found");
        }

        var updatedEntity = MapToEntity(request);
        updatedEntity.Id = id;
        await Repository.UpdateAndSaveAsync(updatedEntity);
    }

    public async Task RemoveAsync(Guid id)
    {
        var entity = await Repository.GetAsync(x => x.Id == id);
        if (entity == null)
        {
            throw new KeyNotFoundException("Entity not found");
        }

        await Repository.DeleteAndSaveAsync(entity);
    }

    public virtual async Task<TResponse> GetAsync(Guid id)
    {
        var entity = await Repository.GetAsync(x => x.Id == id, asNoTracking: true);

        if (entity == null)
        {
            throw new KeyNotFoundException("Entity not found");
        }

        return MapToResponse(entity);
    }

    public virtual async Task<List<TResponse>> GetAllAsync()
    {
        var entities = await Repository.GetAllAsync(asNoTracking: true);
        return entities.Select(MapToResponse).ToList();
    }
}
