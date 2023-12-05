using MediatR;

namespace CleanArchitectureExample.Application.Features.UserFeatures.CreateUser;
public sealed record CreateUserRequest(string email, string name) : IRequest<CreateUserResponse>;    