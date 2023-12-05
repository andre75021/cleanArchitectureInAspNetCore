using AutoMapper;
using CleanArchitectureExample.Domain.Entities;

namespace CleanArchitectureExample.Application.Features.UserFeatures.CreateUser;

public class CreateUserMapper : Profile
{
    protected CreateUserMapper()
    {
        CreateMap<CreateUserRequest, User>();
        CreateMap<User, CreateUserResponse>();
    }
}