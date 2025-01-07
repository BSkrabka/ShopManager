using SM.Core.Models.Requests;
using SM.Core.Models.Responses;
using SM.Core.Services.Interfaces;
using SM.Data.Models.Common;
using SM.Data.Repositories.Interfaces;

namespace SM.Core.Services;

public class CountryService : BaseService<Country, CountryRequest, CountryResponse>, ICountryService
{
    public CountryService(ICountryRepository repository) : base(repository)
    {
    }

    protected override Country MapToEntity(CountryRequest request)
    {
        return new Country
        {
            Name = request.Name
        };
    }

    protected override CountryResponse MapToResponse(Country entity)
    {
        return new CountryResponse(entity);
    }
}