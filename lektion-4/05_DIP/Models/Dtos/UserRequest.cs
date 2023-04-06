using _05_DIP.Factories;
using _05_DIP.Interfaces;
using _05_DIP.Models.BaseModels;
using _05_DIP.Models.Entities;

namespace _05_DIP.Models.Dtos
{
    public class UserRequest : User, IUserRequest
    {
        public string Password { get; set; } = null!;


        public static implicit operator UserEntity(UserRequest userRequest)
        {
            var entity = UserFactory.CreateUserEntity();
            return entity;
        }

    }
}
