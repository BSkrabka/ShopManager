using SM.Data.Models;

namespace SM.Core.Models.Responses;

public abstract class BaseResponse
{
    protected BaseResponse(BaseEntity baseEntity)
    {
        Id = baseEntity.Id;
        CreatedAt = baseEntity.CreatedAt;
        ModifiedAt = baseEntity.ModifiedAt;
        DeletedAt = baseEntity.DeletedAt;
    }

    public Guid Id { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}