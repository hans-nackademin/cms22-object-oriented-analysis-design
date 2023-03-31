using System.ComponentModel.DataAnnotations;

namespace MVVM_WebApp.Models.Entities;

public class LoginSessionEntity
{
    [Key]
    public Guid SessionId { get; set; }
    public int UserId { get; set; }
    public DateTime IssuedAt { get; set; } = DateTime.Now;
    public DateTime ExpiresAt { get; set; } = DateTime.Now.AddHours(1);

    public UserEntity User { get; set; } = null!;
}
