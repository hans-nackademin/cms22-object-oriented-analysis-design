using _05_DIP.Interfaces;
using _05_DIP.Models.BaseModels;

namespace _05_DIP.Models.Dtos
{
    public class UserResponse : User, IUserResponse
    {
        public int Id { get; set; }
    }
}
