using _01_FactoryPattern.Interfaces;
using _01_FactoryPattern.Models;
namespace _01_FactoryPattern.Factories;

internal class UserFactory
{
    public static IUser Create(string userType)
    {
        switch(userType)
        {
            case "admin":
                return new AdminUser();
 
            case "guest":
                return new GuestUser();

            default: 
                return new StandardUser();
        }
    }
}
