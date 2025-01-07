using SM.Data.Context;
using SM.Data.Models.Shop;
using SM.Data.Repositories.Interfaces;

namespace SM.Data.Repositories;

public class ProductCategoryRepository : BaseRepository<ProductCategory>, IProductCategoryRepository
{
    public ProductCategoryRepository(SMDbContext context) : base(context)
    {
    }

    public override async Task<ProductCategory> GetAsyncExtended(Guid id)
    {
        throw new NotImplementedException();
    }
}