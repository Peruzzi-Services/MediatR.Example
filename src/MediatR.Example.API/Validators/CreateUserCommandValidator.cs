using FluentValidation;

namespace MediatR.Example.API.Validators;
using Requests;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(cmd => cmd.User).NotNull();
        RuleFor(cmd => cmd.User.FirstName).NotEmpty();
        RuleFor(cmd => cmd.User.LastName).NotEmpty();
    }
}
