using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using BLL;
using Public;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;

namespace QuanLyTaiSan
{
    public partial class frmQLTS_TaiSanMuaSam : DevExpress.XtraEditors.XtraForm
    {
        public frmQLTS_TaiSanMuaSam()
        {
            InitializeComponent();
            Lock_Unlock_Control_Input(false);
            new MultiSelectionEditingHelper(bandedGridView_TaiSanMuaSam);
        }

        TaiSanMuaSamBLL cls = new TaiSanMuaSamBLL();
        TaiSanMuaSamPublic Public = new TaiSanMuaSamPublic();

        HT_PQ_USERBLL cls_HT_PQ_USER = new HT_PQ_USERBLL();
        HT_PQ_USERPublic Public_HT_PQ_USER = new HT_PQ_USERPublic();

        Boolean TS_TSMS_Add = false;
        Boolean TS_TSMS_Edit = false;
        public void UnVisibleControls()
        {
            BarButtonItem[] items = new BarButtonItem[] { btnThem, btnSua, btnXoa, btnLuu };

            foreach (BarButtonItem item in items)
            {
                item.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        public void VisibleControls()
        {
            BarButtonItem[] items = new BarButtonItem[] { btnThem, btnSua, btnXoa, btnLuu };
            if (BienToanCuc.MaNguoiDung == "0")
            {
                //Quyền quản trị               
                foreach (BarButtonItem item in items)
                {
                    item.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
            }
            else
            {
                Public_HT_PQ_USER.HT_USER_ID = int.Parse("0" + BienToanCuc.MaNguoiDung);
                //Public.HT_ROOT_Form = this.Name.Replace("btn", "frm");
                Public_HT_PQ_USER.HT_ROOT_Form = this.Name;
                Public_HT_PQ_USER.HT_ROOT_Active = true;

                SqlDataReader dr = cls_HT_PQ_USER.LoadHT_PQ_USER_R_MaND(Public_HT_PQ_USER);
                dr.Read();

                //Toàn quyền - Quyền xem                
                foreach (BarButtonItem item in items)
                {
                    if (Convert.ToBoolean(dr[0]) == true)
                    {
                        item.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    }
                    if (Convert.ToBoolean(dr[1]) == true)
                    {
                        item.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    }
                }

                //Quyền thêm
                if (Convert.ToBoolean(dr[2]) == true)
                {
                    btnThem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }

                //Quyền xóa
                if (Convert.ToBoolean(dr[3]) == true)
                {
                    btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }

                //Quyền sửa
                if (Convert.ToBoolean(dr[4]) == true)
                {
                    btnSua.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                dr.Dispose();
                dr.Close();
            }
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



        private void frmTaiSanMuaSam_Load(object sender, EventArgs e)
        {
            repositoryItemLookUpEdit_YeuCau.DataSource = cls.TS_YeuCau_Load();
            repositoryItemLookUpEdit_YeuCau.DisplayMember = "YC_TenYeuCau";
            repositoryItemLookUpEdit_YeuCau.ValueMember = "YC_Ma";

            repositoryItemLookUpEdit_YeuCau.PopupWidth = 1000;
            repositoryItemLookUpEdit_YeuCau.ShowFooter = false;
            repositoryItemLookUpEdit_YeuCau.Columns.Clear();
            repositoryItemLookUpEdit_YeuCau.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YC_Ma", "Mã", 100));
            repositoryItemLookUpEdit_YeuCau.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YC_NhomYeuCau", "Nhóm yeu cầu", 200));
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
            gridControl_TaiSanMuaSam.DataSource = cls.TS_TaiSanMuaSam_Load();
        }

        private void Lock_Unlock_Control_Input(bool Lock_Control)
        {
            this.TSMS_Ma.OptionsColumn.ReadOnly = true;
            this.YC_Ma.OptionsColumn.ReadOnly = !Lock_Control;
            this.NTS_Ma.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSMS_LoaiTaiSan.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSMS_TenTaiSan.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSMS_Mota.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSMS_ThuongHieu.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSMS_XuatXu.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSMS_Model.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSMS_KichThuoc_Dai.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSMS_KichThuoc_Rong.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSMS_KichThuoc_Cao.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSMS_MauSac.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSMS_DVT.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSMS_SoLuong.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSMS_DonGia.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSMS_ThanhTien.OptionsColumn.ReadOnly = true;
            this.TSMS_Links.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSMS_AnhChupTaiSan.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSMS_GhiChu.OptionsColumn.ReadOnly = !Lock_Control;
        }

        private void Lock_Unlock_Control(Boolean Lock_Control) //Khóa và mở khóa điều khiển chức năng
        {
            btnRefresh.Enabled = Lock_Control;
            btnThem.Enabled = Lock_Control;
            btnSua.Enabled = Lock_Control;
            btnXoa.Enabled = Lock_Control;
            btnLuu.Enabled = !Lock_Control;
            btnUndo.Enabled = !Lock_Control;
        }

        private void Unlock_Control(Boolean Lock_Control) //Mở khóa điều khiển chức năng
        {
            btnRefresh.Enabled = Lock_Control;
            btnThem.Enabled = Lock_Control;
            btnSua.Enabled = Lock_Control;
            btnXoa.Enabled = Lock_Control;
            btnLuu.Enabled = Lock_Control;
            btnUndo.Enabled = Lock_Control;
        }

        private bool KiemTra_NhapDuLieu()
        {
            bandedGridView_TaiSanMuaSam.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanMuaSam.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_Chon)) &&
                        (
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(YC_Ma))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(NTS_Ma))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_LoaiTaiSan))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_TenTaiSan))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_Mota))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_ThuongHieu))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_XuatXu))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_KichThuoc_Dai))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_KichThuoc_Rong))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_KichThuoc_Cao))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_MauSac))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_DVT))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_SoLuong)))
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_DonGia))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_Links))) ||
                            //string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_GhiChu)))
                        )
                    )
                {
                    return false;
                }
                bandedGridView_TaiSanMuaSam.MoveNext();
            }
            return true;
        }

        private bool KiemTra()
        {
            bandedGridView_TaiSanMuaSam.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanMuaSam.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_Chon)))
                {
                    return true;
                }
                bandedGridView_TaiSanMuaSam.MoveNext();
            }
            return false;
        }

        private void TraVe_DongDLChon()
        {
            bandedGridView_TaiSanMuaSam.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanMuaSam.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_Chon)))
                {
                    //Trả con trỏ về vị trí được chọn
                    break;
                }
                bandedGridView_TaiSanMuaSam.MoveNext();
            }
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTaiSanMuaSam_Load(sender, e);
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQLTS_TSCM_ChonTaiSanMuaSam frm_ChonTaiSanMuaSam = new frmQLTS_TSCM_ChonTaiSanMuaSam();
            frm_ChonTaiSanMuaSam.ShowDialog();
            frmTaiSanMuaSam_Load(sender,e);
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTra() == false)
            {
                MessageBox.Show("Bạn phải chọn dữ liệu", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_Chon))))
            {
                MessageBox.Show("Bạn phải lựa chọn lại dữ liệu trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {
                TS_TSMS_Add = false;
                TS_TSMS_Edit = true;

                Lock_Unlock_Control(false); //Mở khóa lưu dữ liệu
                Lock_Unlock_Control_Input(true); //Khóa điều khiển nhập dữ liệu
            }
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTra() == false)
            {
                MessageBox.Show("Bạn phải chọn dữ liệu", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa dòng dữ liệu đã chọn?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bandedGridView_TaiSanMuaSam.MoveFirst();
                for (int i = 0; i < bandedGridView_TaiSanMuaSam.RowCount; i++)
                {
                    if (Convert.ToBoolean(bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_Chon))) // == true
                    {
                        if (!string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_Chon))))
                        {
                            Lock_Unlock_Control(false); //Mở khóa lưu dữ liệu

                            Public.TSMS_Ma = Convert.ToInt32(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_Ma));

                            int kq = cls.TS_TaiSanMuaSam_Xoa(Public);
                            if (kq > 0)
                            {
                                Unlock_Control(true); //Mở khóa toàn bộ
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xin mời chọn lại dữ liệu trên lưới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    bandedGridView_TaiSanMuaSam.MoveNext();
                }

                //Chạy lại phần tìm kiếm
                frmTaiSanMuaSam_Load(sender, e);
            }
        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Public.HT_UserCreate = BienToanCuc.HT_USER_ID;
                //Public.TSMS_DateCreate =
                Public.HT_UserEditor = BienToanCuc.HT_USER_ID;
                //Public.TSMS_DateEditor =

                Public.TSMS_HienThi = true;
                Public.TSMS_SuDung = BienToanCuc.HT_PB_Ten;

                if (TS_TSMS_Add == true || TS_TSMS_Edit == true)
                {
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

                    bandedGridView_TaiSanMuaSam.MoveFirst();
                    for (int i = 0; i < bandedGridView_TaiSanMuaSam.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_Chon))) // == true
                        {
                            Public.TSMS_Ma = int.Parse("0" + bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_Ma));
                            Public.YC_Ma = int.Parse("0" + bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(YC_Ma));
                            Public.NTS_Ma = int.Parse("0" + bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(NTS_Ma));
                            Public.TSMS_LoaiTaiSan = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_LoaiTaiSan);
                            Public.TSMS_TenTaiSan = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_TenTaiSan);
                            Public.TSMS_Mota = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_Mota);
                            Public.TSMS_ThuongHieu = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_ThuongHieu);
                            Public.TSMS_XuatXu = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_XuatXu);
                            Public.TSMS_Model = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_Model);
                            Public.TSMS_KichThuoc_Dai = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_KichThuoc_Dai);
                            Public.TSMS_KichThuoc_Rong = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_KichThuoc_Rong);
                            Public.TSMS_KichThuoc_Cao = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_KichThuoc_Cao);
                            Public.TSMS_MauSac = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_MauSac);
                            Public.TSMS_DVT = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_DVT);
                            Public.TSMS_SoLuong = int.Parse("0" + bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_SoLuong));
                            Public.TSMS_DonGia = int.Parse("0" + bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_DonGia));
                            Public.TSMS_ThanhTien = Public.TSMS_SoLuong * Public.TSMS_DonGia; ;
                            Public.TSMS_NgayMua = Convert.ToDateTime(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_NgayMua));
                            Public.TSMS_Links = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_Links);
                            if (bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_AnhChupTaiSan).GetType().ToString() == "System.DBNull")
                                Public.TSMS_AnhChupTaiSan = null;
                            else
                                Public.TSMS_AnhChupTaiSan = bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_AnhChupTaiSan);
                            Public.TSMS_GhiChu = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_GhiChu);

                            if (TS_TSMS_Add == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.TS_TaiSanMuaSam_Them(Public);
                            }

                            if (TS_TSMS_Edit == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.TS_TaiSanMuaSam_Sua(Public);
                            }
                        }
                        bandedGridView_TaiSanMuaSam.MoveNext();
                    }
                }

                TraVe_DongDLChon();

                //Unlock_Control(true); //Mở khóa toàn bộ
                frmTaiSanMuaSam_Load(sender, e);
                Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
                Lock_Unlock_Control(true); //Mở khóa toàn bộ

                TS_TSMS_Add = false;
                TS_TSMS_Edit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            TS_TSMS_Add = false;
            TS_TSMS_Edit = false;

            Unlock_Control(true); //Mở khóa toàn bộ

            Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
            Lock_Unlock_Control(true); //Mở khóa toàn bộ
        }

        private void btnIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadHamDungChung.PreviewPrintableComponent(gridControl_TaiSanMuaSam, gridControl_TaiSanMuaSam.LookAndFeel);
        }

        #region Cho phép thực hiện thao tác CLICK phải chuột

        void Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_TaiSanMuaSam.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanMuaSam.RowCount; i++)
            {
                bandedGridView_TaiSanMuaSam.SetFocusedRowCellValue(TSMS_Chon, true);
                bandedGridView_TaiSanMuaSam.MoveNext();
            }
            bandedGridView_TaiSanMuaSam.MoveFirst();
        }

        void No_Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_TaiSanMuaSam.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanMuaSam.RowCount; i++)
            {
                bandedGridView_TaiSanMuaSam.SetFocusedRowCellValue(TSMS_Chon, false);
                bandedGridView_TaiSanMuaSam.MoveNext();
            }
            bandedGridView_TaiSanMuaSam.MoveFirst();
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