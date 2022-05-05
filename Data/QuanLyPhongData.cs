using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class QuanLyPhongData
    {
        ClsKetNoi cls = new ClsKetNoi();
        QuanLyPhongPublic Public = new QuanLyPhongPublic();

        public DataTable TS_QuanLyPhong_Load()
        {
            return cls.LayDuLieu("SP_QuanLyPhong_Load");
        }

        public int TS_QuanLyPhong_Xoa(QuanLyPhongPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@QLP_Ma";
            giatri[0] = Public.QLP_Ma;
            return cls.Update("SP_QuanLyPhong_Del", bien, giatri, thamso);
        }

        public int TS_QuanLyPhong_Them(QuanLyPhongPublic Public)
        {

            int thamso = 27;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@QLP_CoSo";
            bien[1] = "@QLP_DiaDiem";
            bien[2] = "@QLP_ToaNha";
            bien[3] = "@QLP_MaPhong";
            bien[4] = "@QLP_TenPhong";
            bien[5] = "@QLP_LoaiPhong";
            bien[6] = "@QLP_MoTa";
            bien[7] = "@QLP_TinhTrangSuDung";
            bien[8] = "@QLP_KichThuocDai";
            bien[9] = "@QLP_KichThuocRong";
            bien[10] = "@QLP_KichThuocCao";
            bien[11] = "@QLP_SoCho";
            bien[12] = "@QLP_BGSV_Ban";
            bien[13] = "@QLP_BGSV_Ghe";
            bien[14] = "@QLP_BGGV_Ban";
            bien[15] = "@QLP_BGGV_Ghe";
            bien[16] = "@QLP_NSSD_Ma";
            bien[17] = "@QLP_NSQL_Ma";
            bien[18] = "@QLP_AnhPhong";
            bien[19] = "@QLP_BanVe";
            bien[20] = "@QLP_GhiChu";
            bien[21] = "@QLP_HoanThanh";
            bien[22] = "@QLP_HT_MoTa";
            bien[23] = "@QLP_HT_MoTaChiTiet";
            bien[24] = "@HT_UserCreate ";
            bien[25] = "@QLP_SuDung ";
            bien[26] = "@QLP_HienThi ";

            giatri[0] = Public.QLP_CoSo;
            giatri[1] = Public.QLP_DiaDiem;
            giatri[2] = Public.QLP_ToaNha;
            giatri[3] = Public.QLP_MaPhong;
            giatri[4] = Public.QLP_TenPhong;
            giatri[5] = Public.QLP_LoaiPhong;
            giatri[6] = Public.QLP_MoTa;
            giatri[7] = Public.QLP_TinhTrangSuDung;
            giatri[8] = Public.QLP_KichThuocDai;
            giatri[9] = Public.QLP_KichThuocRong;
            giatri[10] = Public.QLP_KichThuocCao;
            giatri[11] = Public.QLP_SoCho;
            giatri[12] = Public.QLP_BGSV_Ban;
            giatri[13] = Public.QLP_BGSV_Ghe;
            giatri[14] = Public.QLP_BGGV_Ban;
            giatri[15] = Public.QLP_BGGV_Ghe;
            giatri[16] = Public.QLP_NSSD_Ma;
            giatri[17] = Public.QLP_NSQL_Ma;
            giatri[18] = Public.QLP_AnhPhong;
            giatri[19] = Public.QLP_BanVe;
            giatri[20] = Public.QLP_GhiChu;
            giatri[21] = Public.QLP_HoanThanh;
            giatri[22] = Public.QLP_HT_MoTa;
            giatri[23] = Public.QLP_HT_MoTaChiTiet;
            giatri[24] = Public.HT_UserCreate;
            giatri[25] = Public.QLP_SuDung;
            giatri[26] = Public.QLP_HienThi;

            return cls.Update("SP_QuanLyPhong_Add", bien, giatri, thamso);
        }

        public int TS_QuanLyPhong_Sua(QuanLyPhongPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SQL
            int thamso = 26;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@QLP_Ma ";
            bien[1] = "@QLP_CoSo";
            bien[2] = "@QLP_DiaDiem";
            bien[3] = "@QLP_ToaNha";
            bien[4] = "@QLP_MaPhong";
            bien[5] = "@QLP_TenPhong";
            bien[6] = "@QLP_LoaiPhong";
            bien[7] = "@QLP_MoTa";
            bien[8] = "@QLP_TinhTrangSuDung";
            bien[9] = "@QLP_KichThuocDai";
            bien[10] = "@QLP_KichThuocRong";
            bien[11] = "@QLP_KichThuocCao";
            bien[12] = "@QLP_SoCho";
            bien[13] = "@QLP_BGSV_Ban";
            bien[14] = "@QLP_BGSV_Ghe";
            bien[15] = "@QLP_BGGV_Ban";
            bien[16] = "@QLP_BGGV_Ghe";
            bien[17] = "@QLP_NSSD_Ma";
            bien[18] = "@QLP_NSQL_Ma";
            bien[19] = "@QLP_AnhPhong";
            bien[20] = "@QLP_BanVe";
            bien[21] = "@QLP_GhiChu";
            bien[22] = "@QLP_HoanThanh";
            bien[23] = "@QLP_HT_MoTa";
            bien[24] = "@QLP_HT_MoTaChiTiet";
            bien[25] = "@HT_UserEditor ";

            giatri[0] = Public.QLP_Ma;
            giatri[1] = Public.QLP_CoSo;
            giatri[2] = Public.QLP_DiaDiem;
            giatri[3] = Public.QLP_ToaNha;
            giatri[4] = Public.QLP_MaPhong;
            giatri[5] = Public.QLP_TenPhong;
            giatri[6] = Public.QLP_LoaiPhong;
            giatri[7] = Public.QLP_MoTa;
            giatri[8] = Public.QLP_TinhTrangSuDung;
            giatri[9] = Public.QLP_KichThuocDai;
            giatri[10] = Public.QLP_KichThuocRong;
            giatri[11] = Public.QLP_KichThuocCao;
            giatri[12] = Public.QLP_SoCho;
            giatri[13] = Public.QLP_BGSV_Ban;
            giatri[14] = Public.QLP_BGSV_Ghe;
            giatri[15] = Public.QLP_BGGV_Ban;
            giatri[16] = Public.QLP_BGGV_Ghe;
            giatri[17] = Public.QLP_NSSD_Ma;
            giatri[18] = Public.QLP_NSQL_Ma;
            giatri[19] = Public.QLP_AnhPhong;
            giatri[20] = Public.QLP_BanVe;
            giatri[21] = Public.QLP_GhiChu;
            giatri[22] = Public.QLP_HoanThanh;
            giatri[23] = Public.QLP_HT_MoTa;
            giatri[24] = Public.QLP_HT_MoTaChiTiet;
            giatri[25] = Public.HT_UserEditor;

            return cls.Update("SP_QuanLyPhong_Edit", bien, giatri, thamso);
        }

        public DataTable TS_QuanLyPhong_NhanSu_Load()
        {
            //Load các records => Demo_HienThi = True
            return cls.LayDuLieu("SP_QuanLyPhong_NhanSu_Load");
        }

        public SqlDataReader TS_QuanLyPhong_Load_R_Para_File(QuanLyPhongPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@QLP_Ma";
            giatri[0] = Public.QLP_Ma;
            return cls.LayDuLieu_R("SP_QuanLyPhong_Load_R_Para_File", bien, giatri, thamso);
        }

        public SqlDataReader TS_CBB_QLP_LoaiPhong_Load()
        {
            return cls.LayDuLieu_R("SP_CBB_QLP_LoaiPhong_Load");
        }

        public DataTable TS_QuanLyPhongASP_Load()
        {
            return cls.LayDuLieu("SP_QuanLyPhong_Load");
        }

        public SqlDataReader TS_QuanLyPhong_ASP_Load_R_Para_File(QuanLyPhongPublic Public)
        {
            ClsKetNoiASP clsASP = new ClsKetNoiASP();
            return clsASP.LayDuLieuASP_R("SELECT * FROM QuanLyPhong_View WHERE QLP_Ma = "+Public.QLP_Ma);
        }
    }
}
