using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class ThucHienCongViecData
    {
        ClsKetNoi cls = new ClsKetNoi();
        ThucHienCongViecPublic Public = new ThucHienCongViecPublic();

        public DataTable PC_ThucHienCongViec_Load()
        {
            return cls.LayDuLieu("SP_ThucHienCongViec_Load");
        }

        public int PC_ThucHienCongViec_Xoa(ThucHienCongViecPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@THCV_Ma";
            giatri[0] = Public.THCV_Ma;
            return cls.Update("SP_ThucHienCongViec_Del", bien, giatri, thamso);
        }

        public int PC_ThucHienCongViec_Them(ThucHienCongViecPublic Public)
        {

            int thamso = 28;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@THCV_NgayThucHien";
            bien[1] = "@THCV_ThuTrongTrongTuan";
            bien[2] = "@THCV_NguonCongViec";
            bien[3] = "@THCV_MucDoUuTien";
            bien[4] = "@THCV_NgayYeuCau";
            bien[5] = "@THCV_NgayDeNghiHoanThanh";
            bien[6] = "@THCV_YeuCau";
            bien[7] = "@THCV_MoTa";
            bien[8] = "@QLP_Ma";
            bien[9] = "@THCV_GhiChu";
            bien[10] = "@PCCV_Ma";
            bien[11] = "@QLNS_MaNSTH";
            bien[12] = "@QLNS_MaNSKT";
            bien[13] = "@TSHC_Ma";
            bien[14] = "@THCV_MoTaCongViec";
            bien[15] = "@THCV_TuDanhGia";
            bien[16] = "@THCV_ThoiGianBatDau";
            bien[17] = "@THCV_ThoiGianKetThuc";
            bien[18] = "@THCV_SoPhut";
            bien[19] = "@THCV_DeXuat";
            bien[20] = "@THCV_KetQuaThucHien";
            bien[21] = "@THCV_GhiChuNguoiThucHien";
            bien[22] = "@THCV_DanhGia";
            bien[23] = "@THCV_GhiChuNguoiKiemTra";
            bien[24] = "@QLFHSTT_Ma";
            bien[25] = "@HT_UserCreate ";
            bien[26] = "@THCV_SuDung ";
            bien[27] = "@THCV_HienThi ";

            giatri[0] = Public.THCV_NgayThucHien;
            giatri[1] = Public.THCV_ThuTrongTrongTuan;
            giatri[2] = Public.THCV_NguonCongViec;
            giatri[3] = Public.THCV_MucDoUuTien;
            giatri[4] = Public.THCV_NgayYeuCau;
            giatri[5] = Public.THCV_NgayDeNghiHoanThanh;
            giatri[6] = Public.THCV_YeuCau;
            giatri[7] = Public.THCV_MoTa;
            giatri[8] = Public.QLP_Ma;
            giatri[9] = Public.THCV_GhiChu;
            giatri[10] = Public.PCCV_Ma;
            giatri[11] = Public.QLNS_MaNSTH;
            giatri[12] = Public.QLNS_MaNSKT;
            giatri[13] = Public.TSHC_Ma;
            giatri[14] = Public.THCV_MoTaCongViec;
            giatri[15] = Public.THCV_TuDanhGia;
            giatri[16] = Public.THCV_ThoiGianBatDau;
            giatri[17] = Public.THCV_ThoiGianKetThuc;
            giatri[18] = Public.THCV_SoPhut;
            giatri[19] = Public.THCV_DeXuat;
            giatri[20] = Public.THCV_KetQuaThucHien;
            giatri[21] = Public.THCV_GhiChuNguoiThucHien;
            giatri[22] = Public.THCV_DanhGia;
            giatri[23] = Public.THCV_GhiChuNguoiKiemTra;
            giatri[24] = Public.QLFHSTT_Ma;
            giatri[25] = Public.HT_UserCreate;
            giatri[26] = Public.THCV_SuDung;
            giatri[27] = Public.THCV_HienThi;


            return cls.Update("SP_ThucHienCongViec_Add", bien, giatri, thamso);
        }

        public int PC_ThucHienCongViec_Sua(ThucHienCongViecPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SPC
            int thamso = 27;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@THCV_Ma";
            bien[1] = "@THCV_NgayThucHien";
            bien[2] = "@THCV_ThuTrongTrongTuan";
            bien[3] = "@THCV_NguonCongViec";
            bien[4] = "@THCV_MucDoUuTien";
            bien[5] = "@THCV_NgayYeuCau";
            bien[6] = "@THCV_NgayDeNghiHoanThanh";
            bien[7] = "@THCV_YeuCau";
            bien[8] = "@THCV_MoTa";
            bien[9] = "@QLP_Ma";
            bien[10] = "@THCV_GhiChu";
            bien[11] = "@PCCV_Ma";
            bien[12] = "@QLNS_MaNSTH";
            bien[13] = "@QLNS_MaNSKT";
            bien[14] = "@TSHC_Ma";
            bien[15] = "@THCV_MoTaCongViec";
            bien[16] = "@THCV_TuDanhGia";
            bien[17] = "@THCV_ThoiGianBatDau";
            bien[18] = "@THCV_ThoiGianKetThuc";
            bien[19] = "@THCV_SoPhut";
            bien[20] = "@THCV_DeXuat";
            bien[21] = "@THCV_KetQuaThucHien";
            bien[22] = "@THCV_GhiChuNguoiThucHien";
            bien[23] = "@THCV_DanhGia";
            bien[24] = "@THCV_GhiChuNguoiKiemTra";
            bien[25] = "@QLFHSTT_Ma";
            bien[26] = "@HT_UserEditor";



            giatri[0] = Public.THCV_Ma;
            giatri[1] = Public.THCV_NgayThucHien;
            giatri[2] = Public.THCV_ThuTrongTrongTuan;
            giatri[3] = Public.THCV_NguonCongViec;
            giatri[4] = Public.THCV_MucDoUuTien;
            giatri[5] = Public.THCV_NgayYeuCau;
            giatri[6] = Public.THCV_NgayDeNghiHoanThanh;
            giatri[7] = Public.THCV_YeuCau;
            giatri[8] = Public.THCV_MoTa;
            giatri[9] = Public.QLP_Ma;
            giatri[10] = Public.THCV_GhiChu;
            giatri[11] = Public.PCCV_Ma;
            giatri[12] = Public.QLNS_MaNSTH;
            giatri[13] = Public.QLNS_MaNSKT;
            giatri[14] = Public.TSHC_Ma;
            giatri[15] = Public.THCV_MoTaCongViec;
            giatri[16] = Public.THCV_TuDanhGia;
            giatri[17] = Public.THCV_ThoiGianBatDau;
            giatri[18] = Public.THCV_ThoiGianKetThuc;
            giatri[19] = Public.THCV_SoPhut;
            giatri[20] = Public.THCV_DeXuat;
            giatri[21] = Public.THCV_KetQuaThucHien;
            giatri[22] = Public.THCV_GhiChuNguoiThucHien;
            giatri[23] = Public.THCV_DanhGia;
            giatri[24] = Public.THCV_GhiChuNguoiKiemTra;
            giatri[25] = Public.QLFHSTT_Ma;
            giatri[26] = Public.HT_UserEditor;


            return cls.Update("SP_ThucHienCongViec_Edit", bien, giatri, thamso);
        }

        public SqlDataReader PC_ThucHienCongViec_Load_R_Para_File(ThucHienCongViecPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@THCV_Ma";
            giatri[0] = Public.THCV_Ma;
            return cls.LayDuLieu_R("SP_ThucHienCongViec_Load_R_Para_File", bien, giatri, thamso);
        }
    }
}
