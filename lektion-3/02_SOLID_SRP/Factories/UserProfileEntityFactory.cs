using _02_SOLID_SRP.Models.Entities;

namespace _02_SOLID_SRP.Factories;

internal class UserProfileEntityFactory
{
    public static UserProfileEntity Create()
    {
        return new UserProfileEntity();
    }
}
