using AutoMapper;
using MediatR;
using SwiftBank.Application.Contracts.Persistence;

namespace SwiftBank.Application.Features.User.Queries.GetAllUsers;

public class GellAllUsersQueryHandler: IRequestHandler<GetAllUsersQuery, List<UserDto>>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public GellAllUsersQueryHandler(IMapper mapper, IUserRepository userRepository)
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }
    
    public async Task<List<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
