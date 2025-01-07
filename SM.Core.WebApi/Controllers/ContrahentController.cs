using SM.Api.Controllers;
using SM.Core.Models.Requests;
using SM.Core.Models.Responses;
using SM.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SM.Core.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ContrahentController : BaseController<ContrahentRequest, ContrahentResponse>
    {
        public ContrahentController(IContrahentService contrahentService) : base(contrahentService)
        {
        }
    }
}
