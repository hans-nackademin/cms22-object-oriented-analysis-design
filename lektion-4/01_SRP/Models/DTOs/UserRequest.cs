using _01_SRP.Factories;
using _01_SRP.Models.Entities;

namespace _01_SRP.Models.DTOs;

public class UserRequest : User
{
    public string Password { get; set; }

    public static implicit operator UserEntity(UserRequest req)
    {
        var entity =  UserEntityFactory.Create();

        entity.FirstName = req.FirstName;
        entity.LastName = req.LastName;
        entity.Email = req.Email;
        entity.GenerateSecurePassword(req.Password);

        return entity;

    }
}
