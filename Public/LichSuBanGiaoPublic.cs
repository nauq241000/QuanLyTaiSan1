using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public
{
    public class LichSuBanGiaoPublic
    {
        private int _TSHC_Ma;

        public int TSHC_Ma
        {
            get { return _TSHC_Ma; }
            set { _TSHC_Ma = value; }
        }

        private int _QLNS_Ma;

        public int QLNS_Ma
        {
            get { return _QLNS_Ma; }
            set { _QLNS_Ma = value; }
        }

        private int _QLP_Ma;

        public int QLP_Ma
        {
            get { return _QLP_Ma; }
            set { _QLP_Ma = value; }
        }

        private DateTime? _LSBG_NgayBanGiao;

        public DateTime? LSBG_NgayBanGiao
        {
            get { return _LSBG_NgayBanGiao; }
            set { _LSBG_NgayBanGiao = value; }
        }
    }
}
