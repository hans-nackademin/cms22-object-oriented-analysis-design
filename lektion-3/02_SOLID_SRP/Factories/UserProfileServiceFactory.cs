using _02_SOLID_SRP.Services;

namespace _02_SOLID_SRP.Factories;

internal class UserProfileServiceFactory
{
    public static UserProfileService Create()
    {
        return new UserProfileService();
    }
}
