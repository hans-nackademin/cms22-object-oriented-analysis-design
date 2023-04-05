namespace Shared.Interfaces;

public interface IPrivateUser : IUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
