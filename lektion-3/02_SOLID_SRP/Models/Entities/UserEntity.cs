using _02_SOLID_SRP.Factories;

namespace _02_SOLID_SRP.Models.Entities;

internal class UserEntity
{
    private byte[] _password = null!;
    private byte[] _securityKey = null!;

    public int Id { get; set; }
    public string UserName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public byte[] PasswordHash { get => _password; }
    public byte[] SecurityKey { get => _securityKey; }


    public void GeneratePassword(string password)
    {
        PasswordFactory.Generate(password, out _password, out _securityKey);
    }
}
