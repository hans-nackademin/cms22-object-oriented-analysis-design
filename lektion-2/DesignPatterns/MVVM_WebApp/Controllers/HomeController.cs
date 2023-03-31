using Microsoft.AspNetCore.Mvc;

namespace MVVM_WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
