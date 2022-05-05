using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QuanLyTaiSan
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTaiSanYeuCau_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThi_frmTaiSanYeuCau();
        }

        private void btnYeuCau_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThi_frmYeuCau();
        }

        private void btnNhomTaiSan_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThi_frmNhomTaiSan();
        }

        private void btnTaiSanMuaSam_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThi_frmTaiSanMuaSam();
        }

        private void btnQuanLyNhanSu_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThi_frmQuanLyNhanSu();
        }

        private void btnQuanLyDonVi_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThi_frmQuanLyDonVi();
        }

        private void btnQuanLyPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThi_frmQuanLyPhong();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThi_frmTaiSanHienCo();
        }

        private void btnQuanLyFileHopDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThi_frmQuanLyFileHopDong();
        }

        private void btnLichSuBanGiao_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThi_frmQLTS_LichSuBanGiao();
        }

        private void btnDanhMucCongViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThi_frmPCCV_DanhMucCongViec();
        }

        private void btnMaHoaGiaiMa_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThi_frmMaHoaGiaiMa();
        }

        private void btnThucHienCongViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThi_frmPCCV_ThucHienCongViec();
        }

        private void btnPhanCongCongViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThi_frmPCCV_PhanCongCongViec();
        }

        private void btnQuanLyFileHoSoThanhToan_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadMain.HienThi_frmBHSC_QuanLyFileHoSoThanhToan();
        }

       

    }
}