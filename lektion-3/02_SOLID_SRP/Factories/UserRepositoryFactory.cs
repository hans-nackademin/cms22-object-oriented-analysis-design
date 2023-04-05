using _02_SOLID_SRP.Repositories;

namespace _02_SOLID_SRP.Factories;

internal class UserRepositoryFactory
{
    public static UserRepository Create()
    {
        return new UserRepository();
    }
}
