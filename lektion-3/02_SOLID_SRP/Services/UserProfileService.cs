using _02_SOLID_SRP.Models.Entities;
using _02_SOLID_SRP.Models;

namespace _02_SOLID_SRP.Services;

internal class UserProfileService
{
    public void Create(UserRequest userRequest, UserEntity userEntity) 
    {
        UserProfileEntity profileEntity = userRequest;
        profileEntity.UserId = userEntity.Id;
    }
}