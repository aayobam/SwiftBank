using MediatR;

namespace SwiftBankApi.Application.Features.User.Queries.User.GetAllUsers;

public class GetUsersQueryHandler: IRequestHandler<GetUsersQuery, List<UserDto>>
{
    public async Task<List<UserDto>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}