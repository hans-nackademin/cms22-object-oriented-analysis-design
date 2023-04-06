using _03_LSP.Models;
using _03_LSP.Repositories;

namespace _03_LSP.Services;

public class UserService
{
    private readonly UserRepository _userRepo;

    public UserService(UserRepository userRepo)
    {
        _userRepo = userRepo;
    }

    public async Task<IEnumerable<UserResponse>> GetAllAsync()
    {
        var entities = await _userRepo.GetAllAsync();
        List<UserResponse> users = new List<UserResponse>();

        foreach (var entity in entities)
            users.Add(new UserResponse
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email
            });

        return users;
    }
}
