using WebApp.Contexts;
using WebApp.Models;

namespace WebApp.Repositories;

public class UserProfileRepository : GenericRepository<UserProfileEntity>
{
    public UserProfileRepository(IdentityContext identity) : base(identity)
    {
    }
}
