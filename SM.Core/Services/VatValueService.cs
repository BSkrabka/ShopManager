using SM.Core.Models.Requests;
using SM.Core.Models.Responses;
using SM.Core.Services.Interfaces;
using SM.Data.Models.Common;
using SM.Data.Repositories.Interfaces;

namespace SM.Core.Services;

public class VatValueService : BaseService<VatValue, VatValueRequest, VatValueResponse>, IVatValueService
{
    public VatValueService(IVatValueRepository repository) : base(repository)
    {
    }

    protected override VatValue MapToEntity(VatValueRequest request)
    {
        return new VatValue
        {
            Value = request.Value,
            CountryId = request.CountryId
        };
    }

    protected override VatValueResponse MapToResponse(VatValue entity)
    {
        return new VatValueResponse(entity);
    }
}