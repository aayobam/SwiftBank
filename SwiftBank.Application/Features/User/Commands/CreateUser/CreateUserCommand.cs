using MediatR;
using SwiftBank.Application.Features.User.Queries.GetAllUsers;

namespace SwiftBank.Application.Features.User.Commands.CreateUser;

public class CreateUserCommand : IRequest<UserDto>
{
    public string Id { get; set; } = null!;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
}
