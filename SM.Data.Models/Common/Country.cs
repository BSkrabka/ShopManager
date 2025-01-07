namespace SM.Data.Models.Common;

public class Country : BaseEntity
{
    public string Name { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; }
}