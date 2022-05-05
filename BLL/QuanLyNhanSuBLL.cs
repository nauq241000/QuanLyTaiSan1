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
    public class QuanLyNhanSuBLL
    {
        QuanLyNhanSuData cls = new QuanLyNhanSuData();

        public DataTable TS_QuanLyNhanSu_Load()
        {
            return cls.TS_QuanLyNhanSu_Load();
        }
        

        public int TS_QuanLyNhanSu_Xoa(QuanLyNhanSuPublic Public)
        {
            return cls.TS_QuanLyNhanSu_Xoa(Public);
        }

        public int TS_QuanLyNhanSu_Them(QuanLyNhanSuPublic Public)
        {
            return cls.TS_QuanLyNhanSu_Them(Public);
        }

        public int TS_QuanLyNhanSu_Sua(QuanLyNhanSuPublic Public)
        {
            return cls.TS_QuanLyNhanSu_Sua(Public);
        }

        public DataTable TS_QuanLyNhanSu_DonVi_Load()
        {
            return cls.TS_QuanLyNhanSu_DonVi_Load();
        }

        public SqlDataReader TS_QuanLyNhanSu_Load_R_Para_File(QuanLyNhanSuPublic Public)
        {
            return cls.TS_QuanLyNhanSu_Load_R_Para_File(Public);
        }

        public DataTable TS_QuanLyNhanSuASP_Load()
        {
            return cls.TS_QuanLyNhanSuASP_Load();
        }

        public SqlDataReader TS_QuanLyNhanSu_ASP_Load_R_Para_File(QuanLyNhanSuPublic Public)
        {
            return cls.TS_QuanLyNhanSu_ASP_Load_R_Para_File(Public);
        }

        public int TS_QuanLyNhanSu_SoLuong(QuanLyNhanSuPublic Public)
        {
            return cls.TS_QuanLyNhanSu_SoLuong(Public);
        }

        public DataTable TS_QuanLyNhanSu_Loc(QuanLyNhanSuPublic Public)
        {
            return cls.TS_QuanLyNhanSu_Loc(Public);
        }

        public int AddLogin(NhanSuDangNhapPublic Public)
        {
            return cls.AddLogin(Public);
        }
    }
}
