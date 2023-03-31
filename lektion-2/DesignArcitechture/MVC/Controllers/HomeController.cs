using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(UserForm form)
        {
            if (ModelState.IsValid)
            { 
                // Save To Database
            }

            return View();
        }
    }
}
