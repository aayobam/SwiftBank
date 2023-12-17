using MediatR;

namespace SwiftBankApi.Application.Features.User.Queries.User.GetAllUsers;

public record GetUsersQuery : IRequest<List<UserDto>>
{
     
}