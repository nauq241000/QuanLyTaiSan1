using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DanhMucCongViecData
    {
        ClsKetNoi cls = new ClsKetNoi();
      DanhMucCongViecPublic Public = new DanhMucCongViecPublic();

        public DataTable PC_DanhMucCongViec_Load()
        {
            return cls.LayDuLieu ("SP_DanhMucCongViec_Load");
        }


        public SqlDataReader PC_DanhMucCongViec_Load_R_Para_File(DanhMucCongViecPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@DMCV_Ma";
            giatri[0] = Public.DMCV_Ma;
            return cls.LayDuLieu_R("SP_DanhMucCongViec_Load_R_Para_File", bien, giatri, thamso);
        }

        public int PC_DanhMucCongViec_Xoa (DanhMucCongViecPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@DMCV_Ma";
            giatri[0] = Public.DMCV_Ma;
            return cls.Update("SP_DanhMucCongViec_Del", bien, giatri, thamso);
        }

        public int PC_DanhMucCongViec_Them(DanhMucCongViecPublic Public)
        {
            
            int thamso = 16;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@DMCV_NhomCongViec";
            bien[1] = "@DMCV_LoaiCongViec";
            bien[2] = "@QLDV_Ma";
            bien[3] = "@DMCV_TenCongViec";
            bien[4] = "@DMCV_DacTinh";
            bien[5] = "@DMCV_DiaDiem";
            bien[6] = "@DMCV_ThoiGianBatDau";
            bien[7] = "@DMCV_ThoiGianHoanThanh";
            bien[8] = "@DMCV_TenFileDinhKem";
            bien[9] = "@DMCV_DataFileDinhKem";
            bien[10] = "@DMCV_MoTa";
            bien[11] = "@DMCV_MucDoKho";
            bien[12] = "@DMCV_GhiChu";
            bien[13] = "@HT_UserCreate";
            bien[14] = "@DMCV_SuDung";
            bien[15] = "@DMCV_HienThi";

            giatri[0] = Public.DMCV_NhomCongViec;
            giatri[1] = Public.DMCV_LoaiCongViec;
            giatri[2] = Public.QLDV_Ma;
            giatri[3] = Public.DMCV_TenCongViec;
            giatri[4] = Public.DMCV_DacTinh;
            giatri[5] = Public.DMCV_DiaDiem;
            giatri[6] = Public.DMCV_ThoiGianBatDau;
            giatri[7] = Public.DMCV_ThoiGianHoanThanh;
            giatri[8] = Public.DMCV_TenFileDinhKem;
            giatri[9] = Public.DMCV_DataFileDinhKem;
            giatri[10] = Public.DMCV_MoTa;
            giatri[11] = Public.DMCV_MucDoKho;
            giatri[12] = Public.DMCV_GhiChu;
            giatri[13] = Public.HT_UserCreate;
            giatri[14] = Public.DMCV_SuDung;
            giatri[15] = Public.DMCV_HienThi;


            return cls.Update("SP_DanhMucCongViec_Add", bien, giatri, thamso);
        }

        public int PC_DanhMucCongViec_Sua(DanhMucCongViecPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SPC
            int thamso = 15;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@DMCV_Ma";
            bien[1] = "@DMCV_NhomCongViec";
            bien[2] = "@DMCV_LoaiCongViec";
            bien[3] = "@QLDV_Ma";
            bien[4] = "@DMCV_TenCongViec";
            bien[5] = "@DMCV_DacTinh";
            bien[6] = "@DMCV_DiaDiem";
            bien[7] = "@DMCV_ThoiGianBatDau";
            bien[8] = "@DMCV_ThoiGianHoanThanh";
            bien[9] = "@DMCV_TenFileDinhKem";
            bien[10] = "@DMCV_DataFileDinhKem";
            bien[11] = "@DMCV_MoTa";
            bien[12] = "@DMCV_MucDoKho";
            bien[13] = "@DMCV_GhiChu";
            bien[14] = "@HT_UserEditor";

            giatri[0] = Public.DMCV_Ma;
            giatri[1] = Public.DMCV_NhomCongViec;
            giatri[2] = Public.DMCV_LoaiCongViec;
            giatri[3] = Public.QLDV_Ma;
            giatri[4] = Public.DMCV_TenCongViec;
            giatri[5] = Public.DMCV_DacTinh;
            giatri[6] = Public.DMCV_DiaDiem;
            giatri[7] = Public.DMCV_ThoiGianBatDau;
            giatri[8] = Public.DMCV_ThoiGianHoanThanh;
            giatri[9] = Public.DMCV_TenFileDinhKem;
            giatri[10] = Public.DMCV_DataFileDinhKem;
            giatri[11] = Public.DMCV_MoTa;
            giatri[12] = Public.DMCV_MucDoKho;
            giatri[13] = Public.DMCV_GhiChu;
            giatri[14] = Public.HT_UserEditor;


            return cls.Update("SP_DanhMucCongViec_Edit", bien, giatri, thamso);
        }

        public SqlDataReader PC_CBB_DMCV_LoaiCongViec_Load()
        {
            return cls.LayDuLieu_R("SP_CBB_DMCV_LoaiCongViec_Load");
        }

        public SqlDataReader PC_CBB_DMCV_NhomCongViec_Load()
        {
            return cls.LayDuLieu_R("SP_CBB_DMCV_NhomCongViec_Load");
        }

        public DataTable PC_DanhMucCongViec_Loc(DanhMucCongViecPublic Public)
        {
            int thamso = 2;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@DMCV_NhomCongViec";
            bien[1] = "@DMCV_DiaDiem";

            giatri[0] = Public.DMCV_NhomCongViec;
            giatri[1] = Public.DMCV_DiaDiem;

            return cls.LayDuLieu("SP_DanhMucCongViec_Count", bien, giatri, thamso);
        }

        public int PC_DanhMucCongViec_SoLuong(DanhMucCongViecPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SPC
            int thamso = 2;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@DMCV_NhomCongViec";
            bien[1] = "@DMCV_DiaDiem";

            giatri[0] = Public.DMCV_NhomCongViec;
            giatri[1] = Public.DMCV_DiaDiem;

            return cls.LayDuLieu_Count("SP_DanhMucCongViec_Count", bien, giatri, thamso);
        }

        public DataTable PC_DanhMucCongViec_LoadDistinct()
        {
            return cls.LayDuLieu("SP_DanhMucCongViec_LoadDistinct");
        }


        public SqlDataReader PC_DanhMucCongViec_Load_R_Para()
        {
            return cls.LayDuLieu_R("SP_DanhMucCongViec_Load");
        }



        public DataTable PC_DanhMucCongViecNhomCongViec_Load(DanhMucCongViecPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@DMCV_NhomCongViec";
            giatri[0] = Public.DMCV_NhomCongViec;
            return cls.LayDuLieu("SP_DanhMucCongViecNhomCongViec_Load", bien, giatri, thamso);
        }
    }
}
