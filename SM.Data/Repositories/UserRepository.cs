using SM.Data.Context;
using SM.Data.Models.Common;
using SM.Data.Repositories.Interfaces;

namespace SM.Data.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(SMDbContext context) : base(context)
    {
    }

    public override async Task<User> GetAsyncExtended(Guid id)
    {
        throw new NotImplementedException();
    }
}