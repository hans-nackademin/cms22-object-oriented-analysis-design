using WinFormsApp.Library.Interfaces;
using WinFormsApp.Library.Presenters;

namespace WinFormsApp
{
    public partial class Form1 : Form, ICompanyForm
    {
        private CompanyFormPresenter _presenter;

        public Form1()
        {
            InitializeComponent();
            _presenter = new CompanyFormPresenter(this);
        }

        public bool Display_CompanyName_Error { get => CompanyName_Error.Visible; set => CompanyName_Error.Visible = value; }
        public bool Display_Email_Error { get => Email_Error.Visible; set => Email_Error.Visible = value; }   
        string ICompanyForm.CompanyName_Error { get => CompanyName_Error.Text; set => CompanyName_Error.Text = value; }
        string ICompanyForm.Email_Error { get => Email_Error.Text; set => Email_Error.Text = value; }   
        string ICompany.CompanyName { get => CompanyName.Text; set => CompanyName.Text = value; }
        string ICompany.Email { get => Email.Text; set => Email.Text = value; }

        
        public event EventHandler? SaveEvent;

        private void Save_Click(object sender, EventArgs e)
        {
            SaveEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}