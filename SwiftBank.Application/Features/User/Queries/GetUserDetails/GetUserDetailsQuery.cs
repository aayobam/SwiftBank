using MediatR;
using SwiftBank.Application.Features.User.Queries.GetAllUsers;

namespace SwiftBank.Application.Features.User.Queries.GetUserDetails;

public record GetUserDetailsQuery(string Id) : IRequest<UserDto>;
