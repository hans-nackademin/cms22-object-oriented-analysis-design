using _01_SRP.Models.Entities;

namespace _01_SRP.Factories;

public class UserEntityFactory
{
    public static UserEntity Create()
    {
        return new UserEntity()
        {
            Id = Guid.NewGuid(),
            SecurityStamp = Guid.NewGuid().ToString()
        };
    }
}
