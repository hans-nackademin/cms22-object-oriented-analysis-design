using _02_SOLID_SRP.Factories;
using _02_SOLID_SRP.Models.Entities;

namespace _02_SOLID_SRP.Models;

internal class UserRequest
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;

    public static implicit operator UserEntity(UserRequest user)
    {
        var userEntity = UserEntityFactory.Create(user.Email);
        userEntity.GeneratePassword(user.Password);
        return userEntity;
    }

    public static implicit operator UserProfileEntity(UserRequest user) 
    {
        var userProfileEntity = UserProfileEntityFactory.Create();
        userProfileEntity.FirstName = user.FirstName;
        userProfileEntity.LastName = user.LastName;

        return userProfileEntity;
    }
}
