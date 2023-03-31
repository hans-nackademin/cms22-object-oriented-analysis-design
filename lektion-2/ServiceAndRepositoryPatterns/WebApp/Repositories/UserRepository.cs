using WebApp.Contexts;
using WebApp.Models;

namespace WebApp.Repositories;

public class UserRepository : GenericRepository<CustomIdentityUser>
{
    public UserRepository(IdentityContext identity) : base(identity)
    {
    }
}
