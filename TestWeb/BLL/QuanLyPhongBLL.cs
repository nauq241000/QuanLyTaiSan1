using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using System.Data.SqlClient;
using Public;
using System.Data;

namespace BLL
{
    public class QuanLyPhongBLL
    {

        QuanLyPhongData cls = new QuanLyPhongData();

        public SqlDataReader TS_QuanLyPhong_ASP_Load_R_Para_File(QuanLyPhongPublic Public)
        {
            return cls.TS_QuanLyPhong_ASP_Load_R_Para_File(Public);
        }

        public DataTable TS_QuanLyPhongASP_Load()
        {
            return cls.TS_QuanLyPhongASP_Load();
        }
    }
}
