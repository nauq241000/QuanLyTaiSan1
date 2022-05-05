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
using DevExpress.XtraBars;
using System.Data.SqlClient;
using DevExpress.XtraPrinting;
using DevExpress.Export;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;

namespace QuanLyTaiSan
{
    public partial class frmQLTS_TaiSanYeuCau : DevExpress.XtraEditors.XtraForm
    {

        public frmQLTS_TaiSanYeuCau()
        {
            InitializeComponent();
            Lock_Unlock_Control_Input(false);
            new MultiSelectionEditingHelper(bandedGridView_TaiSanYeuCau);
        }

        TaiSanYeuCauBLL cls = new TaiSanYeuCauBLL();
        TaiSanYeuCauPublic Public = new TaiSanYeuCauPublic();

        HT_PQ_USERBLL cls_HT_PQ_USER = new HT_PQ_USERBLL();
        HT_PQ_USERPublic Public_HT_PQ_USER = new HT_PQ_USERPublic();

        Boolean TS_TSYC_Add = false;
        Boolean TS_TSYC_Edit = false;
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

        private void frmTaiSanYeuCau_Load(object sender, EventArgs e)
        {
            repositoryItemLookUpEdit_YeuCau.DataSource = cls.TS_YeuCau_Load();
            repositoryItemLookUpEdit_YeuCau.DisplayMember = "YC_TenYeuCau";
            repositoryItemLookUpEdit_YeuCau.ValueMember = "YC_Ma";

            repositoryItemLookUpEdit_YeuCau.PopupWidth = 1000;
            repositoryItemLookUpEdit_YeuCau.ShowFooter = false;
            repositoryItemLookUpEdit_YeuCau.Columns.Clear();
            repositoryItemLookUpEdit_YeuCau.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YC_Ma", "Mã", 100));
            repositoryItemLookUpEdit_YeuCau.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YC_NhomYeuCau", "Nhóm yêu cầu", 200));
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

            gridControl_TaiSanYeuCau.DataSource = cls.TS_TaiSanYeuCau_Load();
        }

