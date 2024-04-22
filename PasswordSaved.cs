using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PasswordGeneratorV2
{
    public partial class PasswordSaved : Form
    {
        public PasswordSaved()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            foreach (var item in PasswordManager.PasswordsList)
            {
                gridData.Rows.Add(item.Key, PasswordManager.Decrypt(item.Value, PasswordManager.EncryptKey, PasswordManager.EncryptIV));
            }
        }

        private void gridPasswordData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                gridData.Rows[e.RowIndex].Selected = true;
            }
            catch
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridData.SelectedRows.Count == 0)
            {
                MessageBox.Show("You need to select a row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow row in gridData.SelectedRows)
            {
                PasswordManager.PasswordsList.Remove(row.Cells["gridAccount"].Value.ToString());
                gridData.Rows.Remove(row);
                PasswordManager.Serialize();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridData.SelectedRows.Count == 0)
            {
                MessageBox.Show("You need to select a row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PasswordEdit passwordedit = new PasswordEdit();
            DataGridViewRow row = new DataGridViewRow();
            passwordedit.key = gridData.SelectedRows[0].Cells["gridAccount"].Value.ToString();
            passwordedit.textBoxPasswordEdit.Text = gridData.SelectedRows[0].Cells["gridPassword"].Value.ToString();
            passwordedit.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            gridData.Rows.Clear();
            foreach (var item in PasswordManager.PasswordsList)
            {
                gridData.Rows.Add(item.Key, PasswordManager.Decrypt(item.Value, PasswordManager.EncryptKey, PasswordManager.EncryptIV));
            }
        }
        private void PasswordSaved_Load(object sender, EventArgs e)
        {

        }
    }
}
