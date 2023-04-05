using Shared.Interfaces;

namespace Shared.Models;

public class User : IUser
{
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
}
