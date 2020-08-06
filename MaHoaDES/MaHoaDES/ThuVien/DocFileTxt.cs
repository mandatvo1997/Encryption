using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace AOC.ThuVien
{
    class DocFileTxt
    {
        private static string LayChuTuFile(string duongDan)
        {

            FileStream fs = new FileStream(duongDan, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str;
            //doc tat ca du lieu trong file luu vao str;
            str = sr.ReadToEnd();
            //set text cua textbox1 = str;
            
            sr.Close();
            fs.Close();
            return str;
        }
        public static double[,] LayDuLieu(string path)
        {
            string str = LayChuTuFile(path);
            int SoThanhPho = 0;

            str = str.Trim();
            string[] Dong = str.Split(new char[] {'\n'});
            double[,] KetQua;//= new List<Point>();

            string str1 = Dong[0];
            str1 = str1.Replace("  ", " ");
            str1=str1.Trim();
            string[] mangChu= str1.Split(new char[]{' '});
            SoThanhPho = mangChu.Length;

            KetQua = new double[SoThanhPho, SoThanhPho];
            int i = 0,j=0;
            double KC=0;
            foreach (var MotDong in Dong)
            {
                str1 = MotDong.Replace("  ", " ");
                str1 = MotDong.Trim();
                mangChu = MotDong.Split(new char[] { ' ' });
                j = 0;
                foreach (var giaTri in mangChu)
                {
                    
                    if (i != j)
                    {
                        KC = int.Parse(giaTri);
                        if (KC == -1)
                        {
                            j++;
                            continue;
                        }
                        KetQua[i, j] = KC;
                        KetQua[j, i] = KC;
                    }
                    j++;
                }
                i++;
            }           
            return KetQua;
        }
    }
}
