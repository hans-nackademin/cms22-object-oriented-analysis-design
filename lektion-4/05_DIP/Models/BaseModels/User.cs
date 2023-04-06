using _05_DIP.Interfaces;

namespace _05_DIP.Models.BaseModels
{
    public abstract class User : IUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
