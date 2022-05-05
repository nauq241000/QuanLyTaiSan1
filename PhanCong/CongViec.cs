using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhanCong
{
    public class CongViec
    {
        private int _CV_ThoiGian;

        public int CV_ThoiGian
        {
            get { return _CV_ThoiGian; }
            set { _CV_ThoiGian = value; }
        }

        private int _CV_MaCongViec;

        public int CV_MaCongViec
        {
            get { return _CV_MaCongViec; }
            set { _CV_MaCongViec = value; }
        }

        private DateTime _CV_NgayBatDau;

        public DateTime CV_NgayBatDau
        {
            get { return _CV_NgayBatDau; }
            set { _CV_NgayBatDau = value; }
        }
    }
}
