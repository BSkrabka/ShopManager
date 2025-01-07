using SM.Data.Models.Common;

namespace SM.Data.Repositories.Interfaces;

public interface IVatValueRepository : IBaseRepository<VatValue>
{
    Task<VatValue> GetVatValueByUserIdAsync(Guid userId);
}