using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Public;

namespace BLL
{
    public class NhanSuDangNhapBLL
    {
        NhanSuDangNhapData cls = new NhanSuDangNhapData();

        public int CheckLogin(NhanSuDangNhapPublic Public)
        {
            return cls.CheckLogin(Public);
        }

        public int Doimk(NhanSuDangNhapPublic Public)
        {
            return cls.Doimk(Public);
        }
    }
}
