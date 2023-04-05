namespace Shared.Interfaces;

public interface IAdminUser : IPrivateUser
{
    public string RoleName { get; set; }
}
