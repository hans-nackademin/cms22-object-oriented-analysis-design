
using _02_SOLID_SRP.Factories;

var userService = UserServiceFactory.Create();
var userProfileService = UserProfileServiceFactory.Create();
var userRequest = UserRequestFactory.Create();

userRequest.FirstName = "Hans";
userRequest.LastName = "Mattin-Lassei";
userRequest.Email = "hans@domain.com";

userProfileService.Create(userRequest, userService.Create(userRequest));
