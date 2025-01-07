using System.ComponentModel.DataAnnotations.Schema;

namespace SM.Data.Models.Common;

public class User : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public double Points { get; set; }

    [ForeignKey(nameof(Country))]
    public Guid CountryId { get; set; }
    public virtual Country Country { get; set; }
}