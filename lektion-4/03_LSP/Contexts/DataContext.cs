using _03_LSP.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _03_LSP.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<UserEntity> Users { get; set; }

}
