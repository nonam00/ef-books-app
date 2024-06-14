namespace WinFormsLibrarySystemApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmins_Click(object sender, EventArgs e)
        {
            AdminsForm adminsForm = new AdminsForm();
            adminsForm.ShowDialog();
        }

        private void btnLibrs_Click(object sender, EventArgs e)
        {
            LibrariansForm librariansForm = new LibrariansForm();
            librariansForm.ShowDialog();
        }
    }
}
