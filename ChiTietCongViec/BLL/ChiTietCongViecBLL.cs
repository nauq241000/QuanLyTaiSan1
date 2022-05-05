using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Data;
using Public;

namespace BLL
{
    public class ChiTietCongViecBLL
    {

        ChiTietCongViecData cls = new ChiTietCongViecData();

        public DataTable CV_ChiTietCongViec_Load(int Ma)
        {

            return cls.CV_ChiTietCongViec_Load(Ma);
        }

        public DataTable CV_ChiTietCongViec_GetMa(string Ma)
        {

            return cls.CV_ChiTietCongViec_GetMa(Ma);
        }

        public int CV_ChiTietCongViec_Edit(ChiTietCongViecPublic Public)
        {

            return cls.CV_ChiTietCongViec_Edit(Public);
        }
    }
}
