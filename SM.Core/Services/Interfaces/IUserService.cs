using SM.Core.Models.Requests;
using SM.Core.Models.Responses;

namespace SM.Core.Services.Interfaces;

public interface IUserService : IBaseService<UserRequest, UserResponse>
{
}