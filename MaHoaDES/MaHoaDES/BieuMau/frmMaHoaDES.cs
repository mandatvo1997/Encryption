using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaHoaDES.DoiTuong;

namespace MaHoaDES.BieuMau
{
    public partial class frmMaHoaDES : Form
    {
        public frmMaHoaDES()
        {
            InitializeComponent();
        }

        
        private void txtKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !Char.IsControl(e.KeyChar) &&!ChuoiHexa.BoHexa.Contains(e.KeyChar.ToString()))
                e.Handled = true;

        }
        Khoa KhoaVanVan;
        DES64Bit MaHoaDES64;
        private void txtMaHoaVanBan_Click(object sender, EventArgs e)
        {
            KhoaVanVan = new Khoa(txtKhoaVanBan.Text);
            MaHoaDES64 = new DES64Bit(KhoaVanVan);

            txtVanBanDich.Text= MaHoaDES64.ThucHienDES(txtVanBanNguon.Text,1);
        }

        private void txtGiaiMaVanBan_Click(object sender, EventArgs e)
        {
            KhoaVanVan = new Khoa(txtKhoaVanBan.Text);
            MaHoaDES64 = new DES64Bit(KhoaVanVan);

            txtVanBanDich.Text = MaHoaDES64.ThucHienDES(txtVanBanNguon.Text, -1);
        }
    }
}
