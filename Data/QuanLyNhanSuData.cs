using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class QuanLyNhanSuData
    {
        ClsKetNoi cls = new ClsKetNoi();
        
        QuanLyNhanSuPublic Public = new QuanLyNhanSuPublic();

        public DataTable TS_QuanLyNhanSu_Load()
        {
            return cls.LayDuLieu("SP_QuanLyNhanSu_Load");
        }


        public int TS_QuanLyNhanSu_Xoa(QuanLyNhanSuPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@QLNS_Ma";
            giatri[0] = Public.QLNS_Ma;
            return cls.Update("SP_QuanLyNhanSu_Del", bien, giatri, thamso);
        }

        public int TS_QuanLyNhanSu_Them(QuanLyNhanSuPublic Public)
        {

            int thamso = 17;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0]="QLDV_Ma";
            bien[1]="QLNS_CoSo";
            bien[2]="QLNS_MaNhanSu";
            bien[3]="QLNS_HoTen";
            bien[4]="QLNS_ChucVu";
            bien[5]="QLNS_DiaChi";
            bien[6]="QLNS_SoCMT";
            bien[7]="QLNS_NgayCap";
            bien[8]="QLNS_NoiCap";
            bien[9]="QLNS_SoDienThoai";
            bien[10]="QLNS_Email";
            bien[11]="QLNS_GhiChu";
            bien[12]="QLNS_TenFile";
            bien[13]="QLNS_DataFile";
            bien[14]="HT_USER_Create";
            bien[15]="QLNS_HienThi";
            bien[16] = "QLNS_SuDung";


            giatri[0] = Public.QLDV_Ma;
            giatri[1] = Public.QLNS_CoSo;
            giatri[2] = Public.QLNS_MaNhanSu;
            giatri[3] = Public.QLNS_HoTen;
            giatri[4] = Public.QLNS_ChucVu;
            giatri[5] = Public.QLNS_DiaChi;
            giatri[6] = Public.QLNS_SoCMT;
            giatri[7] = Public.QLNS_NgayCap;
            giatri[8] = Public.QLNS_NoiCap;
            giatri[9] = Public.QLNS_SoDienThoai;
            giatri[10] = Public.QLNS_Email;
            giatri[11] = Public.QLNS_GhiChu;
            giatri[12] = Public.QLNS_TenFile;
            giatri[13] = Public.QLNS_DataFile;
            giatri[14] = Public.HT_USER_Create;
            giatri[15] = Public.QLNS_HienThi;
            giatri[16] = Public.QLNS_SuDung;

            return cls.Update("SP_QuanLyNhanSu_Add", bien, giatri, thamso);
        }

        public int TS_QuanLyNhanSu_Sua(QuanLyNhanSuPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SQL
            int thamso = 16;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "QLNS_Ma";
            bien[1] = "QLDV_Ma";
            bien[2] = "QLNS_CoSo";
            bien[3] = "QLNS_MaNhanSu";
            bien[4] = "QLNS_HoTen";
            bien[5] = "QLNS_ChucVu";
            bien[6] = "QLNS_DiaChi";
            bien[7] = "QLNS_SoCMT";
            bien[8] = "QLNS_NgayCap";
            bien[9] = "QLNS_NoiCap";
            bien[10] = "QLNS_SoDienThoai";
            bien[11] = "QLNS_Email";
            bien[12] = "QLNS_GhiChu";
            bien[13] = "QLNS_TenFile";
            bien[14] = "QLNS_DataFile";
            bien[15] = "HT_USER_Editor";


            giatri[0] = Public.QLNS_Ma;
            giatri[1] = Public.QLDV_Ma;
            giatri[2] = Public.QLNS_CoSo;
            giatri[3] = Public.QLNS_MaNhanSu;
            giatri[4] = Public.QLNS_HoTen;
            giatri[5] = Public.QLNS_ChucVu;
            giatri[6] = Public.QLNS_DiaChi;
            giatri[7] = Public.QLNS_SoCMT;
            giatri[8] = Public.QLNS_NgayCap;
            giatri[9] = Public.QLNS_NoiCap;
            giatri[10] = Public.QLNS_SoDienThoai;
            giatri[11] = Public.QLNS_Email;
            giatri[12] = Public.QLNS_GhiChu;
            giatri[13] = Public.QLNS_TenFile;
            giatri[14] = Public.QLNS_DataFile;
            giatri[15] = Public.HT_USER_Editor;


            return cls.Update("SP_QuanLyNhanSu_Edit", bien, giatri, thamso);
        }

        public DataTable TS_QuanLyNhanSu_DonVi_Load()
        {
            //Load các records => Demo_HienThi = True
            return cls.LayDuLieu("SP_QuanLyNhanSu_DonVi_Load");
        }

        public SqlDataReader TS_QuanLyNhanSu_Load_R_Para_File(QuanLyNhanSuPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@QLNS_Ma";
            giatri[0] = Public.QLNS_Ma;
            return cls.LayDuLieu_R("SP_QuanLyNhanSu_Load_R_Para_File", bien, giatri, thamso);
        }
        

        public DataTable TS_QuanLyNhanSuASP_Load()
        {
            return cls.LayDuLieu("SP_QuanLyNhanSu_Load");
        }

        public SqlDataReader TS_QuanLyNhanSu_ASP_Load_R_Para_File(QuanLyNhanSuPublic Public)
        {
            ClsKetNoiASP clsASP = new ClsKetNoiASP();
            return clsASP.LayDuLieuASP_R("SELECT * FROM QuanLyNhanSu_View WHERE QLNS_Ma = "+Public.QLNS_Ma);
        }

        public int TS_QuanLyNhanSu_SoLuong(QuanLyNhanSuPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SPC
            int thamso = 2;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@QLNS_ChuyenMon";
            bien[1] = "@QLNS_CoSo";

            giatri[0] = Public.QLNS_ChuyenMon;
            giatri[1] = Public.QLNS_CoSo;

            return cls.LayDuLieu_Count("SP_QuanLyNhanSu_Count", bien, giatri, thamso);
        }

        public DataTable TS_QuanLyNhanSu_Loc(QuanLyNhanSuPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SPC
            int thamso = 2;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@QLNS_ChuyenMon";
            bien[1] = "@QLNS_CoSo";

            giatri[0] = Public.QLNS_ChuyenMon;
            giatri[1] = Public.QLNS_CoSo;

            return cls.LayDuLieu("SP_QuanLyNhanSu_Count", bien, giatri, thamso);
        }

        public int AddLogin(NhanSuDangNhapPublic Public)
        {
            int thamso = 2;

            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@QLNS_MaNhanSu";
            bien[1] = "@NSDN_MatKhau";

            giatri[0] = Public.QLNS_MaNhanSu;
            giatri[1] = Public.NSDN_MatKhau;

            return cls.LayDuLieu_Count("SP_NhanSụDangNhap_Add", bien, giatri, thamso);
        }
    }
}
