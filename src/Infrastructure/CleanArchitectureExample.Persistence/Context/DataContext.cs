using CleanArchitectureExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureExample.Persistence.Context;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<User> Users{ get; set; }
}