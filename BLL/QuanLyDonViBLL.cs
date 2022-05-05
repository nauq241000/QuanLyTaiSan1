using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;
using Data;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class QuanLyDonViBLL
    {
        QuanLyDonViData cls = new QuanLyDonViData();

        public DataTable TS_QuanLyDonVi_Load()
        {
            return cls.TS_QuanLyDonVi_Load();
        }

        public int TS_QuanLyDonVi_Xoa(QuanLyDonViPublic Public)
        {
            return cls.TS_QuanLyDonVi_Xoa(Public);
        }

        public int TS_QuanLyDonVi_Them(QuanLyDonViPublic Public)
        {
            return cls.TS_QuanLyDonVi_Them(Public);
        }

        public int TS_QuanLyDonVi_Sua(QuanLyDonViPublic Public)
        {
            return cls.TS_QuanLyDonVi_Sua(Public);
        }

        public SqlDataReader TS_QuanLyDonVi_Load_R_Para_File(QuanLyDonViPublic Public)
        {
            return cls.TS_QuanLyDonVi_Load_R_Para_File(Public);
        }

        public SqlDataReader TS_QuanLyDonVi_ASP_Load_R_Para_File(QuanLyDonViPublic Public)
        {
            return cls.TS_QuanLyDonVi_ASP_Load_R_Para_File(Public);
        }
    }
}
