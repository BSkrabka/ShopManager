using SM.Data.Context;
using SM.Data.Models.Common;
using SM.Data.Repositories.Interfaces;

namespace SM.Data.Repositories;

public class CountryRepository : BaseRepository<Country>, ICountryRepository
{
    public CountryRepository(SMDbContext context) : base(context)
    {
    }

    public override async Task<Country> GetAsyncExtended(Guid id)
    {
        throw new NotImplementedException();
    }
}