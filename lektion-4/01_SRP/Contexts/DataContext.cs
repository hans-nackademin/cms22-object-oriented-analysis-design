using _01_SRP.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _01_SRP.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<UserEntity> Users { get; set; }

}
