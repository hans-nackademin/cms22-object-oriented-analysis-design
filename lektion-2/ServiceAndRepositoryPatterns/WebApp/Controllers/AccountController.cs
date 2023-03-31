using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserService _userService;

        public AccountController(UserService userService)
        {
            _userService = userService;
        }



        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.CreateAsync(viewModel);
                if (result != null)
                    return RedirectToAction("Index", "Home");

                ModelState.AddModelError("", "Det finns redan en användare med samma e-postadress");
            }

            return View(viewModel);
        }







        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
