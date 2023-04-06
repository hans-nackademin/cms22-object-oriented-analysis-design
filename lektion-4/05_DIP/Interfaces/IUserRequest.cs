using _05_DIP.Models.Entities;

namespace _05_DIP.Interfaces
{
    public interface IUserRequest : IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
