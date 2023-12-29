using MediatR;
using SwiftBank.Application.Contracts.Persistence;
using SwiftBank.Application.Exceptions;

namespace SwiftBank.Application.Features.User.Commands.DeleteUser;

public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
{
    private readonly IUserRepository _userRepository;

    public DeleteUserCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        var userObj = await _userRepository.GetByIdAsync(request.Id.ToString());
        if (userObj == null)
        {
            throw new NotFoundException(nameof(Domain.Entities.User), request.Id);
        }
        await _userRepository.DeleteAsync(userObj);
        return Unit.Value;
    }
}
