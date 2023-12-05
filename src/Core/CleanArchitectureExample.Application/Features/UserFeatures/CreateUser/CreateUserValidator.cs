using System.Security.Cryptography.X509Certificates;
using FluentValidation;

namespace CleanArchitectureExample.Application.Features.UserFeatures.CreateUser;

public class CreateUserValidator : AbstractValidator<CreateUserRequest>
{
    public CreateUserValidator()
    {
        RuleFor(x => x.email).NotEmpty().MaximumLength(50).EmailAddress();
        RuleFor(x => x.name).NotEmpty().MinimumLength(3).MaximumLength(50);
    }
}