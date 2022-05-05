using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using System.Data;
using Public;
using System.Data.SqlClient;

namespace BLL
{
    public class QuanLyPhongBLL
    {
        QuanLyPhongData cls = new QuanLyPhongData();

        public DataTable TS_QuanLyPhong_Load()
        {
            return cls.TS_QuanLyPhong_Load();
        }

        public int TS_QuanLyPhong_Xoa(QuanLyPhongPublic Public)
        {
            return cls.TS_QuanLyPhong_Xoa(Public);
        }

        public int TS_QuanLyPhong_Them(QuanLyPhongPublic Public)
        {
            return cls.TS_QuanLyPhong_Them(Public);
        }

        public int TS_QuanLyPhong_Sua(QuanLyPhongPublic Public)
        {
            return cls.TS_QuanLyPhong_Sua(Public);
        }

        public DataTable TS_QuanLyPhong_NhanSu_Load()
        {
            return cls.TS_QuanLyPhong_NhanSu_Load();
        }

        public SqlDataReader TS_QuanLyPhong_Load_R_Para_File(QuanLyPhongPublic Public)
        {
            return cls.TS_QuanLyPhong_Load_R_Para_File(Public);
        }

        public SqlDataReader TS_CBB_QLP_LoaiPhong_Load()
        {
            return cls.TS_CBB_QLP_LoaiPhong_Load();
        }

        public DataTable TS_QuanLyPhongASP_Load()
        {
            return cls.TS_QuanLyPhongASP_Load();
        }

        public SqlDataReader TS_QuanLyPhong_ASP_Load_R_Para_File(QuanLyPhongPublic Public)
        {
            return cls.TS_QuanLyPhong_ASP_Load_R_Para_File(Public);
        }
    }
}
