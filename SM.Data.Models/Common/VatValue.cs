using System.ComponentModel.DataAnnotations.Schema;

namespace SM.Data.Models.Common;

public class VatValue : BaseEntity
{
    public int Value { get; set; }

    [ForeignKey(nameof(Country))]
    public Guid CountryId { get; set; }
    public virtual Country Country { get; set; }
}