namespace SM.Core.Models.Requests;

public class UserRequest
{
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;

    public Guid CountryId { get; set; }
}