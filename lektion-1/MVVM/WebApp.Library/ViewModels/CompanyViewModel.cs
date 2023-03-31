using System.ComponentModel.DataAnnotations;
using WebApp.Library.Interfaces;
using WebApp.Library.Models;

namespace WebApp.Library.ViewModels;

public class CompanyViewModel : ICompany
{
    [Display(Name = "Company Name")]
    [Required(ErrorMessage = "Company Name is Required")]
    public string CompanyName { get; set; } = null!;

    [Display(Name = "Email")]
    [Required(ErrorMessage = "Email is Required")]
    [EmailAddress]
    public string Email { get;set; } = null!;


    public void Save(CompanyViewModel companyViewModel)
    {
        var company = new Company
        {
            CompanyName = companyViewModel.CompanyName,
            Email = companyViewModel.Email
        };

        // save to database
    }
}
