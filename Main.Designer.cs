namespace PasswordGeneratorV2
{
    partial class Main
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
            pictureBox1 = new PictureBox();
            groupBoxSettings = new GroupBox();
            btnCopy = new Button();
            lblLenght = new Label();
            btnGenerate = new Button();
            upDownLenght = new NumericUpDown();
            checkBoxSpecific = new CheckBox();
            checkBoxNumbers = new CheckBox();
            txtPswrd = new TextBox();
            checkBoxLowerCase = new CheckBox();
            checkBoxUpperCase = new CheckBox();
            btnRemember = new Button();
            btnPasswordHub = new Button();
            groupBoxPasswordManager = new GroupBox();
            groupBox1 = new GroupBox();
            btnSaveKey = new Button();
            lblEncKey = new Label();
            textBoxKey = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)upDownLenght).BeginInit();
            groupBoxPasswordManager.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBoxSettings
            // 
            groupBoxSettings.Controls.Add(btnCopy);
            groupBoxSettings.Controls.Add(lblLenght);
            groupBoxSettings.Controls.Add(btnGenerate);
            groupBoxSettings.Controls.Add(upDownLenght);
            groupBoxSettings.Controls.Add(checkBoxSpecific);
            groupBoxSettings.Controls.Add(checkBoxNumbers);
            groupBoxSettings.Controls.Add(txtPswrd);
            groupBoxSettings.Controls.Add(checkBoxLowerCase);
            groupBoxSettings.Controls.Add(checkBoxUpperCase);
            groupBoxSettings.Location = new Point(12, 134);
            groupBoxSettings.Name = "groupBoxSettings";
            groupBoxSettings.Size = new Size(435, 245);
            groupBoxSettings.TabIndex = 1;
            groupBoxSettings.TabStop = false;
            groupBoxSettings.Text = "Password Generator";
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.FromArgb(0, 140, 255);
            btnCopy.Cursor = Cursors.Hand;
            btnCopy.FlatAppearance.BorderSize = 0;
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.ForeColor = SystemColors.Control;
            btnCopy.Location = new Point(26, 195);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(381, 34);
            btnCopy.TabIndex = 2;
            btnCopy.Text = "Copy the password";
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // lblLenght
            // 
            lblLenght.AutoSize = true;
            lblLenght.Location = new Point(26, 49);
            lblLenght.Name = "lblLenght";
            lblLenght.Size = new Size(144, 14);
            lblLenght.TabIndex = 4;
            lblLenght.Text = "The lenght of a password";
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(0, 140, 255);
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.ForeColor = SystemColors.Control;
            btnGenerate.Location = new Point(26, 155);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(381, 34);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate a password";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // upDownLenght
            // 
            upDownLenght.Location = new Point(26, 70);
            upDownLenght.Name = "upDownLenght";
            upDownLenght.Size = new Size(381, 22);
            upDownLenght.TabIndex = 3;
            upDownLenght.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // checkBoxSpecific
            // 
            checkBoxSpecific.AutoSize = true;
            checkBoxSpecific.Location = new Point(339, 21);
            checkBoxSpecific.Name = "checkBoxSpecific";
            checkBoxSpecific.Size = new Size(68, 18);
            checkBoxSpecific.TabIndex = 2;
            checkBoxSpecific.Text = "Specific";
            checkBoxSpecific.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumbers
            // 
            checkBoxNumbers.AutoSize = true;
            checkBoxNumbers.Location = new Point(234, 21);
            checkBoxNumbers.Name = "checkBoxNumbers";
            checkBoxNumbers.Size = new Size(76, 18);
            checkBoxNumbers.TabIndex = 1;
            checkBoxNumbers.Text = "Numbers";
            checkBoxNumbers.UseVisualStyleBackColor = true;
            // 
            // txtPswrd
            // 
            txtPswrd.BackColor = SystemColors.ControlLightLight;
            txtPswrd.Location = new Point(26, 114);
            txtPswrd.Multiline = true;
            txtPswrd.Name = "txtPswrd";
            txtPswrd.ReadOnly = true;
            txtPswrd.Size = new Size(381, 35);
            txtPswrd.TabIndex = 0;
            // 
            // checkBoxLowerCase
            // 
            checkBoxLowerCase.AutoSize = true;
            checkBoxLowerCase.Location = new Point(140, 21);
            checkBoxLowerCase.Name = "checkBoxLowerCase";
            checkBoxLowerCase.Size = new Size(88, 18);
            checkBoxLowerCase.TabIndex = 1;
            checkBoxLowerCase.Text = "Lower Case";
            checkBoxLowerCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpperCase
            // 
            checkBoxUpperCase.AutoSize = true;
            checkBoxUpperCase.Checked = true;
            checkBoxUpperCase.CheckState = CheckState.Checked;
            checkBoxUpperCase.Location = new Point(26, 21);
            checkBoxUpperCase.Name = "checkBoxUpperCase";
            checkBoxUpperCase.Size = new Size(88, 18);
            checkBoxUpperCase.TabIndex = 0;
            checkBoxUpperCase.Text = "Upper Case";
            checkBoxUpperCase.UseVisualStyleBackColor = true;
            // 
            // btnRemember
            // 
            btnRemember.BackColor = Color.FromArgb(0, 140, 255);
            btnRemember.Cursor = Cursors.Hand;
            btnRemember.Enabled = false;
            btnRemember.FlatAppearance.BorderSize = 0;
            btnRemember.FlatStyle = FlatStyle.Flat;
            btnRemember.ForeColor = SystemColors.Control;
            btnRemember.Location = new Point(20, 31);
            btnRemember.Name = "btnRemember";
            btnRemember.Size = new Size(381, 34);
            btnRemember.TabIndex = 3;
            btnRemember.Text = "Remember this password";
            btnRemember.UseVisualStyleBackColor = false;
            btnRemember.Click += btnRemember_Click_1;
            // 
            // btnPasswordHub
            // 
            btnPasswordHub.BackColor = Color.FromArgb(0, 140, 255);
            btnPasswordHub.Cursor = Cursors.Hand;
            btnPasswordHub.Enabled = false;
            btnPasswordHub.FlatAppearance.BorderSize = 0;
            btnPasswordHub.FlatStyle = FlatStyle.Flat;
            btnPasswordHub.ForeColor = SystemColors.Control;
            btnPasswordHub.Location = new Point(20, 74);
            btnPasswordHub.Name = "btnPasswordHub";
            btnPasswordHub.Size = new Size(381, 34);
            btnPasswordHub.TabIndex = 3;
            btnPasswordHub.Text = "Password Hub";
            btnPasswordHub.UseVisualStyleBackColor = false;
            btnPasswordHub.Click += btnPasswordHub_Click;
            // 
            // groupBoxPasswordManager
            // 
            groupBoxPasswordManager.Controls.Add(btnRemember);
            groupBoxPasswordManager.Controls.Add(btnPasswordHub);
            groupBoxPasswordManager.Location = new Point(6, 103);
            groupBoxPasswordManager.Name = "groupBoxPasswordManager";
            groupBoxPasswordManager.Size = new Size(423, 134);
            groupBoxPasswordManager.TabIndex = 4;
            groupBoxPasswordManager.TabStop = false;
            groupBoxPasswordManager.Text = "Password Hub";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSaveKey);
            groupBox1.Controls.Add(lblEncKey);
            groupBox1.Controls.Add(groupBoxPasswordManager);
            groupBox1.Controls.Add(textBoxKey);
            groupBox1.Location = new Point(12, 405);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 256);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Password Manager";
            // 
            // btnSaveKey
            // 
            btnSaveKey.BackColor = Color.FromArgb(0, 140, 255);
            btnSaveKey.Cursor = Cursors.Hand;
            btnSaveKey.FlatAppearance.BorderSize = 0;
            btnSaveKey.FlatStyle = FlatStyle.Flat;
            btnSaveKey.ForeColor = SystemColors.Control;
            btnSaveKey.Location = new Point(26, 63);
            btnSaveKey.Name = "btnSaveKey";
            btnSaveKey.Size = new Size(381, 34);
            btnSaveKey.TabIndex = 3;
            btnSaveKey.Text = "Save Key";
            btnSaveKey.UseVisualStyleBackColor = false;
            btnSaveKey.Click += btnSaveKey_Click;
            // 
            // lblEncKey
            // 
            lblEncKey.AutoSize = true;
            lblEncKey.Location = new Point(26, 18);
            lblEncKey.Name = "lblEncKey";
            lblEncKey.Size = new Size(198, 14);
            lblEncKey.TabIndex = 5;
            lblEncKey.Text = "Enter your 16 bytes Encryption Key:";
            // 
            // textBoxKey
            // 
            textBoxKey.BackColor = SystemColors.ControlLightLight;
            textBoxKey.Location = new Point(26, 35);
            textBoxKey.MaxLength = 16;
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new Size(381, 22);
            textBoxKey.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(460, 673);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxSettings);
            Controls.Add(pictureBox1);
            Font = new Font("Roboto", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxSettings.ResumeLayout(false);
            groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)upDownLenght).EndInit();
            groupBoxPasswordManager.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBoxSettings;
        private NumericUpDown upDownLenght;
        private CheckBox checkBoxSpecific;
        private CheckBox checkBoxNumbers;
        private CheckBox checkBoxLowerCase;
        private CheckBox checkBoxUpperCase;
        private Label lblLenght;
        private Button btnCopy;
        private Button btnGenerate;
        public TextBox txtPswrd;
        public Button btnRemember;
        private Button btnPasswordHub;
        private GroupBox groupBoxPasswordManager;
        private GroupBox groupBox1;
        private Label lblEncKey;
        public TextBox textBoxKey;
        public Button btnSaveKey;
    }
}
