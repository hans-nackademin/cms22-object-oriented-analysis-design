
using _05_DIP.Models.Dtos;
using _05_DIP.Models.Entities;

namespace _05_DIP.Factories
{
    public class UserFactory
    {
        public static UserEntity CreateUserEntity() => new();
        public static UserRequest CreateUserRequest() => new();
        public static UserResponse CreateUserResponse() => new();

    }
}
