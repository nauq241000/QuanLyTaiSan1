using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Public;

namespace Data
{
    public class ChiTietCongViecData
    {

        ClsKetNoi cls = new ClsKetNoi();

        public DataTable CV_ChiTietCongViec_Load(int Ma)
        {
            int thamso = 1;

            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@QLNS_MaNSTH";

            giatri[0] = Ma;

            return cls.LayDuLieu("SP_ChiTietCongViec_Load", bien, giatri, thamso);
        }

        public DataTable CV_ChiTietCongViec_GetMa(string Ma)
        {
            int thamso = 1;

            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@QLNS_MaNhanSu";

            giatri[0] = Ma;

            return cls.LayDuLieu("SP_ChiTietCongViec_GetMa", bien, giatri, thamso);
        }

        public int CV_ChiTietCongViec_Edit(ChiTietCongViecPublic Public)
        {
            int thamso = 9;

            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@THCV_Ma";
            bien[1] = "@THCV_DanhGia";
            bien[2] = "@THCV_DeXuat";
            bien[3] = "@THCV_SoPhut";
            bien[4] = "@THCV_ThoiGianBatDau";
            bien[5] = "@THCV_ThoiGianKetThuc";
            bien[6] = "@THCV_KetQuaThucHien";
            bien[7] = "@THCV_GhiChuNguoiThucHien";
            bien[8] = "@HT_UserEditor";


            giatri[0] = Public.THCV_Ma;
            giatri[1] = Public.THCV_DanhGia;
            giatri[2] = Public.THCV_DeXuat;
            giatri[3] = Public.THCV_SoPhut;
            giatri[4] = Public.THCV_ThoiGianBatDau;
            giatri[5] = Public.THCV_ThoiGianKetThuc;
            giatri[6] = Public.THCV_KetQuaThucHien;
            giatri[7] = Public.THCV_GhiChuNguoiThucHien;
            giatri[8] = Public.HT_UserEditor;

            return cls.Update("SP_ChiTietCongViec_Edit", bien, giatri, thamso);
        }
    }
}
