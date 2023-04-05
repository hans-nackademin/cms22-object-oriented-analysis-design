using _02_SOLID_SRP.Services;

namespace _02_SOLID_SRP.Factories;

internal class UserServiceFactory
{
    public static UserService Create()
    {
        return new UserService();
    }
}
