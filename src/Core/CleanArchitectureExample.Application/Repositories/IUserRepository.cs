using CleanArchitectureExample.Domain.Entities;

namespace CleanArchitectureExample.Application.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User> GetByEmail(string email, CancellationToken cancellationToken);
}