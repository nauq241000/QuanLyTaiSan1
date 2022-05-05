using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhanCong
{
    public class NhanSu
    {
        private int _NS_MaNhanSu;

        public int NS_MaNhanSu
        {
            get { return _NS_MaNhanSu; }
            set { _NS_MaNhanSu = value; }
        }

        private int _NS_TongThoiGian;

        public int NS_TongThoiGian
        {
            get { return _NS_TongThoiGian; }
            set { _NS_TongThoiGian = value; }
        }

        private int _NS_SoCongViec;

        public int NS_SoCongViec
        {
            get { return _NS_SoCongViec; }
            set { _NS_SoCongViec = value; }
        }

        private CongViec[] _NS_CongViec;

        public CongViec[] NS_CongViec
        {
            get { return _NS_CongViec; }
            set { _NS_CongViec = value; }
        }
    }
}
