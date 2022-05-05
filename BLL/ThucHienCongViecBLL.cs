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
    public class ThucHienCongViecBLL
    {
        ThucHienCongViecData cls = new ThucHienCongViecData();

        public DataTable PC_ThucHienCongViec_Load()
        {
            return cls.PC_ThucHienCongViec_Load();
        }

        public int PC_ThucHienCongViec_Xoa(ThucHienCongViecPublic Public)
        {
            return cls.PC_ThucHienCongViec_Xoa(Public);
        }

        public int PC_ThucHienCongViec_Them(ThucHienCongViecPublic Public)
        {
            return cls.PC_ThucHienCongViec_Them(Public);
        }

        public int PC_ThucHienCongViec_Sua(ThucHienCongViecPublic Public)
        {
            return cls.PC_ThucHienCongViec_Sua(Public);
        }

        public SqlDataReader PC_ThucHienCongViec_Load_R_Para_File(ThucHienCongViecPublic Public)
        {
            return cls.PC_ThucHienCongViec_Load_R_Para_File(Public);
        }
    }
}
