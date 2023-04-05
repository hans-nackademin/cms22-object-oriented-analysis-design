using System.Security.Cryptography;

namespace _01_SRP.Factories
{
    public class HmacFactory
    {
        public static HMAC Create(string encryption = null!)
        {
            return encryption switch
            {
                "256" => new HMACSHA256(),
                _ => new HMACSHA512(),
            };
        }
    }
}
