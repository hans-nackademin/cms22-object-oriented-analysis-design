using WinFormsApp.Library.Interfaces;
using WinFormsApp.Library.Models;

namespace WinFormsApp.Library.Presenters;

public class CompanyFormPresenter
{
    private readonly ICompanyForm _form;

    public CompanyFormPresenter(ICompanyForm form)
    {
        _form = form;
        _form.SaveEvent += SaveForm;
    }

    private void SaveForm(object? sender, EventArgs e)
    {
        var company = new Company();

        if(string.IsNullOrEmpty(_form.CompanyName))
        {
            _form.CompanyName_Error = "Company Name is required.";
            _form.Display_CompanyName_Error = true;
        } 
        else
        {
            company.CompanyName = _form.CompanyName;
            _form.CompanyName_Error = string.Empty;
            _form.Display_CompanyName_Error = false;
        }

        if (string.IsNullOrEmpty(_form.Email))
        {
            _form.Email_Error = "Email is required.";
            _form.Display_Email_Error = true;
        }
        else
        {
            company.Email = _form.Email;
            _form.Email_Error = string.Empty;
            _form.Display_Email_Error = false;
        }
    }
}
