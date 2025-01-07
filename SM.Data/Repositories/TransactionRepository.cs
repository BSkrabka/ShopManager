using SM.Data.Context;
using SM.Data.Models.Common;
using SM.Data.Repositories.Interfaces;

namespace SM.Data.Repositories;

public class TransactionRepository : BaseRepository<Transaction>, ITransactionRepository
{
    public TransactionRepository(SMDbContext context) : base(context)
    {
    }

    public override async Task<Transaction> GetAsyncExtended(Guid id)
    {
        throw new NotImplementedException();
    }
}