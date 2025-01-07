using SM.Core.Models.Requests;
using SM.Core.Models.Responses;

namespace SM.Core.Services.Interfaces;

public interface IProductService : IBaseService<ProductRequest, ProductResponse>
{
    Task<ProductResponse> GetAsync(Guid id, Guid userId);
}