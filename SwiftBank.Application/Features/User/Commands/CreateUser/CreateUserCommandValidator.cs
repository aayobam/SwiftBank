using FluentValidation;
using SwiftBank.Application.Contracts.Persistence;

namespace SwiftBank.Application.Features.User.Commands.CreateUser;

public class CreateUserCommandValidator: AbstractValidator<CreateUserCommand>
{
    private readonly IUserRepository _userRepository;

    public CreateUserCommandValidator(IUserRepository userRepository)
    {
        _userRepository = userRepository;
        
        RuleFor(p => p.FirstName)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(100).WithMessage("{PropertyName} cannot be greater than 100.");
        
        RuleFor(p => p.LastName)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(100).WithMessage("{PropertyName} cannot be greater than 100.");
        
        RuleFor(p => p)
            .MustAsync(UserEmailUnique).WithMessage("user already exists.");
    }

    private Task<bool> UserEmailUnique(CreateUserCommand command, CancellationToken token)
    {
        return _userRepository.IsUserEmailUnique(command.EmailAddress);
    }
}
