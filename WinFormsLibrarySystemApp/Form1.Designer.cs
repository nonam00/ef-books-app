namespace WinFormsLibrarySystemApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpActors = new GroupBox();
            btnLibrs = new Button();
            btnAdmins = new Button();
            grpActors.SuspendLayout();
            SuspendLayout();
            // 
            // grpActors
            // 
            grpActors.Controls.Add(btnLibrs);
            grpActors.Controls.Add(btnAdmins);
            grpActors.Font = new Font("Segoe UI", 16F);
            grpActors.Location = new Point(12, 12);
            grpActors.Name = "grpActors";
            grpActors.Size = new Size(292, 281);
            grpActors.TabIndex = 0;
            grpActors.TabStop = false;
            grpActors.Text = "Actors";
            // 
            // btnLibrs
            // 
            btnLibrs.Location = new Point(15, 173);
            btnLibrs.Name = "btnLibrs";
            btnLibrs.Size = new Size(258, 51);
            btnLibrs.TabIndex = 0;
            btnLibrs.Text = "Librarians";
            btnLibrs.UseVisualStyleBackColor = true;
            btnLibrs.Click += btnLibrs_Click;
            // 
            // btnAdmins
            // 
            btnAdmins.Location = new Point(15, 93);
            btnAdmins.Name = "btnAdmins";
            btnAdmins.Size = new Size(258, 51);
            btnAdmins.TabIndex = 0;
            btnAdmins.Text = "Administrators";
            btnAdmins.UseVisualStyleBackColor = true;
            btnAdmins.Click += btnAdmins_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpActors);
            Name = "Form1";
            Text = "Library System";
            grpActors.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpActors;
        private Button btnLibrs;
        private Button btnAdmins;
    }
}
