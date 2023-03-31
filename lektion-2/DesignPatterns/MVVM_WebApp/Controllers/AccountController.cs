using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVVM_WebApp.Contexts;
using MVVM_WebApp.Models.Entities;
using MVVM_WebApp.ViewModels;

namespace MVVM_WebApp.Controllers;


public class AccountController : Controller
{
    private readonly DataContext _context;

    public AccountController(DataContext context)
    {
        _context = context;
    }

    public IActionResult Register()
    {
        var viewModel = new RegisterViewModel();
        return View(viewModel);
    }


    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            if(!await _context.Users.AnyAsync(x => x.Email == viewModel.Email))
            {
                UserEntity userEntity = viewModel;
                _context.Add(userEntity);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Account");
            }

            ModelState.AddModelError("", "Det finns redan en användare med samma e-postadress");
        }

        return View(viewModel);
    }















    public IActionResult Index()
    {
        ViewData["Title"] = "Mitt konto";
        return View();
    }
}
