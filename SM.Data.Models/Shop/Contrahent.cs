namespace SM.Data.Models.Shop;

public class Contrahent : BaseEntity
{
    public string Name { get; set; } = null!;
    public double Margin { get; set; }
}
