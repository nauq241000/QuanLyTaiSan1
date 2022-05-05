using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Public;

namespace Data
{
    public class TaiSanHienCoData
    {
        ClsKetNoi cls = new ClsKetNoi();

        public SqlDataReader TS_TaiSanHienCo_ASP_Load_R_Para_File(TaiSanHienCoPublic Public)
        {
            return cls.LayDuLieuASP_R("SELECT * FROM TaiSanHienCo_View WHERE TSHC_Ma = " + Public.TSHC_Ma);
        }

        public object TS_TSHC_ThietBiDiKem_ASP_Load(TaiSanHienCoPublic Public)
        {
            return cls.LayDuLieuASP("SELECT * FROM ThietBiDiKem_View WHERE TSHC_MaNhomThietBiDiKem = " + Public.TSHC_Ma);
        }

        public int TS_TaiSanHienCoASP_NSSD_Sua(TaiSanHienCoPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SQL
            int thamso = 4;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@TSHC_Ma";
            bien[1] = "@QLNS_MaNSSD";
            bien[2] = "@QLP_Ma";
            bien[3] = "@HT_UserEditor";

            giatri[0] = Public.TSHC_Ma;
            giatri[1] = Public.QLNS_MaNSSD;
            giatri[2] = Public.QLP_Ma;
            giatri[3] = Public.HT_UserEditor;

            return cls.Update("SP_TaiSanHienCoASP_NSSD_Edit", bien, giatri, thamso);
        }

        public int TS_TaiSanHienCoASP_TBDK_Sua(TaiSanHienCoPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SQL
            int thamso = 3;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@TSHC_Ma";
            bien[1] = "@TSHC_MaNhomThietBiDiKem";
            bien[2] = "@HT_UserEditor";

            giatri[0] = Public.TSHC_Ma;
            giatri[1] = Public.TSHC_MaNhomThietBiDiKem;
            giatri[2] = Public.HT_UserEditor;

            return cls.Update("SP_TaiSanHienCoASP_TBDK_Edit", bien, giatri, thamso);
        }

        public object TS_TSHC_ThietBiDiKemALL_ASP_Load()
        {
            return cls.LayDuLieuASP("SELECT * FROM ThietBiDiKemALL_View");
        }
    }
}
