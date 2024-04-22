using System.Text;

namespace PasswordGeneratorV2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            btnRemember.Enabled = false;
            btnPasswordHub.Enabled = false;
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
                checkBoxUseUpperCase.Checked == true || checkBoxSpecific.Checked == true)
            {
                txtPswrd.Text = PasswordGenerator.Generate(Convert.ToInt32(upDownLenght.Value), checkBoxLowerCase.Checked,
                    checkBoxUseUpperCase.Checked, checkBoxNumbers.Checked, checkBoxSpecific.Checked);
            }
            else
            {
                //Check if at least one checkbox is active to start generatin the password
                MessageBox.Show("At least one option must be checked.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //Check if user did not generate a password
            if (!string.IsNullOrEmpty(txtPswrd.Text))
            {
                Clipboard.SetText(txtPswrd.Text);
                MessageBox.Show("The password was copied.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You can not copy a password, because you have not generated it yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {
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

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}

