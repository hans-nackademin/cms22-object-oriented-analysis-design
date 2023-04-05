namespace Shared.Interfaces;

public interface ICompanyUser : IUser
{
    public string CompanyName { get; set; }
}
