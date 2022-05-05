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
    public class TaiSanYeuCauBLL
    {
        TaiSanYeuCauData cls = new TaiSanYeuCauData();

        public DataTable TS_TaiSanYeuCau_Load()
        {
            return cls.TS_TaiSanYeuCau_Load();
        }

        public DataTable TS_ChonTaiSanYeuCau_Load()
        {
            return cls.TS_ChonTaiSanYeuCau_Load();
        }

        public int TS_TaiSanYeuCau_Xoa(TaiSanYeuCauPublic Public)
        {
            return cls.TS_TaiSanYeuCau_Xoa(Public);
        }

        public int TS_TaiSanYeuCau_Them(TaiSanYeuCauPublic Public)
        {
            return cls.TS_TaiSanYeuCau_Them(Public);
        }

        public int TS_TaiSanYeuCau_Sua(TaiSanYeuCauPublic Public)
        {
            return cls.TS_TaiSanYeuCau_Sua(Public);
        }

        public DataTable TS_YeuCau_Load()
        {
            return cls.TS_YeuCau_Load();
        }

        public DataTable TS_NhomTaiSan_Load()
        {
            return cls.TS_NhomTaiSan_Load();
        }

        public SqlDataReader TS_CBB_TSYC_XuatXu_Load()
        {
            return cls.TS_CBB_TSYC_XuatXu_Load();
        }

        public SqlDataReader TS_CBB_TSYC_ThuongHieu_Load()
        {
            return cls.TS_CBB_TSYC_ThuongHieu_Load();
        }

        public SqlDataReader TS_CBB_TSYC_LoaiTaiSan_Load()
        {
            return cls.TS_CBB_TSYC_LoaiTaiSan_Load();
        }
    }
}
