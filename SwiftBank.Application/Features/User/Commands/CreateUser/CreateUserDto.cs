namespace SwiftBank.Application.Features.User.Commands.CreateUser;

public class CreateUserDto
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateOnly DateOfBirth { get; set; }
}
