using WpfApp.Library.Interfaces;

namespace WpfApp.Library.Models;

public class Company : ICompany
{
    public string CompanyName { get; set; } = null!;
    public string Email { get; set; } = null!;
}
