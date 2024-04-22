namespace PasswordGeneratorV2
{
    partial class PasswordAdd
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
            textBoxPassword = new TextBox();
            lblPassword = new Label();
            btnSavePassword = new Button();
            lblNamePassword = new Label();
            textBoxAccountName = new TextBox();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 91);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(360, 34);
            textBoxPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 74);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(64, 14);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // btnSavePassword
            // 
            btnSavePassword.BackColor = Color.FromArgb(0, 140, 255);
            btnSavePassword.Cursor = Cursors.Hand;
            btnSavePassword.FlatStyle = FlatStyle.Flat;
            btnSavePassword.ForeColor = SystemColors.Control;
            btnSavePassword.Location = new Point(12, 142);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(360, 34);
            btnSavePassword.TabIndex = 4;
            btnSavePassword.Text = "Remember this password";
            btnSavePassword.UseVisualStyleBackColor = false;
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // lblNamePassword
            // 
            lblNamePassword.AutoSize = true;
            lblNamePassword.Location = new Point(12, 9);
            lblNamePassword.Name = "lblNamePassword";
            lblNamePassword.Size = new Size(55, 14);
            lblNamePassword.TabIndex = 0;
            lblNamePassword.Text = "Account:";
            lblNamePassword.Click += lblNamePassword_Click;
            // 
            // textBoxAccountName
            // 
            textBoxAccountName.Location = new Point(12, 26);
            textBoxAccountName.Multiline = true;
            textBoxAccountName.Name = "textBoxAccountName";
            textBoxAccountName.Size = new Size(360, 34);
            textBoxAccountName.TabIndex = 1;
            // 
            // PasswordAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 196);
            Controls.Add(btnSavePassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxAccountName);
            Controls.Add(lblPassword);
            Controls.Add(lblNamePassword);
            Font = new Font("Roboto", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PasswordAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Password Manager";
            Load += PasswordAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPassword;
        private Button btnSavePassword;
        public TextBox textBoxPassword;
        private Label lblNamePassword;
        private TextBox textBoxAccountName;
    }
}