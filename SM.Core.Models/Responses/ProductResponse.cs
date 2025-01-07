using SM.Data.Models.Shop;

namespace SM.Core.Models.Responses;

public class ProductResponse : BaseResponse
{
    public ProductResponse(Product product, double clientPrice) : base(product)
    {
        Name = product.Name;
        BasePrice = product.Price;
        ClientPrice = clientPrice;
        ProductCategoryId = product.ProductCategoryId;
        ContrahentId = product.ContrahentId;
    }

    public string Name { get; set; } = null!;
    public double BasePrice { get; set; }
    public double ClientPrice { get; set; }
    public Guid ProductCategoryId { get; set; }
    public Guid ContrahentId { get; set; }
}