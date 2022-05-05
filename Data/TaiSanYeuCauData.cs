using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Public;
using System.Data.SqlClient;

namespace Data
{
    public class TaiSanYeuCauData
    {
        ClsKetNoi cls = new ClsKetNoi();
        TaiSanYeuCauPublic Public = new TaiSanYeuCauPublic();

        public DataTable TS_TaiSanYeuCau_Load()
        {
            return cls.LayDuLieu("SP_TaiSanYeuCau_Load");
        }

        public DataTable TS_ChonTaiSanYeuCau_Load()
        {
            return cls.LayDuLieu("SP_ChonTaiSanYeuCau_Load");
        }

        public int TS_TaiSanYeuCau_Xoa(TaiSanYeuCauPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@TSYC_Ma";
            giatri[0] = Public.TSYC_Ma;
            return cls.Update("SP_TaiSanYeuCau_Del", bien, giatri, thamso);
        }

        public int TS_TaiSanYeuCau_Them(TaiSanYeuCauPublic Public)
        {
            
            int thamso = 22;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@YC_Ma";
            bien[1] = "@NTS_Ma";
            bien[2] = "@TSYC_LoaiTaiSan";
            bien[3] = "@TSYC_TenTaiSan";
            bien[4] = "@TSYC_Mota";
            bien[5] = "@TSYC_ThuongHieu";
            bien[6] = "@TSYC_XuatXu";
            bien[7] = "@TSYC_Model";
            bien[8] = "@TSYC_KichThuoc_Dai";
            bien[9] = "@TSYC_KichThuoc_Rong";
            bien[10] = "@TSYC_KichThuoc_Cao";
            bien[11] = "@TSYC_MauSac";
            bien[12] = "@TSYC_DVT";
            bien[13] = "@TSYC_SoLuong";
            bien[14] = "@TSYC_DonGia";
            bien[15] = "@TSYC_ThanhTien";
            bien[16] = "@TSYC_Links";
            bien[17] = "@TSYC_AnhChupTaiSan";
            bien[18] = "@TSYC_GhiChu";
            bien[19] = "@HT_UserCreate";
            bien[20] = "@TSYC_SuDung";
            bien[21] = "@TSYC_HienThi";

            giatri[0] = Public.YC_Ma;
            giatri[1] = Public.NTS_Ma;
            giatri[2] = Public.TSYC_LoaiTaiSan;
            giatri[3] = Public.TSYC_TenTaiSan;
            giatri[4] = Public.TSYC_Mota;
            giatri[5] = Public.TSYC_ThuongHieu;
            giatri[6] = Public.TSYC_XuatXu;
            giatri[7] = Public.TSYC_Model;
            giatri[8] = Public.TSYC_KichThuoc_Dai;
            giatri[9] = Public.TSYC_KichThuoc_Rong;
            giatri[10] = Public.TSYC_KichThuoc_Cao;
            giatri[11] = Public.TSYC_MauSac;
            giatri[12] = Public.TSYC_DVT;
            giatri[13] = Public.TSYC_SoLuong;
            giatri[14] = Public.TSYC_DonGia;
            giatri[15] = Public.TSYC_ThanhTien;
            giatri[16] = Public.TSYC_Links;
            giatri[17] = Public.TSYC_AnhChupTaiSan;
            giatri[18] = Public.TSYC_GhiChu;
            giatri[19] = Public.HT_UserCreate;
            giatri[20] = Public.TSYC_SuDung;
            giatri[21] = Public.TSYC_HienThi;
            
            return cls.Update("SP_TaiSanYeuCau_Add", bien, giatri, thamso);
        }

        public int TS_TaiSanYeuCau_Sua(TaiSanYeuCauPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SQL
            int thamso = 21;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@TSYC_Ma";
            bien[1] = "@YC_Ma";
            bien[2] = "@NTS_Ma";
            bien[3] = "@TSYC_LoaiTaiSan";
            bien[4] = "@TSYC_TenTaiSan";
            bien[5] = "@TSYC_Mota";
            bien[6] = "@TSYC_ThuongHieu";
            bien[7] = "@TSYC_XuatXu";
            bien[8] = "@TSYC_Model";
            bien[9] = "@TSYC_KichThuoc_Dai";
            bien[10] = "@TSYC_KichThuoc_Rong";
            bien[11] = "@TSYC_KichThuoc_Cao";
            bien[12] = "@TSYC_MauSac";
            bien[13] = "@TSYC_DVT";
            bien[14] = "@TSYC_SoLuong";
            bien[15] = "@TSYC_DonGia";
            bien[16] = "@TSYC_ThanhTien";
            bien[17] = "@TSYC_Links";
            bien[18] = "@TSYC_AnhChupTaiSan";
            bien[19] = "@TSYC_GhiChu";
            bien[20] = "@HT_UserEditor";

            giatri[0] = Public.TSYC_Ma;
            giatri[1] = Public.YC_Ma;
            giatri[2] = Public.NTS_Ma;
            giatri[3] = Public.TSYC_LoaiTaiSan;
            giatri[4] = Public.TSYC_TenTaiSan;
            giatri[5] = Public.TSYC_Mota;
            giatri[6] = Public.TSYC_ThuongHieu;
            giatri[7] = Public.TSYC_XuatXu;
            giatri[8] = Public.TSYC_Model;
            giatri[9] = Public.TSYC_KichThuoc_Dai;
            giatri[10] = Public.TSYC_KichThuoc_Rong;
            giatri[11] = Public.TSYC_KichThuoc_Cao;
            giatri[12] = Public.TSYC_MauSac;
            giatri[13] = Public.TSYC_DVT;
            giatri[14] = Public.TSYC_SoLuong;
            giatri[15] = Public.TSYC_DonGia;
            giatri[16] = Public.TSYC_ThanhTien;
            giatri[17] = Public.TSYC_Links;
            giatri[18] = Public.TSYC_AnhChupTaiSan;
            giatri[19] = Public.TSYC_GhiChu;
            giatri[20] = Public.HT_UserEditor;

            return cls.Update("SP_TaiSanYeuCau_Edit", bien, giatri, thamso);
        }

        public DataTable TS_YeuCau_Load()
        {
            //Load các records => Demo_HienThi = True
            return cls.LayDuLieu("SP_TS_YeuCau_Load");
        }

        public DataTable TS_NhomTaiSan_Load()
        {
            //Load các records => Demo_HienThi = True
            return cls.LayDuLieu("SP_TS_NhomTaiSan_Load");
        }

        public SqlDataReader TS_CBB_TSYC_XuatXu_Load()
        {
            return cls.LayDuLieu_R("SP_CBB_TSYC_XuatXu_Load");
        }

        public SqlDataReader TS_CBB_TSYC_ThuongHieu_Load()
        {
            return cls.LayDuLieu_R("SP_CBB_TSYC_ThuongHieu_Load");
        }

        public SqlDataReader TS_CBB_TSYC_LoaiTaiSan_Load()
        {
            return cls.LayDuLieu_R("SP_CBB_TSYC_LoaiTaiSan_Load");
        }
    }
}
