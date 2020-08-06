namespace MaHoaDES.BieuMau
{
    partial class frmMaHoaDES
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BoxTextCrypt = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKhoaVanBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVanBanNguon = new System.Windows.Forms.TextBox();
            this.txtVanBanDich = new System.Windows.Forms.TextBox();
            this.txtMaHoaVanBan = new System.Windows.Forms.Button();
            this.txtGiaiMaVanBan = new System.Windows.Forms.Button();
            this.BoxFileCrypt = new System.Windows.Forms.GroupBox();
            this.txtFileDich = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFileNguon = new System.Windows.Forms.TextBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.lblEncryptedFilename = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMaHoaFile = new System.Windows.Forms.Button();
            this.btnGiaiMaFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.BoxTextCrypt.SuspendLayout();
            this.BoxFileCrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProgress);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(13, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 54);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiến trình";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(8, 55);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(854, 20);
            this.progressBar1.TabIndex = 0;
            // 
            // BoxTextCrypt
            // 
            this.BoxTextCrypt.Controls.Add(this.label6);
            this.BoxTextCrypt.Controls.Add(this.txtKhoaVanBan);
            this.BoxTextCrypt.Controls.Add(this.label4);
            this.BoxTextCrypt.Controls.Add(this.label5);
            this.BoxTextCrypt.Controls.Add(this.label2);
            this.BoxTextCrypt.Controls.Add(this.txtVanBanNguon);
            this.BoxTextCrypt.Controls.Add(this.txtVanBanDich);
            this.BoxTextCrypt.Controls.Add(this.txtMaHoaVanBan);
            this.BoxTextCrypt.Controls.Add(this.txtGiaiMaVanBan);
            this.BoxTextCrypt.Location = new System.Drawing.Point(450, 12);
            this.BoxTextCrypt.Name = "BoxTextCrypt";
            this.BoxTextCrypt.Size = new System.Drawing.Size(432, 268);
            this.BoxTextCrypt.TabIndex = 26;
            this.BoxTextCrypt.TabStop = false;
            this.BoxTextCrypt.Text = "Mã hoá và Giải mã văn bản(Text)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(426, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Khoá thuộc hệ Hexa(16) đối với DES, ví dụ : 0123456789ABCDEF\r\nKhoá thuộc" +
    " hệ Hexa(32) đối với AES, ví dụ : 0123456789ABCDEF0123456789ABCDEF\r\n";
            // 
            // txtKhoaVanBan
            // 
            this.txtKhoaVanBan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKhoaVanBan.Location = new System.Drawing.Point(43, 88);
            this.txtKhoaVanBan.MaxLength = 16;
            this.txtKhoaVanBan.Name = "txtKhoaVanBan";
            this.txtKhoaVanBan.Size = new System.Drawing.Size(383, 20);
            this.txtKhoaVanBan.TabIndex = 17;
            this.txtKhoaVanBan.Text = "133457799BBCDFF1";
            this.txtKhoaVanBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoa_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kết quả mã hoá và giải mã";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Khoá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Text : ";
            // 
            // txtVanBanNguon
            // 
            this.txtVanBanNguon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtVanBanNguon.Location = new System.Drawing.Point(45, 25);
            this.txtVanBanNguon.Multiline = true;
            this.txtVanBanNguon.Name = "txtVanBanNguon";
            this.txtVanBanNguon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVanBanNguon.Size = new System.Drawing.Size(381, 56);
            this.txtVanBanNguon.TabIndex = 4;
            this.txtVanBanNguon.Text = "100010111011010001111010000011001111000010101001011000100110110101010001101011011" +
    "10100100111000101100001000110000110110101001110";
            // 
            // txtVanBanDich
            // 
            this.txtVanBanDich.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtVanBanDich.Location = new System.Drawing.Point(43, 156);
            this.txtVanBanDich.Multiline = true;
            this.txtVanBanDich.Name = "txtVanBanDich";
            this.txtVanBanDich.ReadOnly = true;
            this.txtVanBanDich.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVanBanDich.Size = new System.Drawing.Size(383, 64);
            this.txtVanBanDich.TabIndex = 3;
            // 
            // txtMaHoaVanBan
            // 
            this.txtMaHoaVanBan.Location = new System.Drawing.Point(97, 229);
            this.txtMaHoaVanBan.Name = "txtMaHoaVanBan";
            this.txtMaHoaVanBan.Size = new System.Drawing.Size(101, 25);
            this.txtMaHoaVanBan.TabIndex = 10;
            this.txtMaHoaVanBan.Text = "Mã hoá văn bản";
            this.txtMaHoaVanBan.UseVisualStyleBackColor = true;
            this.txtMaHoaVanBan.Click += new System.EventHandler(this.txtMaHoaVanBan_Click);
            // 
            // txtGiaiMaVanBan
            // 
            this.txtGiaiMaVanBan.Location = new System.Drawing.Point(226, 229);
            this.txtGiaiMaVanBan.Name = "txtGiaiMaVanBan";
            this.txtGiaiMaVanBan.Size = new System.Drawing.Size(102, 25);
            this.txtGiaiMaVanBan.TabIndex = 13;
            this.txtGiaiMaVanBan.Text = "Giải mã văn bản";
            this.txtGiaiMaVanBan.UseVisualStyleBackColor = true;
            this.txtGiaiMaVanBan.Click += new System.EventHandler(this.txtGiaiMaVanBan_Click);
            // 
            // BoxFileCrypt
            // 
            this.BoxFileCrypt.Controls.Add(this.txtFileDich);
            this.BoxFileCrypt.Controls.Add(this.label9);
            this.BoxFileCrypt.Controls.Add(this.label7);
            this.BoxFileCrypt.Controls.Add(this.txtFileNguon);
            this.BoxFileCrypt.Controls.Add(this.txtKhoa);
            this.BoxFileCrypt.Controls.Add(this.label1);
            this.BoxFileCrypt.Controls.Add(this.label8);
            this.BoxFileCrypt.Controls.Add(this.btnChonFile);
            this.BoxFileCrypt.Controls.Add(this.lblEncryptedFilename);
            this.BoxFileCrypt.Controls.Add(this.label3);
            this.BoxFileCrypt.Controls.Add(this.btnMaHoaFile);
            this.BoxFileCrypt.Controls.Add(this.btnGiaiMaFile);
            this.BoxFileCrypt.Location = new System.Drawing.Point(13, 12);
            this.BoxFileCrypt.Name = "BoxFileCrypt";
            this.BoxFileCrypt.Size = new System.Drawing.Size(434, 268);
            this.BoxFileCrypt.TabIndex = 24;
            this.BoxFileCrypt.TabStop = false;
            this.BoxFileCrypt.Text = "Mã hoá và giải mã 1 file";
            // 
            // txtFileDich
            // 
            this.txtFileDich.Location = new System.Drawing.Point(71, 44);
            this.txtFileDich.Name = "txtFileDich";
            this.txtFileDich.ReadOnly = true;
            this.txtFileDich.Size = new System.Drawing.Size(313, 20);
            this.txtFileDich.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Đổi tên file";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(426, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "Khoá thuộc hệ Hexa(16) đối với DES, ví dụ : 0123456789ABCDEF\r\nKhoá thuộc" +
    " hệ Hexa(32) đối với AES, ví dụ : 0123456789ABCDEF0123456789ABCDEF";
            // 
            // txtFileNguon
            // 
            this.txtFileNguon.Location = new System.Drawing.Point(71, 15);
            this.txtFileNguon.Name = "txtFileNguon";
            this.txtFileNguon.ReadOnly = true;
            this.txtFileNguon.Size = new System.Drawing.Size(243, 20);
            this.txtFileNguon.TabIndex = 5;
            // 
            // txtKhoa
            // 
            this.txtKhoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKhoa.Location = new System.Drawing.Point(71, 88);
            this.txtKhoa.MaxLength = 16;
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(314, 20);
            this.txtKhoa.TabIndex = 23;
            this.txtKhoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoa_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "File : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Khoá";
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(320, 13);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(64, 23);
            this.btnChonFile.TabIndex = 16;
            this.btnChonFile.Text = "Files..";
            this.btnChonFile.UseVisualStyleBackColor = true;
            // 
            // lblEncryptedFilename
            // 
            this.lblEncryptedFilename.AutoSize = true;
            this.lblEncryptedFilename.Location = new System.Drawing.Point(8, 48);
            this.lblEncryptedFilename.Name = "lblEncryptedFilename";
            this.lblEncryptedFilename.Size = new System.Drawing.Size(0, 13);
            this.lblEncryptedFilename.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // btnMaHoaFile
            // 
            this.btnMaHoaFile.Location = new System.Drawing.Point(102, 229);
            this.btnMaHoaFile.Name = "btnMaHoaFile";
            this.btnMaHoaFile.Size = new System.Drawing.Size(89, 25);
            this.btnMaHoaFile.TabIndex = 12;
            this.btnMaHoaFile.Text = "Mã hoá file";
            this.btnMaHoaFile.UseVisualStyleBackColor = true;
            // 
            // btnGiaiMaFile
            // 
            this.btnGiaiMaFile.Location = new System.Drawing.Point(225, 229);
            this.btnGiaiMaFile.Name = "btnGiaiMaFile";
            this.btnGiaiMaFile.Size = new System.Drawing.Size(89, 25);
            this.btnGiaiMaFile.TabIndex = 11;
            this.btnGiaiMaFile.Text = "Giải mã file";
            this.btnGiaiMaFile.UseVisualStyleBackColor = true;
            // 
            // frmMaHoaDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BoxTextCrypt);
            this.Controls.Add(this.BoxFileCrypt);
            this.Name = "frmMaHoaDES";
            this.Text = "frmMaHoaDES";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BoxTextCrypt.ResumeLayout(false);
            this.BoxTextCrypt.PerformLayout();
            this.BoxFileCrypt.ResumeLayout(false);
            this.BoxFileCrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox BoxTextCrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKhoaVanBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVanBanNguon;
        private System.Windows.Forms.TextBox txtVanBanDich;
        private System.Windows.Forms.Button txtMaHoaVanBan;
        private System.Windows.Forms.Button txtGiaiMaVanBan;
        private System.Windows.Forms.GroupBox BoxFileCrypt;
        private System.Windows.Forms.TextBox txtFileDich;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFileNguon;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Label lblEncryptedFilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMaHoaFile;
        private System.Windows.Forms.Button btnGiaiMaFile;
    }
}