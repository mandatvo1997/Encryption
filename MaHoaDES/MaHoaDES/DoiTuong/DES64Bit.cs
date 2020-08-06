using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaHoaDES.HangSo;

namespace MaHoaDES.DoiTuong
{
    class DES64Bit
    {
        public Khoa KhoaDES { get; private set; }
        //public ChuoiNhiPhan ChuoiDuocMaHoa { get; private set; }
        public DES64Bit(Khoa key)
        {
            this.KhoaDES = key;
            
        }
        public ChuoiNhiPhan ThucHienDES(ChuoiNhiPhan ChuoiVaoDai, int MaHoaHayGiaiMa)// 1 ma hoa, -1 giai ma
        {
            KhoaDES.SinhKhoaCon(MaHoaHayGiaiMa);


            ChuoiNhiPhan[] DSChuoiVao = ChuoiVaoDai.Chia(ChuoiVaoDai.DoDai / 64);
            ChuoiNhiPhan ChuoiVao,ChuoiKQ;
            ChuoiKQ = new ChuoiNhiPhan(0);
            for (int k = 0; k < DSChuoiVao.Length; k++)
            {
                ChuoiVao = DSChuoiVao[k];
                ChuoiNhiPhan[] ChuoiSauIP;
                ChuoiNhiPhan ChuoiSauIP_1;
                ChuoiNhiPhan L, R, F, TG;
                ChuoiSauIP = CacThongSo.TinhIP(ChuoiVao, MaHoaHayGiaiMa);
                L = ChuoiSauIP[0];
                R = ChuoiSauIP[1];

                for (int i = 0; i < 16; i++)
                {
                    F = HamF(R, KhoaDES.DayKhoaPhu[i]);
                    L = L.XOR(F);
                    TG = L;
                    L = R;
                    R = TG;
                }
                ChuoiSauIP_1 = CacThongSo.TinhIP_1( R,L, MaHoaHayGiaiMa);
                ChuoiKQ = ChuoiKQ.Cong(ChuoiSauIP_1);
            }
            return ChuoiKQ;
        }
        public string ThucHienDES(string ChuoiVao, int MaHoaHayGiaiMa)// 1 ma hoa, -1 giai ma
        {
            ChuoiNhiPhan chuoiNhiPhan = ChuoiNhiPhan.ChuyenChuSangNhiPhan(ChuoiVao);

            //ChuoiHexa chuoiHexa = new ChuoiHexa(ChuoiVao);
            //chuoiNhiPhan = chuoiHexa.chuoiNhiPhan;

            ChuoiNhiPhan KQ=ThucHienDES( ChinhDoDaiChuoiVao( chuoiNhiPhan),MaHoaHayGiaiMa);
            return KQ.Text;
            return ChuoiNhiPhan.ChuyenNhiPhanSangChu(KQ);
        }
        public ChuoiNhiPhan ChinhDoDaiChuoiVao(ChuoiNhiPhan vao)
        {
            if (vao.DoDai % 64 != 0)
            {
                int mode = vao.DoDai % 64;
                int thieu = 64 - mode;
                int[] mang = new int[vao.DoDai + thieu];
                for (int i = 0; i < vao.MangNhiPhan.Length; i++)
                {
                    mang[i] = vao.MangNhiPhan[i];
                }
                return (new ChuoiNhiPhan(mang));
            }
            else
                return vao;
        }
        private ChuoiNhiPhan HamF(ChuoiNhiPhan chuoiVao, ChuoiNhiPhan KhoaCon)
        {
            ChuoiNhiPhan KQ=CacThongSo.TinhE(chuoiVao);
            KQ = KQ.XOR(KhoaCon);
            KQ = CacThongSo.TinhSBox(KQ);
            KQ = CacThongSo.TinhP(KQ);
            return KQ;
        }

    }
}
