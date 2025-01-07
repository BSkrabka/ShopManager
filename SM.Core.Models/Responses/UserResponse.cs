using SM.Data.Models;
using SM.Data.Models.Common;

namespace SM.Core.Models.Responses;

public class UserResponse : BaseResponse
{
    public UserResponse(User user) : base(user)
    {
        Name = user.Name;
        Surname = user.Surname;
        Points = user.Points;
        CountryId = user.CountryId;
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public double Points { get; set; }
    public Guid CountryId { get; set; }
}