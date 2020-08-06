using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crypto__.AsymmetricFolder;
namespace Crypto__.AsymmetricFolder
{
    public partial class AsymmetricForm : Form
    {
        public AsymmetricForm()
        {
            InitializeComponent();
        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            var result = new AsymmetricClass().AssignNewKey();
            txtprivate.Text = result.Item1;
            txtpublic.Text = result.Item2;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtEncrypt.Text = new AsymmetricClass().Encryption(txtInput.Text, txtpublic.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtDecrypt.Text = new AsymmetricClass().Decryption(txtEncrypt.Text, txtprivate.Text);
        }
    }
}
