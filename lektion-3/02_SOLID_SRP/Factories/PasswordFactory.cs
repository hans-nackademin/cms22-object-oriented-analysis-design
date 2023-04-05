using System.Text;

namespace _02_SOLID_SRP.Factories;

internal class PasswordFactory
{
    public static void Generate(string password, out byte[] hash, out byte[] salt)
    {
        using var hmac = HmacFactory.Create();
        salt = hmac.Key;
        hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }
}
