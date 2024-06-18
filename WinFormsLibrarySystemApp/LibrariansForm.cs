using EFLibrarySystemApp;

namespace WinFormsLibrarySystemApp
{
    public partial class LibrariansForm : Form
    {
        bool isAdd = false;

        public LibrariansForm()
        {
            InitializeComponent();

            txtLogin.Enabled = false;
            txtPassword.Enabled = false;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;

            txtLogin.Enabled = true;
            txtPassword.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isAdd = false;

            txtLogin.Enabled = true;
            txtPassword.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            var admin = (Librarian)lstLibrs.SelectedItem;
            txtLogin.Text = admin.Login;
            txtPassword.Text = admin.Password;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstLibrs.SelectedValue is not null)
            {
                using (LibrarySystemContext context = new())
                {
                    var libr = context.Librarians
                                       .FirstOrDefault(a => a.Id == (int)lstLibrs.SelectedValue);
                    if (libr is not null)
                        context.Librarians.Remove(libr);
                    context.SaveChanges();
                    lstLibrs.DataSource = context.Librarians.ToList();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (LibrarySystemContext context = new())
            {
                if (isAdd && txtLogin.Text != ""
                          && txtPassword.Text != "")
                    context.Librarians.Add(new()
                    {
                        Login = txtLogin.Text,
                        Password = txtPassword.Text
                    });
                else
                {
                    var libr = context.Librarians
                                       .FirstOrDefault(a => a.Id == (int)lstLibrs.SelectedValue);
                    libr.Login = txtLogin.Text;
                    libr.Password = txtPassword.Text;
                }
                context.SaveChanges();

                lstLibrs.DataSource = context.Librarians.ToList();

                txtLogin.Text = "";
                txtPassword.Text = "";

                txtLogin.Enabled = false;
                txtPassword.Enabled = false;

                btnSave.Enabled = false;
                btnCancel.Enabled = false;

                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtPassword.Text = "";

            txtLogin.Enabled = false;
            txtPassword.Enabled = false;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void LibrariansForm_Load(object sender, EventArgs e)
        {
            using (LibrarySystemContext context = new())
            {
                lstLibrs.DataSource = context.Librarians.ToList();
                lstLibrs.DisplayMember = "Login";
                lstLibrs.ValueMember = "Id";
            }
        }
    }
}
