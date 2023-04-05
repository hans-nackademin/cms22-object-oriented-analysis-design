using _02_SOLID_SRP.Models.Entities;

namespace _02_SOLID_SRP.Repositories;

internal class UserRepository
{
    public UserEntity Create(UserEntity userEntity)
    {
        // _context.Add(userEntity);
        // _context.SaveChanges();

        return userEntity;
    }
}
