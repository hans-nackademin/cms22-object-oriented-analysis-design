using _02_SOLID_SRP.Factories;
using _02_SOLID_SRP.Models;
using _02_SOLID_SRP.Models.Entities;
using _02_SOLID_SRP.Repositories;

namespace _02_SOLID_SRP.Services;

internal class UserService
{
    private readonly UserRepository userRepository = UserRepositoryFactory.Create();

    public UserEntity Create(UserRequest userRequest) 
    {
        UserEntity userEntity = userRequest;

        // skapa i databasen
        userRepository.Create(userEntity);

        return userEntity;
    }
}
