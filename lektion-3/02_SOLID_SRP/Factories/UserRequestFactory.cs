using _02_SOLID_SRP.Models;

namespace _02_SOLID_SRP.Factories;

internal class UserRequestFactory
{
    public static UserRequest Create()
    {
        return new UserRequest();
    }
}
