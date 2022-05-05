using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Public;
using System.Data;

namespace Data
{
    public class QuanLyNhanSuData
    {

        ClsKetNoi cls = new ClsKetNoi();

        public SqlDataReader TS_QuanLyNhanSu_ASP_Load_R_Para_File(QuanLyNhanSuPublic Public)
        {
            return cls.LayDuLieuASP_R("SELECT * FROM QuanLyNhanSu_View WHERE QLNS_Ma = " + Public.QLNS_Ma);
        }

        public DataTable TS_QuanLyNhanSuASP_Load()
        {
            return cls.LayDuLieuASP("SP_QuanLyNhanSu_Load");
        }

        public DataTable CV_ChiTietCongViec_GetMa(string Ma)
        {
            int thamso = 1;

            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@QLNS_MaNhanSu";

            giatri[0] = Ma;

            return cls.LayDuLieu("SP_ChiTietCongViec_GetMa", bien, giatri, thamso);
        }

    }
}
