using _01_SRP.Contexts;
using _01_SRP.Factories;
using _01_SRP.Models;
using _01_SRP.Models.DTOs;
using _01_SRP.Models.Entities;
using _01_SRP.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _01_SRP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly UserRepository _userRepo;

        public AdminController(UserRepository userRepo)
        {
            _userRepo = userRepo;
        }



        [HttpPost]
        public async Task<IActionResult> Create(UserRequest req)
        {
            if (ModelState.IsValid)
            {
                UserResponse res = await _userRepo.CreateAsync(req);
                if (res != null)
                    return Created("", res);
            }

            return BadRequest();
        }
    }
}
