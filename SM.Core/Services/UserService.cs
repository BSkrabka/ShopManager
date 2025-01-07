using SM.Core.Models.Requests;
using SM.Core.Models.Responses;
using SM.Core.Services.Interfaces;
using SM.Data.Models.Common;
using SM.Data.Repositories.Interfaces;

namespace SM.Core.Services;

public class UserService : BaseService<User, UserRequest, UserResponse>, IUserService
{
    public UserService(IUserRepository repository) : base(repository)
    {
    }

    protected override User MapToEntity(UserRequest request)
    {
        return new User
        {
            Name = request.Name,
            Surname = request.Surname,
            CountryId = request.CountryId
        };
    }

    protected override UserResponse MapToResponse(User entity)
    {
        return new UserResponse(entity);
    }
}