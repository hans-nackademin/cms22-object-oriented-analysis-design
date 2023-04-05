using _01_FactoryPattern.Interfaces;

namespace _01_FactoryPattern.Models;

internal class StandardUser : IUser
{
    public int UserNumber { get; set; }
}
