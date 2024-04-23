namespace PasswordGeneratorV2
{
    partial class PasswordEdit
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
            btnEdit = new Button();
            textBoxPasswordEdit = new TextBox();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 140, 255);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(12, 70);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(360, 34);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // textBoxPasswordEdit
            // 
            textBoxPasswordEdit.Location = new Point(12, 28);
            textBoxPasswordEdit.Multiline = true;
            textBoxPasswordEdit.Name = "textBoxPasswordEdit";
            textBoxPasswordEdit.Size = new Size(360, 34);
            textBoxPasswordEdit.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 11);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password Edit:";
            // 
            // PasswordEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 120);
            Controls.Add(btnEdit);
            Controls.Add(textBoxPasswordEdit);
            Controls.Add(lblPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PasswordEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PasswordEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        public TextBox textBoxPasswordEdit;
        private Label lblPassword;
    }
}