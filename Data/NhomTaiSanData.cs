using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;
using System.Data;

namespace Data
{
    public class NhomTaiSanData
    {
        ClsKetNoi cls = new ClsKetNoi();
        NhomTaiSanPublic Public = new NhomTaiSanPublic();

        public DataTable TS_NhomTaiSan_Load()
        {
            return cls.LayDuLieu("SP_NhomTaiSan_Load");
        }

        public int TS_NhomTaiSan_Xoa(NhomTaiSanPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@NTS_Ma";
            giatri[0] = Public.NTS_Ma;
            return cls.Update("SP_NhomTaiSan_Del", bien, giatri, thamso);
        }

        public int TS_NhomTaiSan_Them(NhomTaiSanPublic Public)
        {

            int thamso = 4;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];


            bien[0] = "@NTS_Ten";
            bien[1] = "@HT_UserCreate";
            bien[2] = "@NTS_SuDung";
            bien[3] = "@NTS_HienThi";

            giatri[0] = Public.NTS_Ten;
            giatri[1] = Public.HT_UserCreate;
            giatri[2] = Public.NTS_SuDung;
            giatri[3] = Public.NTS_HienThi;

            return cls.Update("SP_NhomTaiSan_Add", bien, giatri, thamso);
        }

        public int TS_NhomTaiSan_Sua(NhomTaiSanPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SQL
            int thamso = 3;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@NTS_Ma";
            bien[1] = "@NTS_Ten";
            bien[2] = "@HT_UserEditor";

            giatri[0] = Public.NTS_Ma;
            giatri[1] = Public.NTS_Ten;
            giatri[2] = Public.HT_UserEditor;

            return cls.Update("SP_NhomTaiSan_Edit", bien, giatri, thamso);
        }

    }
}
