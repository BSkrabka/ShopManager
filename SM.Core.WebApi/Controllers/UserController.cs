using Microsoft.AspNetCore.Mvc;
using SM.Api.Controllers;
using SM.Core.Models.Requests;
using SM.Core.Models.Responses;
using SM.Core.Services.Interfaces;
using SM.Data.Models.Common;

namespace SM.Core.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : BaseController<UserRequest, UserResponse>
    {
        public UserController(IUserService userService) : base(userService)
        {
        }
    }
}
