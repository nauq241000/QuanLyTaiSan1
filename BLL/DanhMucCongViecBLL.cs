using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;
using System.Data;
using Data;
using System.Data.SqlClient;

namespace BLL
{
    public class DanhMucCongViecBLL
    {
        DanhMucCongViecData cls = new DanhMucCongViecData();

        public DataTable PC_DanhMucCongViec_Load()
        {
            return cls.PC_DanhMucCongViec_Load();
        }

        public DataTable PC_DanhMucCongViec_Loc(DanhMucCongViecPublic Public)
        {
            return cls.PC_DanhMucCongViec_Loc(Public);
        }

        public SqlDataReader PC_DanhMucCongViec_Load_R_Para_File(DanhMucCongViecPublic Public)
        {
            return cls.PC_DanhMucCongViec_Load_R_Para_File(Public);
        }

        public int PC_DanhMucCongViec_Xoa(DanhMucCongViecPublic Public)
        {
            return cls.PC_DanhMucCongViec_Xoa(Public);
        }

        public int PC_DanhMucCongViec_Them(DanhMucCongViecPublic Public)
        {
            return cls.PC_DanhMucCongViec_Them(Public);
        }

        public int PC_DanhMucCongViec_Sua(DanhMucCongViecPublic Public)
        {
            return cls.PC_DanhMucCongViec_Sua(Public);
        }

        public SqlDataReader PC_CBB_DMCV_LoaiCongViec_Load()
        {
            return cls.PC_CBB_DMCV_LoaiCongViec_Load();
        }

        public SqlDataReader PC_CBB_DMCV_NhomCongViec_Load()
        {
            return cls.PC_CBB_DMCV_NhomCongViec_Load();
        }

        public int PC_DanhMucCongViec_SoLuong(DanhMucCongViecPublic Public)
        {
            return cls.PC_DanhMucCongViec_SoLuong(Public);
        }

        public DataTable PC_DanhMucCongViec_LoadDistinct()
        {
            return cls.PC_DanhMucCongViec_LoadDistinct();
        }

        public SqlDataReader PC_DanhMucCongViec_Load_R_Para()
        {
            return cls.PC_DanhMucCongViec_Load_R_Para();
        }

        public DataTable PC_DanhMucCongViecNhomCongViec_Load(DanhMucCongViecPublic Public)
        {
            return cls.PC_DanhMucCongViecNhomCongViec_Load(Public);
        }
    }
}
