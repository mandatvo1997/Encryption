using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crypto__.HashFolder;
using Crypto__.SymmetricFolder;
using Crypto__.AsymmetricFolder;
using Crypto__.DigitalSignatureFolder;
namespace Crypto__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            HashForm hash = new HashForm();
            hash.ShowDialog();
        }

        private void btnSym_Click(object sender, EventArgs e)
        {
            SymmetricForm sym = new SymmetricForm();
            sym.ShowDialog();
        }

        private void btnAsym_Click(object sender, EventArgs e)
        {
            AsymmetricForm asym = new AsymmetricForm();
            asym.ShowDialog();
        }

        private void btnDS_Click(object sender, EventArgs e)
        {
            DSForm ds = new DSForm();
            ds.ShowDialog();
        }

       

        
    }
}
