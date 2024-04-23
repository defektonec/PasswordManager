using System.Text;

namespace PasswordGeneratorV2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            PasswordManager.Deserialize();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Check if the lenght is more than 0
            if (upDownLenght.Value == 0)
            {
                MessageBox.Show("Lenght must be more than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Password generating
            if (checkBoxLowerCase.Checked == true || checkBoxNumbers.Checked == true ||
                checkBoxUpperCase.Checked == true || checkBoxSpecific.Checked == true)
            {
                txtPswrd.Text = PasswordGenerator.Generate(Convert.ToInt32(upDownLenght.Value), checkBoxLowerCase.Checked,
                    checkBoxUpperCase.Checked, checkBoxNumbers.Checked, checkBoxSpecific.Checked);
            }
            else
            {
                // if no one checkbox was active throw Exception
                MessageBox.Show("At least one option must be checked.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //Check if user did not generate a password
            if (string.IsNullOrEmpty(txtPswrd.Text))
            {
                MessageBox.Show("The password field is empty, there is nothing to copy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Clipboard.SetText(txtPswrd.Text);
            MessageBox.Show("The password was copied.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPasswordHub_Click(object sender, EventArgs e)
        {
            try
            {
                PasswordSaved passwordsaved = new PasswordSaved();
                passwordsaved.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Wrong key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSaveKey_Click(object sender, EventArgs e)
        {
            if (textBoxKey.Text.Length == 16)
            {
                btnRemember.Enabled = true;
                btnPasswordHub.Enabled = true;
                //textBoxKey.Enabled = false;
                //btnSaveKey.Enabled = false;

                PasswordManager.EncryptKey = Encoding.UTF8.GetBytes(textBoxKey.Text);
                MessageBox.Show("The key was accepted.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Key lenght is not 16 bytes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnRemember_Click_1(object sender, EventArgs e)
        {
            PasswordAdd passwordadd = new PasswordAdd();
            passwordadd.textBoxPassword.Text = txtPswrd.Text;
            passwordadd.ShowDialog();
        }
    }
}

