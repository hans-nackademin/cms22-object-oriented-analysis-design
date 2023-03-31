using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM.Interfaces;
using MVVM.Models;

namespace MVVM.ViewModels;

internal partial class UserFormViewModel : ObservableObject, IUserForm
{
    [ObservableProperty]
    private string firstNameError = null!;

    [ObservableProperty]
    private string lastNameError = null!;

    [ObservableProperty]
    private string firstName = null!;

    [ObservableProperty]
    private string lastName = null!;

    [RelayCommand]
    public void SaveForm()
    {
        IUser user = new User();

        if (string.IsNullOrEmpty(FirstName))
        {
            user.FirstName = string.Empty;
            FirstNameError = "Du måste ange ett förnamn";
        }
        else
        {
            user.FirstName = FirstName;
            FirstNameError = string.Empty;
        }

        if (string.IsNullOrEmpty(LastName))
        {
            user.LastName = string.Empty;
            LastNameError = "Du måste ange ett efternamn";
        }
        else
        {
            user.LastName = LastName;
            LastNameError = string.Empty;
        }

        if (!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
        {
            // Save To Database
        }
    }
}
