using SM.Data.Context;
using SM.Data.Models.Shop;
using SM.Data.Repositories.Interfaces;

namespace SM.Data.Repositories;

public class ContrahentRepository : BaseRepository<Contrahent>, IContrahentRepository
{
    public ContrahentRepository(SMDbContext context) : base(context)
    {
    }

    public override async Task<Contrahent> GetAsyncExtended(Guid id)
    {
        throw new NotImplementedException();
    }
}