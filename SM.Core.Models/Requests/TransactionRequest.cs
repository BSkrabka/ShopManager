using SM.Data.Models.Enums;

namespace SM.Core.Models.Requests;

public class TransactionRequest
{
    public Guid BuyerId { get; set; }
    public Guid ProductId { get; set; }
    public int FinalPrice { get; set; }
    public TransactionStatus Status { get; set; }
}