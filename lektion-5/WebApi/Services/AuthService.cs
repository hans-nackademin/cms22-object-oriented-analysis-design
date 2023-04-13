using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApi.Contexts;
using WebApi.Models.DTO;
using WebApi.Models.Entities;
using WebApi.Repositories;

namespace WebApi.Services;

public class AuthService
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly UserProfileRepository _userProfileRepository;

    public AuthService(UserManager<IdentityUser> userManager, UserProfileRepository userProfileRepository)
    {
        _userManager = userManager;
        _userProfileRepository = userProfileRepository;
    }

    public async Task<bool> AccountExistsAsync(string email)
    {
        return await _userManager.Users.AnyAsync(x => x.Email == email);
    }

    public async Task<bool> CreateAccountAsync(SignUpModel model)
    {
        if (!await AccountExistsAsync(model.Email))
        {
            IdentityUser identityUser = model;

            var result = await _userManager.CreateAsync(identityUser, model.Password);
            if (result.Succeeded)
            {
                UserProfileEntity userProfileEntity = model;
                userProfileEntity.UserId = identityUser.Id;

                if (await _userProfileRepository.CreateUserProfileAsync(userProfileEntity))
                    return true;
            }       
        }

        return false;
    }
}
