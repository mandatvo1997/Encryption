using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto__.DigitalSignatureFolder
{
    public partial class DSForm : Form
    {
        public DSForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;

                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);

                txtInput.Text = FD.FileName;                
            }
        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            var result = new DSClass().GenerateKey();
            txtprivate.Text = result.Item1;
            txtpublic.Text = result.Item2;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            DSClass ds = new DSClass();
            string text = ds.Readfile(txtInput.Text);
            string sign = ds.GetNameFromFullName(txtInput.Text);            
            string signedtext = ds.SignData(text, txtprivate.Text);
            ds.SaveSignedMessage(signedtext, sign);
            string signedpath =  sign + "_Signed.txt";
            txtSign.Text = signedpath;
            MessageBox.Show("Signed");

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            
            DSClass ds = new DSClass();
            string text = ds.Readfile(txtInput.Text);
            string signedtext = ds.Readfile(txtSign.Text);
            bool success = ds.VerifyData(text, signedtext, txtpublic.Text);
            if(success)
                MessageBox.Show("True");
            else
                MessageBox.Show("False");
        }

        
    }
}
