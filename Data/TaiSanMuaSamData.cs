using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Public;
using System.Data.SqlClient;

namespace Data
{
    public class TaiSanMuaSamData
    {
        ClsKetNoi cls = new ClsKetNoi();
        TaiSanMuaSamPublic Public = new TaiSanMuaSamPublic();

        public DataTable TS_TaiSanMuaSam_Load()
        {
            return cls.LayDuLieu("SP_TaiSanMuaSam_Load");
        }

        public DataTable TS_ChonTaiSanMuaSam_Load()
        {
            return cls.LayDuLieu("SP_ChonTaiSanMuaSam_Load");
        }

        public int TS_TaiSanMuaSam_Xoa(TaiSanMuaSamPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@TSMS_Ma";
            giatri[0] = Public.TSMS_Ma;
            return cls.Update("SP_TaiSanMuaSam_Del", bien, giatri, thamso);
        }

        public int TS_TaiSanMuaSam_Them(TaiSanMuaSamPublic Public)
        {

            int thamso = 23;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@YC_Ma";
            bien[1] = "@NTS_Ma";
            bien[2] = "@TSMS_LoaiTaiSan";
            bien[3] = "@TSMS_TenTaiSan";
            bien[4] = "@TSMS_Mota";
            bien[5] = "@TSMS_ThuongHieu";
            bien[6] = "@TSMS_XuatXu";
            bien[7] = "@TSMS_Model";
            bien[8] = "@TSMS_KichThuoc_Dai";
            bien[9] = "@TSMS_KichThuoc_Rong";
            bien[10] = "@TSMS_KichThuoc_Cao";
            bien[11] = "@TSMS_MauSac";
            bien[12] = "@TSMS_DVT";
            bien[13] = "@TSMS_SoLuong";
            bien[14] = "@TSMS_DonGia";
            bien[15] = "@TSMS_ThanhTien";
            bien[16] = "@TSMS_NgayMua";
            bien[17] = "@TSMS_Links";
            bien[18] = "@TSMS_AnhChupTaiSan";
            bien[19] = "@TSMS_GhiChu";
            bien[20] = "@HT_UserCreate";
            bien[21] = "@TSMS_SuDung";
            bien[22] = "@TSMS_HienThi";

            giatri[0] = Public.YC_Ma;
            giatri[1] = Public.NTS_Ma;
            giatri[2] = Public.TSMS_LoaiTaiSan;
            giatri[3] = Public.TSMS_TenTaiSan;
            giatri[4] = Public.TSMS_Mota;
            giatri[5] = Public.TSMS_ThuongHieu;
            giatri[6] = Public.TSMS_XuatXu;
            giatri[7] = Public.TSMS_Model;
            giatri[8] = Public.TSMS_KichThuoc_Dai;
            giatri[9] = Public.TSMS_KichThuoc_Rong;
            giatri[10] = Public.TSMS_KichThuoc_Cao;
            giatri[11] = Public.TSMS_MauSac;
            giatri[12] = Public.TSMS_DVT;
            giatri[13] = Public.TSMS_SoLuong;
            giatri[14] = Public.TSMS_DonGia;
            giatri[15] = Public.TSMS_ThanhTien;
            giatri[16] = Public.TSMS_NgayMua;
            giatri[17] = Public.TSMS_Links;
            giatri[18] = Public.TSMS_AnhChupTaiSan;
            giatri[19] = Public.TSMS_GhiChu;
            giatri[20] = Public.HT_UserCreate;
            giatri[21] = Public.TSMS_SuDung;
            giatri[22] = Public.TSMS_HienThi;

            return cls.Update("SP_TaiSanMuaSam_Add", bien, giatri, thamso);
        }

        public int TS_TaiSanMuaSam_Sua(TaiSanMuaSamPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SQL
            int thamso = 22;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@TSMS_Ma";
            bien[1] = "@YC_Ma";
            bien[2] = "@NTS_Ma";
            bien[3] = "@TSMS_LoaiTaiSan";
            bien[4] = "@TSMS_TenTaiSan";
            bien[5] = "@TSMS_Mota";
            bien[6] = "@TSMS_ThuongHieu";
            bien[7] = "@TSMS_XuatXu";
            bien[8] = "@TSMS_Model";
            bien[9] = "@TSMS_KichThuoc_Dai";
            bien[10] = "@TSMS_KichThuoc_Rong";
            bien[11] = "@TSMS_KichThuoc_Cao";
            bien[12] = "@TSMS_MauSac";
            bien[13] = "@TSMS_DVT";
            bien[14] = "@TSMS_SoLuong";
            bien[15] = "@TSMS_DonGia";
            bien[16] = "@TSMS_ThanhTien";
            bien[17] = "@TSMS_NgayMua";
            bien[18] = "@TSMS_Links";
            bien[19] = "@TSMS_AnhChupTaiSan";
            bien[20] = "@TSMS_GhiChu";
            bien[21] = "@HT_UserEditor";

            giatri[0] = Public.TSMS_Ma;
            giatri[1] = Public.YC_Ma;
            giatri[2] = Public.NTS_Ma;
            giatri[3] = Public.TSMS_LoaiTaiSan;
            giatri[4] = Public.TSMS_TenTaiSan;
            giatri[5] = Public.TSMS_Mota;
            giatri[6] = Public.TSMS_ThuongHieu;
            giatri[7] = Public.TSMS_XuatXu;
            giatri[8] = Public.TSMS_Model;
            giatri[9] = Public.TSMS_KichThuoc_Dai;
            giatri[10] = Public.TSMS_KichThuoc_Rong;
            giatri[11] = Public.TSMS_KichThuoc_Cao;
            giatri[12] = Public.TSMS_MauSac;
            giatri[13] = Public.TSMS_DVT;
            giatri[14] = Public.TSMS_SoLuong;
            giatri[15] = Public.TSMS_DonGia;
            giatri[16] = Public.TSMS_ThanhTien;
            giatri[17] = Public.TSMS_NgayMua;
            giatri[18] = Public.TSMS_Links;
            giatri[19] = Public.TSMS_AnhChupTaiSan;
            giatri[20] = Public.TSMS_GhiChu;
            giatri[21] = Public.HT_UserEditor;

            return cls.Update("SP_TaiSanMuaSam_Edit", bien, giatri, thamso);
        }

        public int TS_TaiSanMuaSam_SuaSoLuong(TaiSanMuaSamPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SQL
            int thamso = 4;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@TSMS_Ma";
            bien[1] = "@TSMS_SoLuong";
            bien[2] = "@TSMS_ThanhTien";
            bien[3] = "@HT_UserEditor";

            giatri[0] = Public.TSMS_Ma;
            giatri[1] = Public.TSMS_SoLuong;
            giatri[2] = Public.TSMS_ThanhTien;
            giatri[3] = Public.HT_UserEditor;

            return cls.Update("SP_TaiSanMuaSam_EditSoLuong", bien, giatri, thamso);
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

        public SqlDataReader TS_CBB_TSMS_BoPhanQuanLy_Load()
        {
            return cls.LayDuLieu_R("SP_CBB_TSHC_BoPhanQuanLy_Load");
        }
    }
}
