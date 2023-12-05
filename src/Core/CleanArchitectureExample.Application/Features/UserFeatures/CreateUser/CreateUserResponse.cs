using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitectureExample.Application.Features.UserFeatures.CreateUser
{
    public sealed record CreateUserResponse
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}