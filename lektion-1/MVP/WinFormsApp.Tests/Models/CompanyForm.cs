using WinFormsApp.Library.Interfaces;

namespace WinFormsApp.Tests.Models;

internal class CompanyForm : ICompanyForm
{
    public string CompanyName_Error { get; set; } = null!;
    public bool Display_CompanyName_Error { get; set; }
    public string Email_Error { get; set; } = null!;
    public bool Display_Email_Error { get; set; }
    public string CompanyName { get; set; } = null!;
    public string Email { get; set; } = null!;

    public event EventHandler? SaveEvent;

    // simulerar att vi trycker på knappen "Save"
    public void Save() => SaveEvent?.Invoke(this, EventArgs.Empty);
}
