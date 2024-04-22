using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PasswordGeneratorV2
{
    public partial class PasswordEdit : Form
    {
        public string key = string.Empty;
        public PasswordEdit()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Check if the password field is not empty
            if (string.IsNullOrEmpty(textBoxPasswordEdit.Text))
            {
                MessageBox.Show("The password field is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PasswordManager.PasswordsList[key] = PasswordManager.Encrypt(textBoxPasswordEdit.Text, PasswordManager.EncryptKey, PasswordManager.EncryptIV);
            PasswordManager.Serialize();
            MessageBox.Show("The password was changed.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void textBoxPasswordEdit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
