using _01_SRP.Factories;
using _01_SRP.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace _01_SRP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create()
        {
            var user = UserResponseFactory.Create();

            return Created("", user);
        }
    }
}
