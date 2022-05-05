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
    public class PhanCongCongViecBLL
    {
        PhanCongCongViecData cls = new PhanCongCongViecData();

        public DataTable PC_PhanCongCongViec_Load()
        {
            return cls.PC_PhanCongCongViec_Load();
        }

        public DataTable PC_PhanCongCongViec_LoadNSKT()
        {
            return cls.PC_PhanCongCongViec_LoadNSKT();
        }
        

        public int PC_PhanCongCongViec_Xoa(PhanCongCongViecPublic Public)
        {
            return cls.PC_PhanCongCongViec_Xoa(Public);
        }

        public int PC_PhanCongCongViec_Them(PhanCongCongViecPublic Public)
        {
            return cls.PC_PhanCongCongViec_Them(Public);
        }

        public int PC_PhanCongCongViec_Sua(PhanCongCongViecPublic Public)
        {
            return cls.PC_PhanCongCongViec_Sua(Public);
        }

        public SqlDataReader PC_PhanCongCongViec_Load_R_Para()
        {
            return cls.PC_PhanCongCongViec_Load_R_Para();
        }
    }
}
