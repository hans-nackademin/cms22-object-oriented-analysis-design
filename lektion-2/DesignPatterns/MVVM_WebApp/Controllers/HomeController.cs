using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVVM_WebApp.Contexts;
using MVVM_WebApp.Models;

namespace MVVM_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var userEntity = await _context.Users.FindAsync(1)!;
            if (userEntity != null)
            {
                User user = userEntity;
                return View(user);
            }


            return View();
        }
    }
}
