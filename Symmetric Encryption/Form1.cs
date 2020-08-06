using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;

namespace Symmetric_Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte[] encrypted;
        private void abtnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtKey.Text == "" || txtInput.Text == "")
            {
                try
                {
                    MessageBox.Show(this, "You need write down input & key");
                }
                catch { }
            }
            else
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                UTF8Encoding utf8 = new UTF8Encoding();
                TripleDESCryptoServiceProvider tpdes = new TripleDESCryptoServiceProvider();

                tpdes.Key = md5.ComputeHash(utf8.GetBytes(txtKey.Text));
                tpdes.Mode = CipherMode.ECB;
                tpdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform trans = tpdes.CreateEncryptor();
                encrypted = trans.TransformFinalBlock(utf8.GetBytes(txtInput.Text), 0, utf8.GetBytes(txtInput.Text).Length);
                txtEncrypt.Text = BitConverter.ToString(encrypted).Replace("-", "").Trim();
            }
        }

        private void abtnDecrypt_Click(object sender, EventArgs e)
        {
            if (txtKey.Text != "")
            {
                try
                {
                    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                    UTF8Encoding utf8 = new UTF8Encoding();
                    TripleDESCryptoServiceProvider tpdes = new TripleDESCryptoServiceProvider();

                    tpdes.Key = md5.ComputeHash(utf8.GetBytes(txtKey.Text));
                    tpdes.Mode = CipherMode.ECB;
                    tpdes.Padding = PaddingMode.PKCS7;
                    ICryptoTransform trans = tpdes.CreateDecryptor();
                    txtDecrypt.Text = utf8.GetString(trans.TransformFinalBlock(encrypted, 0, encrypted.Length));
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "Wrong key. Pls check your key");
                }
            }
            else
            {
                if (txtEncrypt.Text != "")
                {
                    MessageBox.Show(this, "Filled right Key");
                }
                else
                {
                    MessageBox.Show(this, "Encrypt First");
                }
            }
        }
    }
}
