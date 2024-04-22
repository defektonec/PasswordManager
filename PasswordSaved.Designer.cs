namespace PasswordGeneratorV2
{
    partial class PasswordSaved
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordSaved));
            gridData = new DataGridView();
            gridAccount = new DataGridViewTextBoxColumn();
            gridPassword = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnDelete = new Button();
            btnEdit = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)gridData).BeginInit();
            SuspendLayout();
            // 
            // gridData
            // 
            gridData.AllowUserToAddRows = false;
            gridData.AllowUserToDeleteRows = false;
            gridData.AllowUserToResizeColumns = false;
            gridData.AllowUserToResizeRows = false;
            gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridData.BackgroundColor = SystemColors.ControlLight;
            gridData.BorderStyle = BorderStyle.None;
            gridData.ColumnHeadersHeight = 30;
            gridData.Columns.AddRange(new DataGridViewColumn[] { gridAccount, gridPassword });
            gridData.Location = new Point(12, 12);
            gridData.MultiSelect = false;
            gridData.Name = "gridData";
            gridData.ReadOnly = true;
            gridData.RightToLeft = RightToLeft.No;
            gridData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridData.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 144, 255);
            gridData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            gridData.ScrollBars = ScrollBars.Vertical;
            gridData.Size = new Size(403, 450);
            gridData.TabIndex = 0;
            gridData.CellClick += gridPasswordData_CellClick;
            // 
            // gridAccount
            // 
            gridAccount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridAccount.HeaderText = "Account";
            gridAccount.Name = "gridAccount";
            gridAccount.ReadOnly = true;
            gridAccount.Resizable = DataGridViewTriState.True;
            // 
            // gridPassword
            // 
            gridPassword.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridPassword.HeaderText = "Password";
            gridPassword.Name = "gridPassword";
            gridPassword.ReadOnly = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(0, 140, 255);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Roboto", 9F);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(12, 468);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(403, 38);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 140, 255);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Roboto", 9F);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(12, 512);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(359, 38);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(0, 140, 255);
            btnRefresh.BackgroundImageLayout = ImageLayout.Center;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = SystemColors.Control;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(377, 512);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(38, 38);
            btnRefresh.TabIndex = 5;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += button1_Click;
            // 
            // PasswordSaved
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(429, 560);
            Controls.Add(btnRefresh);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(gridData);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PasswordSaved";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Password Manager";
            Load += PasswordSaved_Load;
            ((System.ComponentModel.ISupportInitialize)gridData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridData;
        private DataGridViewTextBoxColumn gridAccount;
        private DataGridViewTextBoxColumn gridPassword;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnRefresh;
    }
}