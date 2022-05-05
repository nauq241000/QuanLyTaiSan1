using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class YeuCauData
    {
        ClsKetNoi cls = new ClsKetNoi();
        YeuCauPublic Public = new YeuCauPublic();

        public DataTable TS_YeuCau_Load()
        {
            return cls.LayDuLieu("SP_YeuCau_Load");
        }

        public int TS_YeuCau_Xoa(YeuCauPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@YC_Ma";
            giatri[0] = Public.YC_Ma;
            return cls.Update("SP_YeuCau_Del", bien, giatri, thamso);
        }

        public int TS_YeuCau_Them(YeuCauPublic Public)
        {

            int thamso = 11;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@YC_NhomYeuCau";
            bien[1] = "@YC_TenYeuCau";
            bien[2] = "@YC_NgayYeuCau";
            bien[3] = "@YC_DonViYeuCau";
            bien[4] = "@YC_NguoiDeNghi";
            bien[5] = "@YC_TenFile";
            bien[6] = "@YC_DataFile";
            bien[7] = "@YC_GhiChu";
            bien[8] = "@HT_UserCreate";
            bien[9] = "@YC_SuDung";
            bien[10] = "@YC_HienThi";

            giatri[0] = Public.YC_NhomYeuCau;
            giatri[1] = Public.YC_TenYeuCau;
            giatri[2] = Public.YC_NgayYeuCau;
            giatri[3] = Public.YC_DonViYeuCau;
            giatri[4] = Public.YC_NguoiDeNghi;
            giatri[5] = Public.YC_TenFile;
            giatri[6] = Public.YC_DataFile;
            giatri[7] = Public.YC_GhiChu;
            giatri[8] = Public.HT_UserCreate;
            giatri[9] = Public.YC_SuDung;
            giatri[10] = Public.YC_HienThi;

            return cls.Update("SP_YeuCau_Add", bien, giatri, thamso);
        }

        public int TS_YeuCau_Sua(YeuCauPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SQL
            int thamso = 10;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@YC_Ma";
            bien[1] = "@YC_NhomYeuCau";
            bien[2] = "@YC_TenYeuCau";
            bien[3] = "@YC_NgayYeuCau";
            bien[4] = "@YC_DonViYeuCau";
            bien[5] = "@YC_NguoiDeNghi";
            bien[6] = "@YC_TenFile";
            bien[7] = "@YC_DataFile";
            bien[8] = "@YC_GhiChu";
            bien[9] = "@HT_UserEditor";

            giatri[0] = Public.YC_Ma;
            giatri[1] = Public.YC_NhomYeuCau;
            giatri[2] = Public.YC_TenYeuCau;
            giatri[3] = Public.YC_NgayYeuCau;
            giatri[4] = Public.YC_DonViYeuCau;
            giatri[5] = Public.YC_NguoiDeNghi;
            giatri[6] = Public.YC_TenFile;
            giatri[7] = Public.YC_DataFile;
            giatri[8] = Public.YC_GhiChu;
            giatri[9] = Public.HT_UserEditor;

            return cls.Update("SP_YeuCau_Edit", bien, giatri, thamso);
        }

        public SqlDataReader TS_YeuCau_Load_R_Para_File(YeuCauPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@YC_Ma";
            giatri[0] = Public.YC_Ma;
            return cls.LayDuLieu_R("SP_YeuCau_Load_R_Para_File", bien, giatri, thamso);
        }


    }
}
