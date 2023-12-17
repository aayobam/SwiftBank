using SwiftBankApi.Domain.Common;

namespace SwiftBankApi.Application.Features.User.Queries.User.GetAllUsers;

public class UserDto: BaseClass
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateOnly Dob { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; } = null!;
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
}