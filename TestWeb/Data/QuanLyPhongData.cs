using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Public;
using System.Data;

namespace Data
{
    public class QuanLyPhongData
    {

        ClsKetNoi cls = new ClsKetNoi();

        public SqlDataReader TS_QuanLyPhong_ASP_Load_R_Para_File(QuanLyPhongPublic Public)
        {
            return cls.LayDuLieuASP_R("SELECT * FROM QuanLyPhong_View WHERE QLP_Ma = " + Public.QLP_Ma);
        }

        public DataTable TS_QuanLyPhongASP_Load()
        {
            return cls.LayDuLieu("SP_QuanLyPhong_Load");
        }
    }
}
