using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class PhanCongCongViecData
    {
        ClsKetNoi cls = new ClsKetNoi();
        PhanCongCongViecPublic Public = new PhanCongCongViecPublic();

        public DataTable PC_PhanCongCongViec_Load()
        {
            return cls.LayDuLieu("SP_PhanCongCongViec_Load");
        }

        public int PC_PhanCongCongViec_Xoa(PhanCongCongViecPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@PCCV_Ma";
            giatri[0] = Public.PCCV_Ma;
            return cls.Update("SP_PhanCongCongViec_Del", bien, giatri, thamso);
        }

        public int PC_PhanCongCongViec_Them(PhanCongCongViecPublic Public)
        {

            int thamso = 9;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@QLNS_MaNSTH";
            bien[1] = "@QLNS_MaNSKT";
            bien[2] = "@QLNS_MaNSQL";
            bien[3] = "@DMCV_Ma";
            bien[4] = "@PCCV_TrongTrach";
            bien[5] = "@PCCV_GhiChu";
            bien[6] = "@HT_UserCreate ";
            bien[7] = "@PCCV_SuDung ";
            bien[8] = "@PCCV_HienThi ";


            giatri[0] = Public.QLNS_MaNSTH;
            giatri[1] = Public.QLNS_MaNSKT;
            giatri[2] = Public.QLNS_MaNSQL;
            giatri[3] = Public.DMCV_Ma;
            giatri[4] = Public.PCCV_TrongTrach;
            giatri[5] = Public.PCCV_GhiChu;
            giatri[6] = Public.HT_UserCreate;
            giatri[7] = Public.PCCV_SuDung;
            giatri[8] = Public.PCCV_HienThi;


            return cls.Update("SP_PhanCongCongViec_Add", bien, giatri, thamso);
        }

        public int PC_PhanCongCongViec_Sua(PhanCongCongViecPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SPC
            int thamso = 8;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@PCCV_Ma";
            bien[1] = "@QLNS_MaNSTH";
            bien[2] = "@QLNS_MaNSKT";
            bien[3] = "@QLNS_MaNSQL";
            bien[4] = "@DMCV_Ma";
            bien[5] = "@PCCV_TrongTrach";
            bien[6] = "@PCCV_GhiChu";
            bien[7] = "@HT_UserEditor";


            giatri[0] = Public.PCCV_Ma;
            giatri[1] = Public.QLNS_MaNSTH;
            giatri[2] = Public.QLNS_MaNSKT;
            giatri[3] = Public.QLNS_MaNSQL;
            giatri[4] = Public.DMCV_Ma;
            giatri[5] = Public.PCCV_TrongTrach;
            giatri[6] = Public.PCCV_GhiChu;
            giatri[7] = Public.HT_UserEditor;


            return cls.Update("SP_PhanCongCongViec_Edit", bien, giatri, thamso);
        }


        public SqlDataReader PC_PhanCongCongViec_Load_R_Para()
        {
            return cls.LayDuLieu_R("SP_PhanCongCongViec_Load");
        }


        public DataTable PC_PhanCongCongViec_LoadNSKT()
        {
            return cls.LayDuLieu("SP_PhanCongCongViec_LoadNSKT");
        }
    }
}
