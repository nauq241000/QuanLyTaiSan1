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
    public class QuanLyFileHoSoThanhToanBLL
    {
        QuanLyFileHoSoThanhToanData cls = new QuanLyFileHoSoThanhToanData();

        public DataTable QL_QuanLyFileHoSoThanhToan_Load()
        {
            return cls.QL_QuanLyFileHoSoThanhToan_Load();
        }

        public int QL_QuanLyFileHoSoThanhToan_Xoa(QuanLyFileHoSoThanhToanPublic Public)
        {
            return cls.QL_QuanLyFileHoSoThanhToan_Xoa(Public);
        }

        public int QL_QuanLyFileHoSoThanhToan_Them(QuanLyFileHoSoThanhToanPublic Public)
        {
            return cls.QL_QuanLyFileHoSoThanhToan_Them(Public);
        }

        public int QL_QuanLyFileHoSoThanhToan_Sua(QuanLyFileHoSoThanhToanPublic Public)
        {
            return cls.QL_QuanLyFileHoSoThanhToan_Sua(Public);
        }


        public SqlDataReader TS_QuanLyFileHoSoThanhToan_Load_R_Para_File(QuanLyFileHoSoThanhToanPublic Public)
        {
            return cls.TS_QuanLyFileHoSoThanhToan_Load_R_Para_File(Public);
        }
    }
}
