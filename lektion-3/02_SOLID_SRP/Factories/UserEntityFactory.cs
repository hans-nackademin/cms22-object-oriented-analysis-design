using _02_SOLID_SRP.Models.Entities;

namespace _02_SOLID_SRP.Factories;

internal class UserEntityFactory
{
    public static UserEntity Create()
    {
        return new UserEntity(); 
    }

    public static UserEntity Create(string email)
    {
        return new UserEntity() { 
            UserName = email,
            Email = email 
        };
    }
}
