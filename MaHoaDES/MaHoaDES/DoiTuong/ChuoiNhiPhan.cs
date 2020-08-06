using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaHoaDES.DoiTuong
{
    class ChuoiNhiPhan
    {
        public int[] MangNhiPhan { get;   set; }
        private int _doDai;//{ get Man; private set; }
        string _text = "";

        public string Text
        {
            get { return GetText(); }
            //set { _text = value; }
        }
        public string GetText()
        {
            string str = "";
            foreach (var ch in MangNhiPhan)
            {
                str += ch.ToString();
            }
            return str;
        }
        public int DoDai
        {
            get { return MangNhiPhan.Length; }
            //set { _doDai = value; }
        }
        public ChuoiNhiPhan(int doDai)
        {
            MangNhiPhan = new int[doDai];
        }
        public ChuoiNhiPhan(int[] mangNhiPhan)
        {
            MangNhiPhan = mangNhiPhan;
        }
        public ChuoiNhiPhan(char kyTu)
        {
            MangNhiPhan = new int[8];
            int MaUnicode = (int)kyTu;
            int i = 7;
            while (MaUnicode > 0)
            {
                MangNhiPhan[i] = MaUnicode % 2;
                MaUnicode = MaUnicode / 2;
                i--;
            }
        }
        
        public ChuoiNhiPhan XOR(ChuoiNhiPhan Chuoi2)
        {
            if(DoDai!=Chuoi2.DoDai)
                return null;
            ChuoiNhiPhan ChuoiKQ = new ChuoiNhiPhan(DoDai);
            int x = 0,y=0;
            for (int i = 0; i < ChuoiKQ.DoDai; i++)
            {
                x = MangNhiPhan[i];
                y = Chuoi2.MangNhiPhan[i];
                if (x !=y)
                {
                    ChuoiKQ.MangNhiPhan[i] = 1;
                }
                else
                {
                    ChuoiKQ.MangNhiPhan[i] = 0;
                }
            }
            return ChuoiKQ;
        }
        public ChuoiNhiPhan DichTraiBit(int SoBitDich)
        {
            ChuoiNhiPhan KQ = new ChuoiNhiPhan(MangNhiPhan);
            int tam = 0;
            for (int i = 0; i < SoBitDich; i++)
            {
                tam = MangNhiPhan[0];
                for (int j = 0; j < MangNhiPhan.Length - 1; j++)
                {
                    KQ.MangNhiPhan[j] = MangNhiPhan[j + 1];
                }
                KQ.MangNhiPhan[MangNhiPhan.Length - 1] = tam;
            }
            return (KQ);
        }
         
        public ChuoiNhiPhan DichPhaiBit(int SoBitDich)
        {

            ChuoiNhiPhan KQ = new ChuoiNhiPhan(MangNhiPhan);
            int tam = 0;
            for (int i = 0; i < SoBitDich; i++)
            {
                tam = MangNhiPhan[MangNhiPhan.Length - 1];
                for (int j = MangNhiPhan.Length - 1; j >0; j--)
                {
                    KQ.MangNhiPhan[j] = MangNhiPhan[j -1];
                }
                KQ.MangNhiPhan[0] = tam;
            }
            return (KQ);
        }

        public ChuoiNhiPhan Cong(ChuoiNhiPhan chuoi2)
        {
            ChuoiNhiPhan ChuoiKQ = new ChuoiNhiPhan(chuoi2.DoDai + this.DoDai);
            for (int i = 0; i < DoDai; i++)
            {
                ChuoiKQ.MangNhiPhan[i] = MangNhiPhan[i];
            }
            for (int i = 0; i < chuoi2.DoDai; i++)
            {
                ChuoiKQ.MangNhiPhan[DoDai + i] = chuoi2.MangNhiPhan[i];
            }
            return ChuoiKQ;
        }
        public ChuoiNhiPhan[] ChiaDoi( )
        {
            ChuoiNhiPhan ChuoiTrai = new ChuoiNhiPhan(this.DoDai/2);
            ChuoiNhiPhan ChuoiPhai = new ChuoiNhiPhan(DoDai- ChuoiTrai.DoDai);
            for (int i = 0; i < ChuoiTrai.DoDai; i++)
            {
                ChuoiTrai.MangNhiPhan[i] = MangNhiPhan[i];
            }
            for (int i = 0; i < ChuoiPhai.DoDai; i++)
            {
                ChuoiPhai.MangNhiPhan[i] = MangNhiPhan[i+ChuoiTrai.DoDai];
            }
            return (new ChuoiNhiPhan[]{ChuoiTrai,ChuoiPhai});
        }
        public ChuoiNhiPhan[] Chia(int SoLuong)
        {
            ChuoiNhiPhan[] KQ = new ChuoiNhiPhan[SoLuong];
            ChuoiNhiPhan chuoi;
            int SoBit= DoDai/SoLuong;
            int[]  NhiPhan = new int[SoBit] ;
            for (int i = 0; i < SoLuong ; i++)
            {
                 NhiPhan = new int[SoBit];
                for (int j = i * SoBit; j < i * SoBit + SoBit; j++)
                {
                    NhiPhan[j - i * SoBit] = MangNhiPhan[j];
                }
                chuoi = new ChuoiNhiPhan(NhiPhan);
                KQ[i] = chuoi;
            }            
            return (KQ);
        }
        
        #region Cac Ham convert
        public static ChuoiNhiPhan ChuyenSoSangNhiPhan(int SoInput,int doDai)
        {

            //int doDai = (int)Math.Log(SoInput, 2);
            //if (SoInput == 0)
            //    doDai = 0;
            ChuoiNhiPhan ChuoiKQ = new ChuoiNhiPhan(doDai);
            int i = doDai-1;
            while (SoInput > 0)
            {
                ChuoiKQ.MangNhiPhan[i] = SoInput % 2;
                SoInput = SoInput / 2;
                i--;
            }
            return ChuoiKQ;
        }
        public static int ChuyenNhiPhanSangSo(ChuoiNhiPhan ChuoiVao)
        {
            int KQ = 0;
            for (int i = ChuoiVao.DoDai - 1; i >= 0; i--)
            {
                KQ += ChuoiVao.MangNhiPhan[i]* (int)Math.Pow(2, ChuoiVao.DoDai- i-1);
            }
            return KQ;
        }
        public static string ChuyenNhiPhanSangChu(ChuoiNhiPhan ChuoiVao)
        {
            int soChu = ChuoiVao.DoDai / 8;
            ChuoiNhiPhan[] MangChuoi = ChuoiVao.Chia(soChu);
            string KQ = "";
            foreach (var ch in MangChuoi)
            {
                KQ += (char)ChuoiNhiPhan.ChuyenNhiPhanSangSo(ch);
            }
            return KQ;
        }
        public static ChuoiNhiPhan ChuyenChuSangNhiPhan(string text)
        {
            
            StringBuilder binarystring = new StringBuilder(text.Length * 8);

            foreach (char word in text)
            {
                int binary = (int)word;
                int factor = 128;

                for (int i = 0; i < 8; i++)
                {
                    if (binary >= factor)
                    {
                        binary -= factor;
                        binarystring.Append("1");
                    }
                    else
                    {
                        binarystring.Append("0");
                    }
                    factor /= 2;
                }
            }

              binarystring.ToString();
            //foreach (var ch in chuoiVao)
            //{
            //    KQ = KQ.Cong(new ChuoiNhiPhan(ch));
            //}
            int[] MangNhiPhan = new int[binarystring.Length];

            for (int i = 0; i < binarystring.Length; i++)
            {
                MangNhiPhan[i] = int.Parse(binarystring[i].ToString());
            }
            ChuoiNhiPhan KQ = new ChuoiNhiPhan(MangNhiPhan);
            return KQ;
        }
        #endregion
    }
}
