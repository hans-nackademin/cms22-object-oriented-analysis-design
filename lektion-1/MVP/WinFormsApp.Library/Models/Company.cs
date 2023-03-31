using WinFormsApp.Library.Interfaces;

namespace WinFormsApp.Library.Models;

public class Company : ICompany
{
    public string CompanyName { get; set; } = null!;
    public string Email { get; set; } = null!;
}
