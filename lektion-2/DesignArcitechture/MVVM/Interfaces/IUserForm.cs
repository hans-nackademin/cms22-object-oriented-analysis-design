namespace MVVM.Interfaces;

interface IUserForm : IUser
{
    public string FirstNameError { get; set; }
    public string LastNameError { get; set; }
}
