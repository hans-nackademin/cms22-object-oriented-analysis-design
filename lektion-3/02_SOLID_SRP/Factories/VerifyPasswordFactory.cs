using System.Text;

namespace _02_SOLID_SRP.Factories;

internal class VerifyPasswordFactory
{
    public static bool Verify(string password, byte[] passwordHash, byte[] securityKey)
    {
        using var hmac = HmacFactory.Create(securityKey);
        var _hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        for (int i = 0; i < _hash.Length; i++)
            if (passwordHash[i] != _hash[i])
                return false;

        return true;
    }
}
