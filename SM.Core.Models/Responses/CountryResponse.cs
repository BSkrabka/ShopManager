using SM.Data.Models;
using SM.Data.Models.Common;

namespace SM.Core.Models.Responses;

public class CountryResponse : BaseResponse
{
    public CountryResponse(Country country) : base(country)
    {
        Name = country.Name;
    }

    public string Name { get; set; }
}