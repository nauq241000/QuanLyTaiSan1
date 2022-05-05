using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Public;

namespace BLL
{
    public class DangNhapASPBLL
    {
        DangNhapASPData cls = new DangNhapASPData();
        public int CheckLogin(DangNhapASPPublic Public)
        {
            return cls.CheckLogin(Public);
        }

        public int Doimk(DangNhapASPPublic Public)
        {
            return cls.Doimk(Public);
        }
    }
}
