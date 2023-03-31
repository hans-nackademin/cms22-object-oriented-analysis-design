using Microsoft.EntityFrameworkCore;
using MVVM_WebApp.Models.Entities;

namespace MVVM_WebApp.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<UserEntity> Users { get; set; }
}
