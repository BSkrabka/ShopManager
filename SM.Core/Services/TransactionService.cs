using SM.Core.Models.Requests;
using SM.Core.Models.Responses;
using SM.Core.Services.Interfaces;
using SM.Data.Models.Common;
using SM.Data.Repositories.Interfaces;

namespace SM.Core.Services;

public class TransactionService : BaseService<Transaction, TransactionRequest, TransactionResponse>, ITransactionService
{
    public TransactionService(ITransactionRepository repository) : base(repository)
    {
    }

    protected override Transaction MapToEntity(TransactionRequest request)
    {
        return new Transaction
        {
            BuyerId = request.BuyerId,
            ProductId = request.ProductId,
            FinalPrice = request.FinalPrice,
            Status = request.Status,
        };
    }

    protected override TransactionResponse MapToResponse(Transaction entity)
    {
        return new TransactionResponse(entity);
    }
}