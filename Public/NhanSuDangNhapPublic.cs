using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public
{
    public class NhanSuDangNhapPublic
    {
        private string _QLNS_MaNhanSu;

        public string QLNS_MaNhanSu
        {
            get { return _QLNS_MaNhanSu; }
            set { _QLNS_MaNhanSu = value; }
        }

        private string _NSDN_MatKhau;

        public string NSDN_MatKhau
        {
            get { return _NSDN_MatKhau; }
            set { _NSDN_MatKhau = value; }
        }
    }
}
