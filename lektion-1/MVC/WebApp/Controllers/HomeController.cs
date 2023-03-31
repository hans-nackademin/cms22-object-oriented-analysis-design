using Microsoft.AspNetCore.Mvc;
using WebApp.Library.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var company = new Company { CompanyName = "Nackademin", Email = "info@nackademin.se" };

            ViewData["Title"] = "Home";
            TempData["SubTitle"] = "Dashboard";

            ViewBag.Title = "Home";
            ViewBag.Company = company;

            return View(company);
        }
    }
}
