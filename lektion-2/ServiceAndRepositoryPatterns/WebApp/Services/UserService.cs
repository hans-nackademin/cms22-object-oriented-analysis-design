using WebApp.Models;
using WebApp.Repositories;
using WebApp.ViewModels;

namespace WebApp.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepo;
        private readonly UserProfileRepository _userProfileRepo;

        public UserService(UserRepository userRepo, UserProfileRepository userProfileRepo)
        {
            _userRepo = userRepo;
            _userProfileRepo = userProfileRepo;
        }

        public async Task<CustomIdentityUser> CreateAsync(RegisterViewModel viewModel)
        {
            var user = await _userRepo.GetAsync(x => x.Email == viewModel.Email);
            if (user == null)
            {
                UserProfileEntity userProfileEntity = viewModel;
                userProfileEntity = await _userProfileRepo.CreateAsync(userProfileEntity);

                CustomIdentityUser customIdentityUser = viewModel;
                customIdentityUser.ProfileId = userProfileEntity.Id;

                return await _userRepo.CreateAsync(customIdentityUser);
            }

            return null!;
        }
    }
}
