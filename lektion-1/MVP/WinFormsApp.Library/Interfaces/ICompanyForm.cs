namespace WinFormsApp.Library.Interfaces;

public interface ICompanyForm : ICompany
{
    public string CompanyName_Error { get; set; }
    public bool Display_CompanyName_Error { get; set; }

    public string Email_Error { get; set; }
    public bool Display_Email_Error { get; set; }

    public event EventHandler SaveEvent;
}
