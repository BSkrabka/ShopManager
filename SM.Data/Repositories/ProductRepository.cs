using Microsoft.EntityFrameworkCore;
using SM.Data.Context;
using SM.Data.Models.Shop;
using SM.Data.Repositories.Interfaces;

namespace SM.Data.Repositories;

public class ProductRepository : BaseRepository<Product>, IProductRepository
{
    public ProductRepository(SMDbContext context) : base(context)
    {
    }

    public override async Task<Product> GetAsyncExtended(Guid id)
    {
        return await Context.Products
            .Include(x => x.ProductCategory)
            .Include(x => x.Contrahent)
            .FirstOrDefaultAsync(x => x.Id == id);
    }
}