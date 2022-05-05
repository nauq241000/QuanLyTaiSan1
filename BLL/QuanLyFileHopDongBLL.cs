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
    public class QuanLyFileHopDongBLL
    {
        QuanLyFileHopDongData cls = new QuanLyFileHopDongData();

        public DataTable QL_QuanLyFileHopDong_Load()
        {
            return cls.QL_QuanLyFileHopDong_Load();
        }

        public int QL_QuanLyFileHopDong_Xoa(QuanLyFileHopDongPublic Public)
        {
            return cls.QL_QuanLyFileHopDong_Xoa(Public);
        }

        public int QL_QuanLyFileHopDong_Them(QuanLyFileHopDongPublic Public)
        {
            return cls.QL_QuanLyFileHopDong_Them(Public);
        }

        public int QL_QuanLyFileHopDong_Sua(QuanLyFileHopDongPublic Public)
        {
            return cls.QL_QuanLyFileHopDong_Sua(Public);
        }


        public SqlDataReader TS_QuanLyFileHopDong_Load_R_Para_File(QuanLyFileHopDongPublic Public)
        {
            return cls.TS_QuanLyFileHopDong_Load_R_Para_File(Public);
        }
    }
}
