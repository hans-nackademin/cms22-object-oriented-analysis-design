using _01_SRP.Factories;
using _01_SRP.Models.DTOs;
using System.Security.Cryptography;
using System.Text;

namespace _01_SRP.Models.Entities;

public class UserEntity : User
{
    public Guid Id { get; set; } 
    public byte[] PasswordHash { get; private set; }
    public string SecurityStamp { get; set; }
    public byte[] SecurityKey { get; private set; }

    public static implicit operator UserResponse(UserEntity entity)
    {
        var res = UserResponseFactory.Create();
        
        res.Id = entity.Id;
        res.FirstName = entity.FirstName;
        res.LastName = entity.LastName;
        res.Email = entity.Email;

        return res;
    }

    public void GenerateSecurePassword(string password)
    {
        using var hmac = (HMACSHA512)HmacFactory.Create();
        SecurityKey = hmac.Key;
        PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }
}
