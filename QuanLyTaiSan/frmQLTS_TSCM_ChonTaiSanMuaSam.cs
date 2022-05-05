using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;
using Public;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;

namespace QuanLyTaiSan
{
    public partial class frmQLTS_TSCM_ChonTaiSanMuaSam : DevExpress.XtraEditors.XtraForm
    {

        public frmQLTS_TSCM_ChonTaiSanMuaSam()
        {
            InitializeComponent();
            new MultiSelectionEditingHelper(bandedGridView_TaiSanYeuCau);
        }

        TaiSanYeuCauBLL cls = new TaiSanYeuCauBLL();
        TaiSanYeuCauPublic Public = new TaiSanYeuCauPublic();

        TaiSanMuaSamBLL cls_TaiSanMuaSam = new TaiSanMuaSamBLL();
        TaiSanMuaSamPublic Public_TaiSanMuaSam = new TaiSanMuaSamPublic();

        private bool KiemTra_NhapDuLieu()
        {
            bandedGridView_TaiSanYeuCau.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanYeuCau.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(TSYC_Chon)) &&
                        (
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(YC_Ma))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(NTS_Ma))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_LoaiTaiSan))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_TenTaiSan))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_Mota))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_ThuongHieu))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_XuatXu))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_KichThuoc_Dai))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_KichThuoc_Rong))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_KichThuoc_Cao))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_MauSac))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_DVT))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_SoLuong))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_DonGia))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_NgayMua)))
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_Links))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_GhiChu)))
                        )
                    )
                {
                    return false;
                }
                bandedGridView_TaiSanYeuCau.MoveNext();
            }
            return true;
        }

        private bool KiemTra()
        {
            bandedGridView_TaiSanYeuCau.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanYeuCau.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(TSYC_Chon)))
                {
                    return true;
                }
                bandedGridView_TaiSanYeuCau.MoveNext();
            }
            return false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadDataCombobox()
        {
            repositoryItemComboBox_TSYC_LoaiTaiSan.Items.Clear();
            SqlDataReader dr_01 = LoadHamDungChung.TS_CBB_TSYC_LoaiTaiSan_Load();
            while (dr_01.Read())
            {
                repositoryItemComboBox_TSYC_LoaiTaiSan.Items.Add(Convert.ToString(dr_01["TSYC_LoaiTaiSan"]));
            }
            dr_01.Dispose();
            dr_01.Close();

            repositoryItemComboBox_TSYC_ThuongHieu.Items.Clear();
            SqlDataReader dr_02 = LoadHamDungChung.TS_CBB_TSYC_ThuongHieu_Load();
            while (dr_02.Read())
            {
                repositoryItemComboBox_TSYC_ThuongHieu.Items.Add(Convert.ToString(dr_02["TSYC_ThuongHieu"]));
            }
            dr_02.Dispose();
            dr_02.Close();

            repositoryItemComboBox_TSYC_XuatXu.Items.Clear();
            SqlDataReader dr_03 = LoadHamDungChung.TS_CBB_TSYC_XuatXu_Load();
            while (dr_03.Read())
            {
                repositoryItemComboBox_TSYC_XuatXu.Items.Add(Convert.ToString(dr_03["TSYC_XuatXu"]));
            }
            dr_03.Dispose();
            dr_03.Close();
        }

        private void frmChonTaiSanMuaSam_Load(object sender, EventArgs e)
        {
            repositoryItemLookUpEdit_YeuCau.DataSource = cls.TS_YeuCau_Load();
            repositoryItemLookUpEdit_YeuCau.DisplayMember = "YC_TenYeuCau";
            repositoryItemLookUpEdit_YeuCau.ValueMember = "YC_Ma";

            repositoryItemLookUpEdit_YeuCau.PopupWidth = 1000;
            repositoryItemLookUpEdit_YeuCau.ShowFooter = false;
            repositoryItemLookUpEdit_YeuCau.Columns.Clear();
            repositoryItemLookUpEdit_YeuCau.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YC_Ma", "Mã", 100));
            repositoryItemLookUpEdit_YeuCau.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YC_NhomYeuCau", "NhomYeuCau", 200));
            repositoryItemLookUpEdit_YeuCau.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YC_TenYeuCau", "Tên yêu cầu", 200));
            repositoryItemLookUpEdit_YeuCau.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YC_NgayYeuCau", "Ngày yêu cầu", 100));
            repositoryItemLookUpEdit_YeuCau.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YC_DonViYeuCau", "Đơn vị", 200));
            repositoryItemLookUpEdit_YeuCau.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YC_NguoiDeNghi", "Người đề nghị", 200));

            repositoryItemLookUpEdit_NhomTaiSan.DataSource = cls.TS_NhomTaiSan_Load();
            repositoryItemLookUpEdit_NhomTaiSan.DisplayMember = "NTS_Ten";
            repositoryItemLookUpEdit_NhomTaiSan.ValueMember = "NTS_Ma";

            repositoryItemLookUpEdit_NhomTaiSan.PopupWidth = 300;
            repositoryItemLookUpEdit_NhomTaiSan.ShowFooter = false;
            repositoryItemLookUpEdit_NhomTaiSan.Columns.Clear();
            repositoryItemLookUpEdit_NhomTaiSan.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NTS_Ma", "Mã", 100));
            repositoryItemLookUpEdit_NhomTaiSan.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NTS_Ten", "Tên nhóm tài sản", 200));

            LoadDataCombobox();
            gridControl_TaiSanYeuCau.DataSource = cls.TS_ChonTaiSanYeuCau_Load();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            Public_TaiSanMuaSam.HT_UserCreate = BienToanCuc.HT_USER_ID;
            //Public.TSYC_DateCreate =
            Public_TaiSanMuaSam.HT_UserEditor = BienToanCuc.HT_USER_ID;
            //Public.TSYC_DateEditor =

            Public_TaiSanMuaSam.TSMS_HienThi = true;
            Public_TaiSanMuaSam.TSMS_SuDung = BienToanCuc.HT_PB_Ten;

            if (KiemTra() == false || KiemTra_NhapDuLieu() == false)
            {
                if (KiemTra() == false)
                {
                    MessageBox.Show("Bạn phải chọn dữ liệu", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (KiemTra_NhapDuLieu() == false)
                {
                    MessageBox.Show("Bạn phải điền đủ dữ liệu vào các ô", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            bandedGridView_TaiSanYeuCau.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanYeuCau.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(TSYC_Chon))) // == true
                {
                    Public.TSYC_Ma = int.Parse("0" + bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_Ma));
                    Public_TaiSanMuaSam.YC_Ma = int.Parse("0" + bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(YC_Ma));
                    Public_TaiSanMuaSam.NTS_Ma = int.Parse("0" + bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(NTS_Ma));
                    Public_TaiSanMuaSam.TSMS_LoaiTaiSan = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_LoaiTaiSan);
                    Public_TaiSanMuaSam.TSMS_TenTaiSan = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_TenTaiSan);
                    Public_TaiSanMuaSam.TSMS_Mota = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_Mota);
                    Public_TaiSanMuaSam.TSMS_ThuongHieu = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_ThuongHieu);
                    Public_TaiSanMuaSam.TSMS_XuatXu = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_XuatXu);
                    Public_TaiSanMuaSam.TSMS_Model = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_Model);
                    Public_TaiSanMuaSam.TSMS_KichThuoc_Dai = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_KichThuoc_Dai);
                    Public_TaiSanMuaSam.TSMS_KichThuoc_Rong = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_KichThuoc_Rong);
                    Public_TaiSanMuaSam.TSMS_KichThuoc_Cao = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_KichThuoc_Cao);
                    Public_TaiSanMuaSam.TSMS_MauSac = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_MauSac);
                    Public_TaiSanMuaSam.TSMS_DVT = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_DVT);
                    Public_TaiSanMuaSam.TSMS_SoLuong = int.Parse("0" + bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(TSYC_SoLuong));
                    Public_TaiSanMuaSam.TSMS_DonGia = int.Parse("0" + bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(TSYC_DonGia));
                    Public_TaiSanMuaSam.TSMS_ThanhTien = Public_TaiSanMuaSam.TSMS_SoLuong * Public_TaiSanMuaSam.TSMS_DonGia;
                    Public_TaiSanMuaSam.TSMS_NgayMua = Convert.ToDateTime(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_NgayMua));
                    Public_TaiSanMuaSam.TSMS_Links = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_Links);
                    if (bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(TSYC_AnhChupTaiSan).GetType().ToString()=="System.DBNull")
                        Public_TaiSanMuaSam.TSMS_AnhChupTaiSan = null;
                    else
                        Public_TaiSanMuaSam.TSMS_AnhChupTaiSan = bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(TSYC_AnhChupTaiSan);
                    Public_TaiSanMuaSam.TSMS_GhiChu = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_GhiChu);

                    int kqthem = cls_TaiSanMuaSam.TS_TaiSanMuaSam_Them(Public_TaiSanMuaSam);

                    int kqxoa = cls.TS_TaiSanYeuCau_Xoa(Public);
                }
                bandedGridView_TaiSanYeuCau.MoveNext();
            }
            this.Close();
        }

        #region Cho phép thực hiện thao tác CLICK phải chuột

        void Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_TaiSanYeuCau.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanYeuCau.RowCount; i++)
            {
                bandedGridView_TaiSanYeuCau.SetFocusedRowCellValue(TSYC_Chon, true);
                bandedGridView_TaiSanYeuCau.MoveNext();
            }
            bandedGridView_TaiSanYeuCau.MoveFirst();
        }

        void No_Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_TaiSanYeuCau.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanYeuCau.RowCount; i++)
            {
                bandedGridView_TaiSanYeuCau.SetFocusedRowCellValue(TSYC_Chon, false);
                bandedGridView_TaiSanYeuCau.MoveNext();
            }
            bandedGridView_TaiSanYeuCau.MoveFirst();
        }

        private void bandedGridView_TaiSanHienCo_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                GridViewMenu menu = e.Menu as GridViewMenu;
                menu.Items.Clear();

                DXMenuItem Check_All = new DXMenuItem("Check All (Chọn)"); // caption menu
                //itemReload.Image = ImgCollection.Images["refresh2_16x16.png"]; // icon cho menu
                Check_All.Shortcut = Shortcut.Ctrl1; // phím tắt
                Check_All.Click += new EventHandler(Check_All_Click);// thêm sự kiện click
                menu.Items.Add(Check_All);

                DXMenuItem No_Check_All = new DXMenuItem("UnCheck All (Chọn)");
                //No_Check_All.BeginGroup = true;
                //itemAdd.Image = ImgCollection.Images["new_16x16.png"];
                No_Check_All.Shortcut = Shortcut.Ctrl2;
                No_Check_All.Click += new EventHandler(No_Check_All_Click);
                menu.Items.Add(No_Check_All);

            }
        }
        #endregion

    }
}