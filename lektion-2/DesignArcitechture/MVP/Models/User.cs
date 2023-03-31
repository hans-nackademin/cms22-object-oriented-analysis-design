using MVP.Interfaces;

namespace MVP.Models;

internal class User : IUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}
