using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _02_SOLID_SRP.Models.Entities;

internal class UserProfileEntity
{
    [Key, ForeignKey("User")]
    public int UserId { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    public UserEntity User { get; set; } = null!;
}
