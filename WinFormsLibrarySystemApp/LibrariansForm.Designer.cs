namespace WinFormsLibrarySystemApp
{
    partial class LibrariansForm
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
            lstLibrs = new ListBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lstLibrs
            // 
            lstLibrs.FormattingEnabled = true;
            lstLibrs.ItemHeight = 30;
            lstLibrs.Location = new Point(12, 12);
            lstLibrs.Name = "lstLibrs";
            lstLibrs.Size = new Size(393, 394);
            lstLibrs.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 443);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 52);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(151, 443);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(119, 52);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(286, 443);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 52);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(437, 57);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(349, 36);
            txtLogin.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(437, 134);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(349, 36);
            txtPassword.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(437, 212);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 52);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(621, 212);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(165, 52);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // LibrariansForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 523);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lstLibrs);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "LibrariansForm";
            Text = "LibrariansForm";
            Load += LibrariansForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLibrs;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnSave;
        private Button btnCancel;
    }
}