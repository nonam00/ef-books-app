using EFLibrarySystemApp;

namespace WinFormsLibrarySystemApp
{
    public partial class AdminsForm : Form
    {
        bool isAdd = false;

        public AdminsForm()
        {
            InitializeComponent();

            txtLoginAdimn.Enabled = false;
            txtPasswordAdmin.Enabled = false;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void AdminsForm_Load(object sender, EventArgs e)
        {
            using (LibrarySystemContext context = new())
            {
                lstAdmins.DataSource = context.Administrators.ToList();
                lstAdmins.DisplayMember = "Login";
                lstAdmins.ValueMember = "Id";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;

            txtLoginAdimn.Enabled = true;
            txtPasswordAdmin.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isAdd = false;

            txtLoginAdimn.Enabled = true;
            txtPasswordAdmin.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            var admin = (Administrator)lstAdmins.SelectedItem;
            txtLoginAdimn.Text = admin.Login;
            txtPasswordAdmin.Text = admin.Password;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstAdmins.SelectedValue is not null)
            {
                using(LibrarySystemContext context = new())
                {
                    var admin = context.Administrators
                                       .FirstOrDefault(a => a.Id == (int)lstAdmins.SelectedValue);
                    if (admin is not null)
                        context.Administrators.Remove(admin);
                    context.SaveChanges();
                    lstAdmins.DataSource = context.Administrators.ToList();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (LibrarySystemContext context = new())
            {
                if (isAdd && txtLoginAdimn.Text != "" 
                          && txtPasswordAdmin.Text != "")
                    context.Administrators.Add(new() 
                    { 
                        Login = txtLoginAdimn.Text, 
                        Password = txtPasswordAdmin.Text 
                    });
                else
                {
                    var admin = context.Administrators
                                       .FirstOrDefault(a => a.Id == (int)lstAdmins.SelectedValue);
                    admin.Login = txtLoginAdimn.Text;
                    admin.Password = txtPasswordAdmin.Text;
                }
                context.SaveChanges();

                lstAdmins.DataSource = context.Administrators.ToList();

                txtLoginAdimn.Text = "";
                txtPasswordAdmin.Text = "";

                txtLoginAdimn.Enabled = false;
                txtPasswordAdmin.Enabled = false;

                btnSave.Enabled = false;
                btnCancel.Enabled = false;

                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtLoginAdimn.Text = "";
            txtPasswordAdmin.Text = "";

            txtLoginAdimn.Enabled = false;
            txtPasswordAdmin.Enabled = false;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
