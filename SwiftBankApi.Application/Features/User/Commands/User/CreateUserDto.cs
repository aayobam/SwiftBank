namespace SwiftBankApi.Application.Features.User.Commands.User;

public class CreateUserDto
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateOnly Dob { get; set; }
    public string Gender { get; set; } = string.Empty;
}