using SM.Data.Models.Common;
using SM.Data.Models.Enums;

namespace SM.Core.Models.Responses;

public class TransactionResponse : BaseResponse
{
    public TransactionResponse(Transaction transaction) : base(transaction)
    {
        BuyerId = transaction.BuyerId;
        ProductId = transaction.ProductId;
        FinalPrice = transaction.FinalPrice;
        Status = transaction.Status;
    }

    public Guid BuyerId { get; set; }
    public Guid ProductId { get; set; }
    public int FinalPrice { get; set; }
    public TransactionStatus Status { get; set; }
}