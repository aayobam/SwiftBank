using AutoMapper;
using MediatR;
using SwiftBank.Application.Contracts.Persistence;
using SwiftBank.Application.Exceptions;
using SwiftBank.Application.Features.User.Queries.GetAllUsers;

namespace SwiftBank.Application.Features.User.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserDto>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public CreateUserCommandHandler(IMapper mapper, IUserRepository userRepository)
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }

    public async Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateUserCommandValidator(_userRepository);
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Any())
        {
            throw new BadRequestException("invalid user data.", validationResult);
        }
        var userDomain = _mapper.Map<Domain.Entities.User>(request);
        var user = await _userRepository.CreateAsync(userDomain);
        var data = _mapper.Map<UserDto>(user);
        return data;
    }
}
