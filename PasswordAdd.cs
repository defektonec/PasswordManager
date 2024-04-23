using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGeneratorV2
{
    public partial class PasswordAdd : Form
    {
        public PasswordAdd()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            //Check if the name field is not empty
            if (string.IsNullOrEmpty(textBoxAccountName.Text))
            {
                MessageBox.Show("You must write the name of password account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Check if the password field is not empty
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("The password field is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Try to add new password to the Password Manager
            try
            {
                PasswordManager.SavePassword(textBoxAccountName.Text, textBoxPassword.Text);
                PasswordManager.Serialize();
            }
            catch (PasswordAlreadyExists)
            {
                MessageBox.Show("Password for the same account is already exists, change the account and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("The password was saved.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
