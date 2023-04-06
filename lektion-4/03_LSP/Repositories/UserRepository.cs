using _03_LSP.Contexts;
using _03_LSP.Models;
using _03_LSP.Models.Entities;

namespace _03_LSP.Repositories;

public class UserRepository : Repository<UserEntity>
{
    public UserRepository(DataContext context) : base(context)
    {
    }

    public override Task<UserEntity> GetAsync()
    {
        throw new NotImplementedException();
    }
}