using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Public;
using BLL;

namespace QuanLyTaiSan
{
    public partial class frmPCCV_THCV_ChonNgayThucHienCongViec : DevExpress.XtraEditors.XtraForm
    {
        ThucHienCongViecBLL cls = new ThucHienCongViecBLL();
        ThucHienCongViecPublic Public = new ThucHienCongViecPublic();

        PhanCongCongViecBLL cls_PhanCongCongViecBLL = new PhanCongCongViecBLL();
        PhanCongCongViecPublic Public_PhanCongCongViec = new PhanCongCongViecPublic();

        public frmPCCV_THCV_ChonNgayThucHienCongViec()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataTable DoDanhSach = cls_PhanCongCongViecBLL.PC_PhanCongCongViec_Load();

            for (int stt = 0; stt < DoDanhSach.Rows.Count; stt++)
            {
                if (DoDanhSach.Rows[stt]["DMCV_DacTinh"].ToString() == "Định kỳ")
                {
                    
                    Public.HT_UserCreate = BienToanCuc.HT_USER_ID;
                    //Public.QLP_DateCreate = GetNgayTrongTuan(Convert.ToDateTime(dtNgayBatDau.Text));
                    Public.HT_UserEditor = BienToanCuc.HT_USER_ID;
                    //Public.QLP_DateEditor =

                    Public.THCV_HienThi = true;
                    Public.THCV_SuDung = BienToanCuc.HT_PB_Ten;


                    Public.THCV_NgayThucHien = Convert.ToDateTime(dtNgayBatDau.Text);
                    Public.THCV_ThuTrongTrongTuan = GetNgayTrongTuan(Convert.ToDateTime(dtNgayBatDau.Text));
                    Public.THCV_NguonCongViec = "Theo kế hoạch";
                    Public.THCV_NgayYeuCau = Convert.ToDateTime(dtNgayBatDau.Text);
                    Public.PCCV_Ma = Convert.ToInt32(DoDanhSach.Rows[stt]["PCCV_Ma"].ToString());
                    Public.QLNS_MaNSTH = Convert.ToInt32(DoDanhSach.Rows[stt]["QLNS_MaNSTH"].ToString());
                    Public.QLNS_MaNSKT = Convert.ToInt32(DoDanhSach.Rows[stt]["QLNS_MaNSKT"].ToString());
                    Public.THCV_MoTaCongViec = DoDanhSach.Rows[stt]["DMCV_MoTa"].ToString();

                    Public.THCV_KetQuaThucHien = "";
                    Public.THCV_GhiChuNguoiThucHien = "";
                    Public.THCV_YeuCau = "";
                    Public.THCV_MoTa = "";
                    Public.THCV_GhiChu = "";
                    Public.THCV_TuDanhGia = "";
                    Public.THCV_DeXuat = "";
                    Public.THCV_DanhGia = "";
                    Public.THCV_GhiChuNguoiKiemTra = "";

                    cls.PC_ThucHienCongViec_Them(Public);
                }
            }

            this.Close();
        }

        private int GetNgayTrongTuan(DateTime d)
        {
            string thu = d.DayOfWeek.ToString();
            if (thu == "Monday")
                return 2;
            else if (thu == "Tuesday")
                return 3;
            else if (thu == "Wednesday")
                return 4;
            else if (thu == "Thursday")
                return 5;
            else if (thu == "Friday")
                return 6;
            else if (thu == "Saturday")
                return 7;
            else
                return 8;
        }
    }
}