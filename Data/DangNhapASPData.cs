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

            bien[0] = "@username";
            bien[1] = "@password";

            giatri[0] = Public.username;
            giatri[1] = Public.password;

            return cls.LayDuLieu_Count("SP_DangNhapASP_CheckLogin", bien, giatri, thamso);
        }

        public int Doimk(DangNhapASPPublic Public)
        {
            int thamso = 2;

            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@username";
            bien[1] = "@password";

            giatri[0] = Public.username;
            giatri[1] = Public.password;

            return cls.Update("SP_DangNhapASP_ChangePassword", bien, giatri, thamso);
        }
    }
}
