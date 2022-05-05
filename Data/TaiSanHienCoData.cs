using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class TaiSanHienCoData
    {
        ClsKetNoi cls = new ClsKetNoi();
        TaiSanHienCoPublic Public = new TaiSanHienCoPublic();

        public DataTable TS_TaiSanHienCo_Load()
        {
            return cls.LayDuLieu("SP_TaiSanHienCo_Load");
        }

        public int TS_TaiSanHienCo_Xoa(TaiSanHienCoPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@TSHC_Ma";
            giatri[0] = Public.TSHC_Ma;
            return cls.Update("SP_TaiSanHienCo_Del", bien, giatri, thamso);
        }

        public int TS_TaiSanHienCo_Them(TaiSanHienCoPublic Public)
        {

            int thamso = 29;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@NTS_Ma";
            bien[1] = "@QLNS_MaNSQL";
            bien[2] = "@QLNS_MaNSSD";
            bien[3] = "@QLP_Ma";
            bien[4] = "@TSHC_LoaiTaiSan";
            bien[5] = "@TSHC_TenTaiSan";
            bien[6] = "@TSHC_MaNhomThietBiDiKem";
            bien[7] = "@TSHC_BoPhanQuanLy";
            bien[8] = "@TSHC_QR_Code";
            bien[9] = "@TSHC_TinhTrang";
            bien[10] = "@TSHC_MoTa";
            bien[11] = "@TSHC_NguonGocTaiSan";
            bien[12] = "@TSHC_ThuongHieu";
            bien[13] = "@TSHC_NamSanXuat";
            bien[14] = "@QLFHD_Ma";
            bien[15] = "@TSHC_XuatXu";
            bien[16] = "@TSHC_SoSeri";
            bien[17] = "@TSHC_KichThuocDai";
            bien[18] = "@TSHC_KichThuocRong";
            bien[19] = "@TSHC_KichThuocCao";
            bien[20] = "@TSHC_ThoiGianBaoHanh";
            bien[21] = "@TSHC_TenFileGiayToKemTheo";
            bien[22] = "@TSHC_DataFileGiayToKemTheo";
            bien[23] = "@TSHC_AnhChup";
            bien[24] = "@TSHC_GhiChu";
            bien[25] = "@TSHC_NgayBanGiao";
            bien[26] = "@HT_UserCreate";
            bien[27] = "@TSHC_SuDung";
            bien[28] = "@TSHC_HienThi";

            giatri[0] = Public.NTS_Ma;
            giatri[1] = Public.QLNS_MaNSQL;
            giatri[2] = Public.QLNS_MaNSSD;
            giatri[3] = Public.QLP_Ma;
            giatri[4] = Public.TSHC_LoaiTaiSan;
            giatri[5] = Public.TSHC_TenTaiSan;
            giatri[6] = Public.TSHC_MaNhomThietBiDiKem;
            giatri[7] = Public.TSHC_BoPhanQuanLy;
            giatri[8] = Public.TSHC_QR_Code;
            giatri[9] = Public.TSHC_TinhTrang;
            giatri[10] = Public.TSHC_MoTa;
            giatri[11] = Public.TSHC_NguonGocTaiSan;
            giatri[12] = Public.TSHC_ThuongHieu;
            giatri[13] = Public.TSHC_NamSanXuat;
            giatri[14] = Public.QLFHD_Ma;
            giatri[15] = Public.TSHC_XuatXu;
            giatri[16] = Public.TSHC_SoSeri;
            giatri[17] = Public.TSHC_KichThuocDai;
            giatri[18] = Public.TSHC_KichThuocRong;
            giatri[19] = Public.TSHC_KichThuocCao;
            giatri[20] = Public.TSHC_ThoiGianBaoHanh;         
            giatri[21] = Public.TSHC_TenFileGiayToKemTheo;
            giatri[22] = Public.TSHC_DataFileGiayToKemTheo;
            giatri[23] = Public.TSHC_AnhChup;
            giatri[24] = Public.TSHC_GhiChu;
            giatri[25] = Public.TSHC_NgayBanGiao;
            giatri[26] = Public.HT_UserCreate;
            giatri[27] = Public.TSHC_SuDung;
            giatri[28] = Public.TSHC_HienThi;

            return cls.Update("SP_TaiSanHienCo_Add", bien, giatri, thamso);
        }

        public int TS_TaiSanHienCo_Sua(TaiSanHienCoPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SQL
            int thamso = 29;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@TSHC_Ma";
            bien[1] = "@NTS_Ma";
            bien[2] = "@QLNS_MaNSQL";
            bien[3] = "@QLNS_MaNSSD";
            bien[4] = "@QLP_Ma";
            bien[5] = "@TSHC_LoaiTaiSan";
            bien[6] = "@TSHC_TenTaiSan";
            bien[7] = "@TSHC_MaNhomThietBiDiKem";
            bien[8] = "@TSHC_BoPhanQuanLy";
            bien[9] = "@TSHC_QR_Code";
            bien[10] = "@TSHC_TinhTrang";
            bien[11] = "@TSHC_MoTa";
            bien[12] = "@TSHC_NguonGocTaiSan";
            bien[13] = "@TSHC_ThuongHieu";
            bien[14] = "@TSHC_NamSanXuat";
            bien[15] = "@TSHC_NgayDuaVaoSuDung";
            bien[16] = "@QLFHD_Ma";
            bien[17] = "@TSHC_XuatXu";
            bien[18] = "@TSHC_SoSeri";
            bien[19] = "@TSHC_KichThuocDai";
            bien[20] = "@TSHC_KichThuocRong";
            bien[21] = "@TSHC_KichThuocCao";
            bien[22] = "@TSHC_ThoiGianBaoHanh";
            bien[23] = "@TSHC_TenFileGiayToKemTheo";
            bien[24] = "@TSHC_DataFileGiayToKemTheo";
            bien[25] = "@TSHC_AnhChup";
            bien[26] = "@TSHC_GhiChu";
            bien[27] = "@TSHC_NgayBanGiao";
            bien[28] = "@HT_UserEditor";

            giatri[0] = Public.TSHC_Ma;
            giatri[1] = Public.NTS_Ma;
            giatri[2] = Public.QLNS_MaNSQL;
            giatri[3] = Public.QLNS_MaNSSD;
            giatri[4] = Public.QLP_Ma;
            giatri[5] = Public.TSHC_LoaiTaiSan;
            giatri[6] = Public.TSHC_TenTaiSan;
            giatri[7] = Public.TSHC_MaNhomThietBiDiKem;
            giatri[8] = Public.TSHC_BoPhanQuanLy;
            giatri[9] = Public.TSHC_QR_Code;
            giatri[10] = Public.TSHC_TinhTrang;
            giatri[11] = Public.TSHC_MoTa;
            giatri[12] = Public.TSHC_NguonGocTaiSan;
            giatri[13] = Public.TSHC_ThuongHieu;
            giatri[14] = Public.TSHC_NamSanXuat;
            giatri[15] = Public.TSHC_NgayDuaVaoSuDung;
            giatri[16] = Public.QLFHD_Ma;
            giatri[17] = Public.TSHC_XuatXu;
            giatri[18] = Public.TSHC_SoSeri;
            giatri[19] = Public.TSHC_KichThuocDai;
            giatri[20] = Public.TSHC_KichThuocRong;
            giatri[21] = Public.TSHC_KichThuocCao;
            giatri[22] = Public.TSHC_ThoiGianBaoHanh;
            giatri[23] = Public.TSHC_TenFileGiayToKemTheo;
            giatri[24] = Public.TSHC_DataFileGiayToKemTheo;
            giatri[25] = Public.TSHC_AnhChup;
            giatri[26] = Public.TSHC_GhiChu;
            giatri[27] = Public.TSHC_NgayBanGiao;
            giatri[28] = Public.HT_UserEditor;

            return cls.Update("SP_TaiSanHienCo_Edit", bien, giatri, thamso);
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

        public SqlDataReader TS_TaiSanHienCo_Load_R_Para_File(TaiSanHienCoPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@TSHC_Ma";
            giatri[0] = Public.TSHC_Ma;
            return cls.LayDuLieu_R("SP_TaiSanHienCo_Load_R_Para_File", bien, giatri, thamso);
        }

        public SqlDataReader TS_TaiSanHienCo_ASP_Load_R_Para_File(TaiSanHienCoPublic Public)
        {
            ClsKetNoiASP clsASP = new ClsKetNoiASP();
            return clsASP.LayDuLieuASP_R("SELECT * FROM TaiSanHienCo_View WHERE TSHC_Ma = "+Public.TSHC_Ma);
        }


        public DataTable TS_TSHC_QuanLyPhong_Load()
        {
            //Load các records => Demo_HienThi = True
            return cls.LayDuLieu("SP_TSHC_QuanLyPhong_Load");
        }

        public DataTable TS_TSHC_QuanLyFileHopDong_Load()
        {
            //Load các records => Demo_HienThi = True
            return cls.LayDuLieu("SP_TSHC_QuanLyFileHopDong_Load");
        }

        public int TS_TaiSanHienCo_AddQRCode(TaiSanHienCoPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SQL
            int thamso = 2;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@TSHC_Ma";
            bien[1] = "@TSHC_QR_Code";

            giatri[0] = Public.TSHC_Ma;
            giatri[1] = Public.TSHC_QR_Code;

            return cls.Update("SP_TaiSanHienCo_AddQRCode", bien, giatri, thamso);
        }

        public DataTable TS_QRCode_Load()
        {
            //Load các records => Demo_HienThi = True
            return cls.LayDuLieu("SP_QRCode_Load");
        }

        public int TS_QRCode_Sua(QRcodePublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SQL
            int thamso = 2;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@QRCode_Link";
            bien[1] = "@HT_UserEditor";
           
            giatri[0] = Public.QRCode_Link;
            giatri[1] = Public.HT_UserEditor;


            return cls.Update("SP_QRCode_Edit", bien, giatri, thamso);
        }


        public DataTable TS_TSHC_ThietBiDiKem_Load(TaiSanHienCoPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@TSHC_Ma";

            giatri[0] = Public.TSHC_Ma;


            return cls.LayDuLieu("SP_TSHC_ThietBiDiKem_Load", bien, giatri, thamso);
        }

        public SqlDataReader TS_CBB_TSHC_BoPhanQuanLy_Load()
        {
            return cls.LayDuLieu_R("SP_CBB_TSHC_BoPhanQuanLy_Load");
        }

        public SqlDataReader TS_CBB_TSHC_ThuongHieu_Load()
        {
            return cls.LayDuLieu_R("SP_CBB_TSHC_ThuongHieu_Load");
        }

        public SqlDataReader TS_CBB_TSHC_XuatXu_Load()
        {
            return cls.LayDuLieu_R("SP_CBB_TSHC_XuatXu_Load");
        }

        public object TS_TSHC_ThietBiDiKem_ASP_Load(TaiSanHienCoPublic Public)
        {
            ClsKetNoiASP clsASP = new ClsKetNoiASP();
            return clsASP.LayDuLieuASP("SELECT * FROM ThietBiDiKem_View WHERE TSHC_MaNhomThietBiDiKem = "+Public.TSHC_Ma);
        }

        public object TS_TSHC_ThietBiDiKemALL_ASP_Load()
        {
            ClsKetNoiASP clsASP = new ClsKetNoiASP();
            return clsASP.LayDuLieuASP("SELECT * FROM ThietBiDiKemALL_View");
        }
    }
}
