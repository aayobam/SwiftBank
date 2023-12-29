using AutoMapper;
using MediatR;
using SwiftBank.Application.Contracts.Persistence;
using SwiftBank.Application.Exceptions;
using SwiftBank.Application.Features.User.Queries.GetAllUsers;

namespace SwiftBank.Application.Features.User.Queries.GetUserDetails;

public class GetUserDetailsQueryHandler : IRequestHandler<GetUserDetailsQuery, UserDto>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public GetUserDetailsQueryHandler(IMapper mapper, IUserRepository userRepository)
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }
    
    public async Task<UserDto> Handle(GetUserDetailsQuery request, CancellationToken cancellationToken)
    {
        var userDetail = await _userRepository.GetByIdAsync(request.Id);
        if (userDetail == null)
        {
            throw new NotFoundException(nameof(Domain.Entities.User), request.Id);
        }
        var data = _mapper.Map<UserDto>(userDetail);
        return data;
    }
}
