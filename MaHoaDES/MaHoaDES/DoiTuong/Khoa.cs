using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaHoaDES.HangSo;

namespace MaHoaDES.DoiTuong
{
    class Khoa
    {
        //ChuoiHexa KhoaChinh;
        ChuoiNhiPhan KhoaChinhNhiPhan;
        public ChuoiNhiPhan[] DayKhoaPhu {get; private set;}
        public Khoa(string khoa)
        {
            //KhoaChinh = new ChuoiHexa(khoa);
            //if (!KhoaChinh.KiemTra())
            //{
            //    return;
            //}
            string hex = ChuyenChuSangHe16(khoa);
            KhoaChinhNhiPhan = He16SangNhiPhan(hex) ;
        }
        public string ChuyenChuSangHe16(string text)
        {
            string hexstring = "";
            foreach (char word in text)
            {
                hexstring += String.Format("{0:X}", Convert.ToInt32(word));
            }
            return hexstring;
        }
        public ChuoiNhiPhan He16SangNhiPhan(string hexstring)
        {

            string binarystring = "";
 
                for (int i = 0; i < hexstring.Length; i++)
                {
                    int hex = Convert.ToInt32(hexstring[i].ToString(), 16);

                    int factor = 8;

                    for (int j = 0; j < 4; j++)
                    {
                        if (hex >= factor)
                        {
                            hex -= factor;
                            binarystring += "1";
                        }
                        else
                        {
                            binarystring += "0";
                        }
                        factor /= 2;
                    }
                }
            

            ChuoiNhiPhan chuoiNhiPhan = new ChuoiNhiPhan(binarystring.Length );
            for (int i=0;i< binarystring.Length;i++)
            {
                chuoiNhiPhan.MangNhiPhan[i] = int.Parse(binarystring[i].ToString());
            }
            return chuoiNhiPhan;
        }
        public bool KiemTraKhoa()
        {
            return (KhoaChinhNhiPhan.DoDai % 8==0);
            //if (!KhoaChinh.KiemTra()|| KhoaChinh.DoDai>8)
            //{
            //    return false;
            //}
            return true;
        }
        public void SinhKhoaCon(int MaHoaHayGiaiMa) // 1 la ma hoa -1 la giai ma
        {
            DayKhoaPhu = new ChuoiNhiPhan[16];
            ChuoiNhiPhan ChuoiTrai,ChuoiPhai, MotKhoaPhu;
            // PC1
            ChuoiNhiPhan[] ChuoiSauPC1 = CacThongSo.TinhPC1(KhoaChinhNhiPhan);
            ChuoiTrai = ChuoiSauPC1[0];
            ChuoiPhai = ChuoiSauPC1[1];
             
            for (int i = 0; i < 16; i++)
            {
                // Dich bit
                if (MaHoaHayGiaiMa == 1) // ma hoa
                {
                    ChuoiTrai = ChuoiTrai.DichTraiBit(CacThongSo.soBitDichTaiCacVong[i]);
                    ChuoiPhai = ChuoiPhai.DichTraiBit(CacThongSo.soBitDichTaiCacVong[i]);
                }
                else
                {
                    ChuoiTrai = ChuoiTrai.DichPhaiBit(CacThongSo.soBitDichTaiCacVong[i]);
                    ChuoiPhai = ChuoiPhai.DichPhaiBit(CacThongSo.soBitDichTaiCacVong[i]);
                }
                // PC2
                MotKhoaPhu = CacThongSo.TinhPC2(ChuoiTrai, ChuoiPhai);
                if (MaHoaHayGiaiMa == 1)
                {
                    DayKhoaPhu[i] = MotKhoaPhu;
                }
                else
                {
                    DayKhoaPhu[15-i] = MotKhoaPhu;
                }                
            }

        }
    }
}
