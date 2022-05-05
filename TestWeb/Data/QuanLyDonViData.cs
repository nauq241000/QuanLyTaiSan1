using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Public;

namespace Data
{
    public class QuanLyDonViData
    {

        ClsKetNoi cls = new ClsKetNoi();

        public SqlDataReader TS_QuanLyDonVi_ASP_Load_R_Para_File(QuanLyDonViPublic Public)
        {
            return cls.LayDuLieuASP_R("SELECT * FROM QuanLyDonVi_View WHERE QLDV_Ma = " + Public.QLDV_Ma);
        }
    }
}
