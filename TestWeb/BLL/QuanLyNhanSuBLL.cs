using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Public;
using Data;
using System.Data;

namespace BLL
{
    public class QuanLyNhanSuBLL
    {

        QuanLyNhanSuData cls = new QuanLyNhanSuData();

        public SqlDataReader TS_QuanLyNhanSu_ASP_Load_R_Para_File(QuanLyNhanSuPublic Public)
        {
            return cls.TS_QuanLyNhanSu_ASP_Load_R_Para_File(Public);
        }

        public DataTable TS_QuanLyNhanSuASP_Load()
        {
            return cls.TS_QuanLyNhanSuASP_Load();
        }

        public DataTable CV_ChiTietCongViec_GetMa(string Ma)
        {

            return cls.CV_ChiTietCongViec_GetMa(Ma);
        }
    }
}
