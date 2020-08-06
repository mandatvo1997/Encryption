using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto__.HashFolder
{
    public partial class HashForm : Form
    {
        public HashForm()
        {
            InitializeComponent();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            txtHash.Text = new HashClass().HashAl(txtInput.Text);
            txtLength.Text = txtHash.Text.Length.ToString();
        }
    }
}
