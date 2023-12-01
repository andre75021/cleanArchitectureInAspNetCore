using CleanArchitectureExample.Domain.Common;

namespace CleanArchitectureExample.Domain.Entities;

public class User : BaseEntity
{
    public string Email { get; set; }
    public string Name { get; set; }
}