namespace MVP.Interfaces;

internal interface IUserForm : IUser
{
    public string FirstNameError { get; set; }
    public string LastNameError { get; set; }

    public event EventHandler SaveEvent;
}
