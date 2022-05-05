using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using System.Data;
using Public;

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
    }
}
