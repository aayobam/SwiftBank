using AutoMapper;
using MediatR;
using SwiftBank.Application.Contracts.Persistence;
using SwiftBank.Application.Features.User.Queries.GetAllUsers;

namespace SwiftBank.Application.Features.User.Commands.UpdateUser;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UserDto>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public UpdateUserCommandHandler(IMapper mapper, IUserRepository userRepository)
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }
    
    public async Task<UserDto> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var userDomain = _mapper.Map<Domain.Entities.User>(request);
        var user = await _userRepository.UpdateAsync(userDomain);
        var data = _mapper.Map<UserDto>(user);
        return data;
    }
}
