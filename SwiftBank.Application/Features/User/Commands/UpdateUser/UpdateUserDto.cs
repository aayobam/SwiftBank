namespace SwiftBank.Application.Features.User.Commands.UpdateUser;

public class UpdateUserDto
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateOnly DateOfBirth { get; set; }
}
