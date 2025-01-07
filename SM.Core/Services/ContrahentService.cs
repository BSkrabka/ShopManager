using SM.Core.Models.Requests;
using SM.Core.Models.Responses;
using SM.Core.Services.Interfaces;
using SM.Data.Models.Shop;
using SM.Data.Repositories.Interfaces;

namespace SM.Core.Services;

public class ContrahentService : BaseService<Contrahent, ContrahentRequest, ContrahentResponse>, IContrahentService
{
    public ContrahentService(IContrahentRepository repository) : base(repository)
    {
    }

    protected override Contrahent MapToEntity(ContrahentRequest request)
    {
        return new Contrahent
        {
            Name = request.Name,
            Margin = request.Margin
        };
    }

    protected override ContrahentResponse MapToResponse(Contrahent entity)
    {
        return new ContrahentResponse(entity);
    }
}
