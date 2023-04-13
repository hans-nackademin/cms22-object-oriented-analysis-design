using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.DTO;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthenticationController(AuthService authService)
        {
            _authService = authService;
        }

        [Route("SignUp")]
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel model)
        {
            if (ModelState.IsValid)
                if (await _authService.CreateAccountAsync(model))
                    return RedirectToAction("SignIn", model);

            return BadRequest(model);
        }


        [Route("SignIn")]
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }

            return Unauthorized("Incorrect email or password");
        }


        [Route("SignOut")]
        [HttpPost]
        public async Task<IActionResult> SignIn()
        {
            return Ok();
        }
    }
}
