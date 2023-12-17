using SwiftBank.Domain.Entities.Common;

namespace SwiftBank.Application.Features.User.Queries.GetAllUsers;

public class UserDto: BaseEntity
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateOnly DateOfBirth { get; set; }
}
