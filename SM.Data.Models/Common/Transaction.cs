using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;
using SM.Data.Models.Shop;
using TransactionStatus = SM.Data.Models.Enums.TransactionStatus;

namespace SM.Data.Models.Common;

public class Transaction : BaseEntity
{

    [ForeignKey(nameof(User))]
    public Guid BuyerId { get; set; }
    public virtual User User { get; set; }

    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }
    public virtual Product Product { get; set; }

    public int FinalPrice { get; set; }
    public TransactionStatus Status { get; set; }
}