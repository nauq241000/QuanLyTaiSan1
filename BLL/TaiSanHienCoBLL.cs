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
    public class TaiSanHienCoBLL
    {
        TaiSanHienCoData cls = new TaiSanHienCoData();

        public DataTable TS_TaiSanHienCo_Load()
        {
            return cls.TS_TaiSanHienCo_Load();
        }

        public int TS_TaiSanHienCo_Xoa(TaiSanHienCoPublic Public)
        {
            return cls.TS_TaiSanHienCo_Xoa(Public);
        }

        public int TS_TaiSanHienCo_Them(TaiSanHienCoPublic Public)
        {
            return cls.TS_TaiSanHienCo_Them(Public);
        }

        public int TS_TaiSanHienCo_Sua(TaiSanHienCoPublic Public)
        {
            return cls.TS_TaiSanHienCo_Sua(Public);
        }

        public int TS_TaiSanHienCoASP_NSSD_Sua(TaiSanHienCoPublic Public)
        {
            return cls.TS_TaiSanHienCoASP_NSSD_Sua(Public);
        }

        public int TS_TaiSanHienCoASP_TBDK_Sua(TaiSanHienCoPublic Public)
        {
            return cls.TS_TaiSanHienCoASP_TBDK_Sua(Public);
        }

        public SqlDataReader TS_TaiSanHienCo_Load_R_Para_File(TaiSanHienCoPublic Public)
        {
            return cls.TS_TaiSanHienCo_Load_R_Para_File(Public);
        }

        public SqlDataReader TS_TaiSanHienCo_ASP_Load_R_Para_File(TaiSanHienCoPublic Public)
        {
            return cls.TS_TaiSanHienCo_ASP_Load_R_Para_File(Public);
        }

        public DataTable TS_TSHC_QuanLyPhong_Load()
        {
            return cls.TS_TSHC_QuanLyPhong_Load();
        }

        public DataTable TS_TSHC_QuanLyFileHopDong_Load()
        {
            return cls.TS_TSHC_QuanLyFileHopDong_Load();
        }

        public int TS_TaiSanHienCo_AddQRCode(TaiSanHienCoPublic Public)
        {
            return cls.TS_TaiSanHienCo_AddQRCode(Public);
        }

        public DataTable TS_QRCode_Load()
        {
            return cls.TS_QRCode_Load();
        }

        public int TS_QRCode_Sua(QRcodePublic Public)
        {
            return cls.TS_QRCode_Sua(Public);
        }

        public DataTable TS_TSHC_ThietBiDiKem_Load(TaiSanHienCoPublic Public)
        {
            return cls.TS_TSHC_ThietBiDiKem_Load(Public);
        }

        public SqlDataReader TS_CBB_TSHC_BoPhanQuanLy_Load()
        {
            return cls.TS_CBB_TSHC_BoPhanQuanLy_Load();
        }

        public SqlDataReader TS_CBB_TSHC_ThuongHieu_Load()
        {
            return cls.TS_CBB_TSHC_ThuongHieu_Load();
        }

        public SqlDataReader TS_CBB_TSHC_XuatXu_Load()
        {
            return cls.TS_CBB_TSHC_XuatXu_Load();
        }

        public object TS_TSHC_ThietBiDiKem_ASP_Load(TaiSanHienCoPublic Public)
        {
            return cls.TS_TSHC_ThietBiDiKem_ASP_Load(Public);
        }

        public object TS_TSHC_ThietBiDiKemALL_ASP_Load()
        {
            return cls.TS_TSHC_ThietBiDiKemALL_ASP_Load();
        }
    }
}
