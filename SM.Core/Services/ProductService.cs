using SM.Core.Models.Requests;
using SM.Core.Models.Responses;
using SM.Core.Services.Interfaces;
using SM.Data.Models.Shop;
using SM.Data.Repositories.Interfaces;
using SM.Lib.Helpers;

namespace SM.Core.Services;

public class ProductService : BaseService<Product, ProductRequest, ProductResponse>, IProductService
{
    private readonly IVatValueRepository _vatValueRepository;
    public ProductService(IProductRepository repository, IVatValueRepository vatValueRepository) : base(repository)
    {
        _vatValueRepository = vatValueRepository;
    }

    protected override Product MapToEntity(ProductRequest request)
    {
        return new Product
        {
            Name = request.Name,
            Price = request.Price,
            ProductCategoryId = request.ProductCategoryId,
            ContrahentId = request.ContrahentId
        };
    }

    protected override ProductResponse MapToResponse(Product entity)
    {
        var clientPrice = PriceCalculator.CalculateClientPrice(entity.Price, entity.Contrahent?.Margin ?? 0.0, 23.0);
        return new ProductResponse(entity, clientPrice);
    }

    public async Task<ProductResponse> GetAsync(Guid id, Guid userId)
    {
        var vat = await _vatValueRepository.GetVatValueByUserIdAsync(userId);
        var result = await Repository.GetAsyncExtended(id);

        if (result == null)
        {
            throw new KeyNotFoundException("Product not found");
        }

        var vatPrice = PriceCalculator.CalculateVatPrice(result.Price, vat.Value);

        var clientPrice = PriceCalculator.CalculateClientPrice(result.Price, result.Contrahent?.Margin ?? 0.0, vatPrice);

        return new ProductResponse(result, clientPrice);
    }
}