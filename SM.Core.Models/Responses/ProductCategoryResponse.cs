using SM.Data.Models.Shop;

namespace SM.Core.Models.Responses;

public class ProductCategoryResponse : BaseResponse
{
    public ProductCategoryResponse(ProductCategory productCategory) : base(productCategory)
    {
        Name = productCategory.Name;
    }

    public string Name { get; set; }
}