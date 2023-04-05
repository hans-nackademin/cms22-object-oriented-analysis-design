using _01_FactoryPattern.Interfaces;

namespace _01_FactoryPattern.Models;

internal class GuestUser : IUser
{
    public int GuestNumber { get; set; }
}
