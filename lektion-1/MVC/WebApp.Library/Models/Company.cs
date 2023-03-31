using WebApp.Library.Interfaces;

namespace WebApp.Library.Models;

public class Company : ICompany
{
    public string CompanyName { get; set; } = null!;
    public string Email { get; set; } = null!;
}
