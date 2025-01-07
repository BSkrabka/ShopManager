using SM.Core.Models.Requests;
using SM.Core.Models.Responses;
using SM.Core.Services.Interfaces;
using SM.Data.Models.Shop;
using SM.Data.Repositories.Interfaces;

namespace SM.Core.Services;

public class ProductCategoryService : BaseService<ProductCategory, ProductCategoryRequest, ProductCategoryResponse>, IProductCategoryService
{
    public ProductCategoryService(IProductCategoryRepository repository) : base(repository)
    {
    }

    protected override ProductCategory MapToEntity(ProductCategoryRequest request)
    {
        return new ProductCategory
        {
            Name = request.Name
        };
    }

    protected override ProductCategoryResponse MapToResponse(ProductCategory entity)
    {
        return new ProductCategoryResponse(entity);
    }
}