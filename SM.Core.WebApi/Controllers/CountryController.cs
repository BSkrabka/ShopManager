using Microsoft.AspNetCore.Mvc;
using SM.Api.Controllers;
using SM.Core.Models.Requests;
using SM.Core.Models.Responses;
using SM.Core.Services.Interfaces;

namespace SM.Core.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CountryController : BaseController<CountryRequest, CountryResponse>
    {
        public CountryController(ICountryService countryService) : base(countryService)
        {
        }
    }
}
