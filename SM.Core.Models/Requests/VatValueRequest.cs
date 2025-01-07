namespace SM.Core.Models.Requests;

public class VatValueRequest
{
    public int Value { get; set; }
    public Guid CountryId { get; set; }
}