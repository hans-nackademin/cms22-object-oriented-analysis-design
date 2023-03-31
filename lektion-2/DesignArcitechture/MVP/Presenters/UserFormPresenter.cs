using MVP.Interfaces;
using MVP.Models;

namespace MVP.Presenters;

internal class UserFormPresenter
{
    private readonly IUserForm _form;

    public UserFormPresenter(IUserForm form)
    {
        _form = form;
        _form.SaveEvent += SaveForm;
    }

    private void SaveForm(object? sender, EventArgs e)
    {
        IUser user = new User();

        if (string.IsNullOrEmpty(_form.FirstName))
        {
            user.FirstName = string.Empty;
            _form.FirstNameError = "Du måste ange ett förnamn";
        } 
        else
        {
            user.FirstName = _form.FirstName;
            _form.FirstNameError = string.Empty;
        }

        if (string.IsNullOrEmpty(_form.LastName))
        {
            user.LastName = string.Empty;
            _form.LastNameError = "Du måste ange ett efternamn";
        }
        else
        {
            user.LastName = _form.LastName;
            _form.LastNameError = string.Empty;
        }

        if(!string.IsNullOrEmpty(user.FirstName) && !string.IsNullOrEmpty(user.LastName))
        {
            // Save To Database
        }
    }
}
