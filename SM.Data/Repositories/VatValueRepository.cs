using Microsoft.EntityFrameworkCore;
using SM.Data.Context;
using SM.Data.Models.Common;
using SM.Data.Repositories.Interfaces;

namespace SM.Data.Repositories;

public class VatValueRepository : BaseRepository<VatValue>, IVatValueRepository
{
    public VatValueRepository(SMDbContext context) : base(context)
    {
    }

    public override async Task<VatValue> GetAsyncExtended(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<VatValue> GetVatValueByUserIdAsync(Guid userId)
    {
        return await Context.VatValues.FirstOrDefaultAsync(x => x.Country.Users.Any(u => u.Id== userId));
    }
}