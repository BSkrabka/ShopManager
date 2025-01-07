using System.ComponentModel.DataAnnotations.Schema;

namespace SM.Data.Models.Shop;

public class Product : BaseEntity
{
    public string Name { get; set; } = null!;
    public double Price { get; set; }

    [ForeignKey(nameof(ProductCategory))]
    public Guid ProductCategoryId { get; set; }
    public virtual ProductCategory ProductCategory { get; set; }

    [ForeignKey(nameof(Contrahent))]
    public Guid ContrahentId { get; set; }
    public virtual Contrahent Contrahent { get; set; }
}