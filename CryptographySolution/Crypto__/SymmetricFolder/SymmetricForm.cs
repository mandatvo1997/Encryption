using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto__.SymmetricFolder
{
    public partial class SymmetricForm : Form
    {
        public SymmetricForm()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtKey.Text.Length == 8)
            {
                txtEncrypt.Text = new SymmetricClass().EncryptData(txtInput.Text, txtKey.Text);
               
            }
            else
                MessageBox.Show("Nhập key có 8 ký tự");
            
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtDecrypt.Text = new SymmetricClass().DecryptData(txtEncrypt.Text, txtKey.Text);
        }
    }
}
