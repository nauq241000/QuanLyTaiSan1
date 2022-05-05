using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;

namespace Data
{
    public class DangNhapASPData
    {
        ClsKetNoi cls = new ClsKetNoi();
        public int CheckLogin(DangNhapASPPublic Public)
        {
            int thamso = 2;

            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@QLNS_MaNhanSu";
            bien[1] = "@NSDN_MatKhau";

            giatri[0] = Public.username;
            giatri[1] = Public.password;

            return cls.LayDuLieu_Count("SP_NhanSụDangNhap_Load_R_Para", bien, giatri, thamso);
        }

        public int Doimk(DangNhapASPPublic Public)
        {
            int thamso = 2;

            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@QLNS_MaNhanSu";
            bien[1] = "@NSDN_MatKhau";

            giatri[0] = Public.username;
            giatri[1] = Public.password;

            return cls.Update("SP_NhanSụDangNhap_Edit", bien, giatri, thamso);
        }


    }
}
