using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Data;
using Public;

namespace BLL
{
    public class TaiSanMuaSamBLL
    {
        TaiSanMuaSamData cls = new TaiSanMuaSamData();

        public DataTable TS_TaiSanMuaSam_Load()
        {
            return cls.TS_TaiSanMuaSam_Load();
        }

        public DataTable TS_ChonTaiSanMuaSam_Load()
        {
            return cls.TS_ChonTaiSanMuaSam_Load();
        }

        public int TS_TaiSanMuaSam_Xoa(TaiSanMuaSamPublic Public)
        {
            return cls.TS_TaiSanMuaSam_Xoa(Public);
        }

        public int TS_TaiSanMuaSam_Them(TaiSanMuaSamPublic Public)
        {
            return cls.TS_TaiSanMuaSam_Them(Public);
        }

        public int TS_TaiSanMuaSam_Sua(TaiSanMuaSamPublic Public)
        {
            return cls.TS_TaiSanMuaSam_Sua(Public);
        }

        public int TS_TaiSanMuaSam_SuaSoLuong(TaiSanMuaSamPublic Public)
        {
            return cls.TS_TaiSanMuaSam_SuaSoLuong(Public);
        }

        public DataTable TS_YeuCau_Load()
        {
            return cls.TS_YeuCau_Load();
        }

        public DataTable TS_NhomTaiSan_Load()
        {
            return cls.TS_NhomTaiSan_Load();
        }

        public System.Data.SqlClient.SqlDataReader TS_CBB_TSMS_BoPhanQuanLy_Load()
        {
            return cls.TS_CBB_TSMS_BoPhanQuanLy_Load();
        }
    }
}
