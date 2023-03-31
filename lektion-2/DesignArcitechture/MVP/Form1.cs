using MVP.Interfaces;
using MVP.Presenters;

namespace MVP
{
    public partial class Form1 : Form, IUserForm
    {
        private UserFormPresenter _presenter;

        public Form1()
        {
            InitializeComponent();
            _presenter = new UserFormPresenter(this);
        }

        public string FirstNameError { get => LbFirstNameError.Text; set => LbFirstNameError.Text = value; }
        public string LastNameError { get => LbLastNameError.Text; set => LbLastNameError.Text = value; }
        public string FirstName { get => TbFirstName.Text; set => TbFirstName.Text = value; }
        public string LastName { get => TbLastName.Text; set => TbLastName.Text = value; }

        public event EventHandler? SaveEvent;

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}