using Microsoft.AspNetCore.Mvc;
using WebApp.Library.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly CompanyViewModel _companyViewModel;

        public HomeController(CompanyViewModel companyViewModel)
        {
            _companyViewModel = companyViewModel;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Create");
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(CompanyViewModel companyViewModel)
        {
            if (ModelState.IsValid)
            {
                _companyViewModel.Save(companyViewModel);
                return RedirectToAction("Index", "Home");
            }

            return View(companyViewModel);
        }
    }
}
