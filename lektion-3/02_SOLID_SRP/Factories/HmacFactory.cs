using System.Security.Cryptography;

namespace _02_SOLID_SRP.Factories;

internal class HmacFactory
{
    public static HMACSHA512 Create()
    {
        return new HMACSHA512();
    }

    public static HMACSHA512 Create(byte[] salt)
    {
        return new HMACSHA512(salt);
    }
}
