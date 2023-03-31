using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfApp.Library.Interfaces;
using WpfApp.Library.Models;

namespace WpfApp.Library.ViewModels;

public partial class CompanyFormViewModel : ObservableObject, ICompanyForm
{
    [ObservableProperty]
    private string companyName_Error;

    [ObservableProperty]
    private bool display_CompanyName_Error;

    [ObservableProperty]
    private string email_Error;

    [ObservableProperty]
    private bool display_Email_Error;

    [ObservableProperty]
    private string companyName;

    [ObservableProperty]
    private string email;

    [RelayCommand]
    public void Save()
    {
        CheckErrors();

        var company = new Company
        {
            CompanyName = CompanyName,
            Email = Email
        };

        // save data to database
    }

    private void CheckErrors()
    {
        if (string.IsNullOrEmpty(CompanyName)) 
        {
            CompanyName_Error = "Company Name is Required.";
            Display_CompanyName_Error = true;
        }
        else
        {
            CompanyName_Error = string.Empty;
            Display_CompanyName_Error = false;
        }

        if (string.IsNullOrEmpty(Email))
        {
            Email_Error = "Company Name is Required.";
            Display_Email_Error = true;
        }
        else
        {
            Email_Error = string.Empty;
            Display_Email_Error = false;
        }
    }

}
