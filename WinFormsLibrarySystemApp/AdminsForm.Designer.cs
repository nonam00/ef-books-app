namespace WinFormsLibrarySystemApp
{
    partial class AdminsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstAdmins = new ListBox();
            txtLoginAdimn = new TextBox();
            txtPasswordAdmin = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lstAdmins
            // 
            lstAdmins.Font = new Font("Segoe UI", 16F);
            lstAdmins.FormattingEnabled = true;
            lstAdmins.ItemHeight = 30;
            lstAdmins.Location = new Point(21, 24);
            lstAdmins.Margin = new Padding(5, 6, 5, 6);
            lstAdmins.Name = "lstAdmins";
            lstAdmins.Size = new Size(373, 364);
            lstAdmins.TabIndex = 0;
            // 
            // txtLoginAdimn
            // 
            txtLoginAdimn.Location = new Point(436, 76);
            txtLoginAdimn.Name = "txtLoginAdimn";
            txtLoginAdimn.Size = new Size(333, 36);
            txtLoginAdimn.TabIndex = 1;
            // 
            // txtPasswordAdmin
            // 
            txtPasswordAdmin.Location = new Point(436, 164);
            txtPasswordAdmin.Name = "txtPasswordAdmin";
            txtPasswordAdmin.Size = new Size(333, 36);
            txtPasswordAdmin.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 417);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 45);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(150, 417);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 45);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(279, 417);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 45);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(436, 238);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 48);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(617, 238);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(152, 48);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AdminsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 487);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtPasswordAdmin);
            Controls.Add(txtLoginAdimn);
            Controls.Add(lstAdmins);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AdminsForm";
            Text = "AdminsForm";
            Load += AdminsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstAdmins;
        private TextBox txtLoginAdimn;
        private TextBox txtPasswordAdmin;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
    }
}