        private void Lock_Unlock_Control_Input(bool Lock_Control)
        {
            this.TSYC_Ma.OptionsColumn.ReadOnly = true;
            this.YC_Ma.OptionsColumn.ReadOnly = !Lock_Control;
            this.NTS_Ma.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSYC_LoaiTaiSan.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSYC_TenTaiSan.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSYC_Mota.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSYC_ThuongHieu.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSYC_XuatXu.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSYC_Model.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSYC_KichThuoc_Dai.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSYC_KichThuoc_Rong.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSYC_KichThuoc_Cao.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSYC_MauSac.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSYC_DVT.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSYC_SoLuong.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSYC_DonGia.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSYC_ThanhTien.OptionsColumn.ReadOnly = true;
            this.TSYC_Links.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSYC_AnhChupTaiSan.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSYC_GhiChu.OptionsColumn.ReadOnly = !Lock_Control;
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
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_DonGia))) 
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

        private void TraVe_DongDLChon()
        {
            bandedGridView_TaiSanYeuCau.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanYeuCau.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(TSYC_Chon)))
                {
                    //Trả con trỏ về vị trí được chọn
                    break;
                }
                bandedGridView_TaiSanYeuCau.MoveNext();
            }
        }

        private void LoadDataCombobox()
        {
            repositoryItemComboBox_TSYC_XuatXu.Items.Clear();
            SqlDataReader dr_01 = LoadHamDungChung.TS_CBB_TSYC_XuatXu_Load();
            while (dr_01.Read())
            {
                repositoryItemComboBox_TSYC_XuatXu.Items.Add(Convert.ToString(dr_01["TSYC_XuatXu"]));
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
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTaiSanYeuCau_Load(sender, e);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TS_TSYC_Add = true;
            TS_TSYC_Edit = false;

            Lock_Unlock_Control_Input(true);
            Lock_Unlock_Control(false);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (KiemTra() == false)
            {
                MessageBox.Show("Bạn phải chọn dữ liệu", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_Chon))))
            {
                MessageBox.Show("Bạn phải lựa chọn lại dữ liệu trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {
                TS_TSYC_Add = false;
                TS_TSYC_Edit = true;

                Lock_Unlock_Control(false); //Mở khóa lưu dữ liệu
                Lock_Unlock_Control_Input(true); //Khóa điều khiển nhập dữ liệu
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (KiemTra() == false)
            {
                MessageBox.Show("Bạn phải chọn dữ liệu", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa dòng dữ liệu đã chọn?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bandedGridView_TaiSanYeuCau.MoveFirst();
                for (int i = 0; i < bandedGridView_TaiSanYeuCau.RowCount; i++)
                {
                    if (Convert.ToBoolean(bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(TSYC_Chon))) // == true
                    {
                        if (!string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_Chon))))
                        {
                            Lock_Unlock_Control(false); //Mở khóa lưu dữ liệu

                            Public.TSYC_Ma = Convert.ToInt32(bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_Ma));

                            int kq = cls.TS_TaiSanYeuCau_Xoa(Public);
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
                    bandedGridView_TaiSanYeuCau.MoveNext();
                }

                //Chạy lại phần tìm kiếm
                frmTaiSanYeuCau_Load(sender, e);
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Public.HT_UserCreate = BienToanCuc.HT_USER_ID;
                //Public.TSYC_DateCreate =
                Public.HT_UserEditor = BienToanCuc.HT_USER_ID;
                //Public.TSYC_DateEditor =

                Public.TSYC_HienThi = true;
                Public.TSYC_SuDung = BienToanCuc.HT_PB_Ten;

                if (TS_TSYC_Add == true || TS_TSYC_Edit == true)
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

                    bandedGridView_TaiSanYeuCau.MoveFirst();
                    for (int i = 0; i < bandedGridView_TaiSanYeuCau.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(TSYC_Chon))) // == true
                        {
                            Public.TSYC_Ma = int.Parse("0" + bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_Ma));
                            Public.YC_Ma = int.Parse("0" + bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(YC_Ma));
                            Public.NTS_Ma = int.Parse("0" + bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(NTS_Ma));
                            Public.TSYC_LoaiTaiSan = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_LoaiTaiSan);
                            Public.TSYC_TenTaiSan = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_TenTaiSan);
                            Public.TSYC_Mota = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_Mota);
                            Public.TSYC_ThuongHieu = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_ThuongHieu);
                            Public.TSYC_XuatXu = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_XuatXu);
                            Public.TSYC_Model = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_Model);
                            Public.TSYC_KichThuoc_Dai = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_KichThuoc_Dai);
                            Public.TSYC_KichThuoc_Rong = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_KichThuoc_Rong);
                            Public.TSYC_KichThuoc_Cao = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_KichThuoc_Cao);
                            Public.TSYC_MauSac = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_MauSac);
                            Public.TSYC_DVT = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_DVT);
                            Public.TSYC_SoLuong = int.Parse("0" + bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(TSYC_SoLuong));
                            Public.TSYC_DonGia = int.Parse("0" + bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(TSYC_DonGia));
                            try
                            {
                                Public.TSYC_ThanhTien = Public.TSYC_SoLuong * Public.TSYC_DonGia;
                            }
                            catch
                            {
                                Public.TSYC_ThanhTien = 0;
                            }
                            Public.TSYC_Links = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_Links);
                            if (bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(TSYC_AnhChupTaiSan).GetType().ToString() == "System.DBNull")
                                Public.TSYC_AnhChupTaiSan = null;
                            else
                                Public.TSYC_AnhChupTaiSan = (byte[])bandedGridView_TaiSanYeuCau.GetFocusedRowCellValue(TSYC_AnhChupTaiSan);
                            Public.TSYC_GhiChu = bandedGridView_TaiSanYeuCau.GetFocusedRowCellDisplayText(TSYC_GhiChu);

                            if (TS_TSYC_Add == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.TS_TaiSanYeuCau_Them(Public);
                            }

                            if (TS_TSYC_Edit == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.TS_TaiSanYeuCau_Sua(Public);
                            }
                        }
                        bandedGridView_TaiSanYeuCau.MoveNext();
                    }
                }

                TraVe_DongDLChon();

                //Unlock_Control(true); //Mở khóa toàn bộ
                frmTaiSanYeuCau_Load(sender, e);
                Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
                Lock_Unlock_Control(true); //Mở khóa toàn bộ

                TS_TSYC_Add = false;
                TS_TSYC_Edit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadHamDungChung.PreviewPrintableComponent(gridControl_TaiSanYeuCau, gridControl_TaiSanYeuCau.LookAndFeel);
        }

        private void btnDownload_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExportExcel("");
        }

        private bool ExportExcel(string fileName)
        {
            try
            {
                if (bandedGridView_TaiSanYeuCau.FocusedRowHandle < 0)
                {

                }
                else
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = @"Export file excel";
                    dialog.FileName = fileName;
                    dialog.Filter = @"Microsoft Excel|*.xlsx";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        bandedGridView_TaiSanYeuCau.ColumnPanelRowHeight = 40;
                        bandedGridView_TaiSanYeuCau.OptionsPrint.AutoWidth = AutoSize;
                        bandedGridView_TaiSanYeuCau.OptionsPrint.ShowPrintExportProgress = true;
                        bandedGridView_TaiSanYeuCau.OptionsPrint.AllowCancelPrintExport = true;
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = "Sheet1";

                        ExportSettings.DefaultExportType = ExportType.Default;
                        bandedGridView_TaiSanYeuCau.ExportToXlsx(dialog.FileName, options);
                        MessageBox.Show("Tải file thành công!!!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!", "Thông báo", MessageBoxButtons.OK);
            }
            return false;
        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            TS_TSYC_Add = false;
            TS_TSYC_Edit = false;

            Unlock_Control(true); //Mở khóa toàn bộ

            Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
            Lock_Unlock_Control(true); //Mở khóa toàn bộ
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