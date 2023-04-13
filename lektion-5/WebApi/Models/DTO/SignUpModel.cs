using Microsoft.AspNetCore.Identity;
using WebApi.Models.Entities;

namespace WebApi.Models.DTO;

public class SignUpModel
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    public string? StreetName { get; set; }
    public string? PostalCode { get; set; }
    public string? City { get; set; }

    public static implicit operator IdentityUser(SignUpModel model)
    {
        return new IdentityUser
        {
            Email = model.Email,
            UserName = model.Email,
            PhoneNumber = model.PhoneNumber
        };
    }

    public static implicit operator UserProfileEntity(SignUpModel model)
    {
        return new UserProfileEntity
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            StreetName = model.StreetName,
            PostalCode = model.PostalCode,
            City = model.City
        };
    }
}
