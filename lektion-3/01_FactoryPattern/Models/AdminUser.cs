using _01_FactoryPattern.Interfaces;

namespace _01_FactoryPattern.Models;

internal class AdminUser : IUser
{
    public int AdminNumber { get; set; }
}
