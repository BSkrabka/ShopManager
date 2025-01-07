namespace SM.Core.Services.Interfaces;

public interface IBaseService<in TRequest, TResponse> where TRequest : class where TResponse : class
{
    Task<Guid> AddAsync(TRequest entity);
    Task UpdateAsync(TRequest entity, Guid id);
    Task RemoveAsync(Guid id);
    Task<TResponse> GetAsync(Guid id);
    Task<List<TResponse>> GetAllAsync();
}