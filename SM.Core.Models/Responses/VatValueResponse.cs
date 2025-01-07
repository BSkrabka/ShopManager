using SM.Data.Models;
using SM.Data.Models.Common;

namespace SM.Core.Models.Responses;

public class VatValueResponse : BaseResponse
{
    public VatValueResponse(VatValue vatValue) : base(vatValue)
    {
        Value = vatValue.Value;
        CountryId = vatValue.CountryId;
    }

    public int Value { get; set; }
    public Guid CountryId { get; set; }
}