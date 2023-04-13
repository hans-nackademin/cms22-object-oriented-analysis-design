using WebApi.Contexts;
using WebApi.Models.Entities;

namespace WebApi.Repositories;

public class UserProfileRepository
{
    private readonly IdentityContext _identityContext;

    public UserProfileRepository(IdentityContext identityContext)
    {
        _identityContext = identityContext;
    }

    public async Task<bool> CreateUserProfileAsync(UserProfileEntity userProfileEntity)
    {
        try
        {
            _identityContext.Add(userProfileEntity);
            await _identityContext.SaveChangesAsync();
            return true;
        }
        catch { return false; }
    }

}
