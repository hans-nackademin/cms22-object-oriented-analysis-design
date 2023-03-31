using Microsoft.AspNetCore.Identity;

namespace WebApp.Models
{
    public class CustomIdentityUser : IdentityUser
    {
        public Guid ProfileId { get; set; }

        public UserProfileEntity Profile { get; set; } = null!;
    }
}
