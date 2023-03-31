using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVVM_WebApp.Contexts;
using MVVM_WebApp.Models;
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
            var userEntity = await _context.Users.FirstOrDefaultAsync(x => x.Email == viewModel.Email)!;          
            if (userEntity == null)
            {
                userEntity = viewModel;
                _context.Add(userEntity);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Account");
            }

            ModelState.AddModelError("", "Det finns redan en användare med samma e-postadress");
        }

        return View(viewModel);
    }

    public IActionResult Login()
    {
        var viewModel = new LoginViewModel();
        return View(viewModel);
    }


    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            var userEntity = await _context.Users.FirstOrDefaultAsync(x => x.Email == viewModel.Email)!;
            if (userEntity != null)
            {
                if (userEntity.VerifySecurePassword(viewModel.Password))
                {
                    var session = new LoginSessionEntity
                    {
                        SessionId = Guid.NewGuid(),
                        UserId = userEntity.Id
                    };
                    _context.Add(session);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "Account", new { id = userEntity.Id });
                }
            }            
        }

        ModelState.AddModelError("", "Felaktig e-postadress eller lösenord");

        return View(viewModel);
    }




    public async Task<IActionResult> Index(int id)
    {
        ViewData["Title"] = "Mitt konto";

        var userEntity = await _context.Users.Include(x => x.LoginSessions).FirstOrDefaultAsync(x => x.Id == id)!;
        if (userEntity != null)
        {
            User user = userEntity;
            return View(user);
        }

        return RedirectToAction("Login", "Account");
    }

    public async Task<IActionResult> Logout(int id)
    {
        var userEntity = await _context.Users.FirstOrDefaultAsync(x => x.Id == id)!;
        if (userEntity != null)
        {
            var session = await _context.LoginSessions.FirstOrDefaultAsync(x => x.UserId == userEntity.Id);
            if (session != null)
            {
                _context.Remove(session);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Account", new { id = userEntity!.Id });
        }

        return RedirectToAction("Index", "Home");
    }
}
