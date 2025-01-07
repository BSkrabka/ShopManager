namespace SM.Core.Models.Requests;

public class ProductRequest
{
    public string Name { get; set; } = null!;
    public double Price { get; set; }
    public Guid ProductCategoryId { get; set; }
    public Guid ContrahentId { get; set; }
}