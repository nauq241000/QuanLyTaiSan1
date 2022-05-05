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
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;

namespace QuanLyTaiSan
{
    public partial class frmQLTS_QuanLyPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmQLTS_QuanLyPhong()
        {
            InitializeComponent();
            Lock_Unlock_Control_Input(false);
            new MultiSelectionEditingHelper(bandedGridView_QuanLyPhong);
        }

        QuanLyPhongBLL cls = new QuanLyPhongBLL();
        QuanLyPhongPublic Public = new QuanLyPhongPublic();

        HT_PQ_USERBLL cls_HT_PQ_USER = new HT_PQ_USERBLL();
        HT_PQ_USERPublic Public_HT_PQ_USER = new HT_PQ_USERPublic();

        Boolean TS_QLP_Add = false;
        Boolean TS_QLP_Edit = false;

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

        private void Lock_Unlock_Control_Input(bool Lock_Control)
        {
            this.QLP_Ma.OptionsColumn.ReadOnly = true;
            this.QLP_CoSo.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_DiaDiem.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_ToaNha.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_MaPhong.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_TenPhong.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_LoaiPhong.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_MoTa.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_TinhTrangSuDung.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_KichThuocDai.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_KichThuocRong.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_KichThuocCao.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_SoCho.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_BGSV_Ban.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_BGSV_Ghe.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_BGGV_Ban.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_BGGV_Ghe.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_NSSD_Ma.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_NSQL_Ma.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_AnhPhong.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_BanVe.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_GhiChu.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_HoanThanh.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_HT_MoTa.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_HT_MoTaChiTiet.OptionsColumn.ReadOnly = !Lock_Control;

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
            bandedGridView_QuanLyPhong.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyPhong.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_QuanLyPhong.GetFocusedRowCellValue(QLP_Chon)) &&
                        (
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_CoSo))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_DiaDiem))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_ToaNha))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_MaPhong))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_LoaiPhong))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_TenPhong)))

                        )
                    )
                {
                    return false;
                }
                bandedGridView_QuanLyPhong.MoveNext();
            }
            return true;
        }

        private bool KiemTra()
        {
            bandedGridView_QuanLyPhong.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyPhong.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_QuanLyPhong.GetFocusedRowCellValue(QLP_Chon)))
                {
                    return true;
                }
                bandedGridView_QuanLyPhong.MoveNext();
            }
            return false;
        }

        private void TraVe_DongDLChon()
        {
            bandedGridView_QuanLyPhong.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyPhong.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_QuanLyPhong.GetFocusedRowCellValue(QLP_Chon)))
                {
                    //Trả con trỏ về vị trí được chọn
                    break;
                }
                bandedGridView_QuanLyPhong.MoveNext();
            }
        }

        private void LoadDataCombobox()
        {
            repositoryItemComboBox_QLP_LoaiPhong.Items.Clear();
            SqlDataReader dr_01 = LoadHamDungChung.TS_CBB_QLP_LoaiPhong_Load();
            while (dr_01.Read())
            {
                repositoryItemComboBox_QLP_LoaiPhong.Items.Add(Convert.ToString(dr_01["QLP_LoaiPhong"]));
            }
            dr_01.Dispose();
            dr_01.Close();

        }

        private void frmQLTS_QuanLyPhong_Load(object sender, EventArgs e)
        {
            repositoryItemLookUpEdit_QLP_MaNhanSu.DataSource = cls.TS_QuanLyPhong_NhanSu_Load();
            repositoryItemLookUpEdit_QLP_MaNhanSu.DisplayMember = "QLNS_HoTen";
            repositoryItemLookUpEdit_QLP_MaNhanSu.ValueMember = "QLNS_Ma";

            repositoryItemLookUpEdit_QLP_MaNhanSu.PopupWidth = 1000;
            repositoryItemLookUpEdit_QLP_MaNhanSu.ShowFooter = false;
            repositoryItemLookUpEdit_QLP_MaNhanSu.Columns.Clear();
            repositoryItemLookUpEdit_QLP_MaNhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_Ma", "Mã", 100));
            repositoryItemLookUpEdit_QLP_MaNhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLDV_TenDonVi", "Tên đơn vị", 200));
            repositoryItemLookUpEdit_QLP_MaNhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_CoSo", "Cơ sở", 100));
            repositoryItemLookUpEdit_QLP_MaNhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_MaNhanSu", "Mã nhân sự", 100));
            repositoryItemLookUpEdit_QLP_MaNhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_HoTen", "Họ tên", 200));
            repositoryItemLookUpEdit_QLP_MaNhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_ChucVu", "Chức vụ", 100));
            repositoryItemLookUpEdit_QLP_MaNhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_SoDienThoai", "Số điện thoại", 200));

            LoadDataCombobox();

            gridControl_QuanLyPhong.DataSource = cls.TS_QuanLyPhong_Load();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQLTS_QuanLyPhong_Load(sender, e);
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            TS_QLP_Add = true;
            TS_QLP_Edit = false;

            Lock_Unlock_Control_Input(true);
            Lock_Unlock_Control(false);

        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTra() == false)
            {
                MessageBox.Show("Bạn phải chọn dữ liệu", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_Chon))))
            {
                MessageBox.Show("Bạn phải lựa chọn lại dữ liệu trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {
                TS_QLP_Add = false;
                TS_QLP_Edit = true;

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
                bandedGridView_QuanLyPhong.MoveFirst();
                for (int i = 0; i < bandedGridView_QuanLyPhong.RowCount; i++)
                {
                    if (Convert.ToBoolean(bandedGridView_QuanLyPhong.GetFocusedRowCellValue(QLP_Chon))) // == true
                    {
                        if (!string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_Chon))))
                        {
                            Lock_Unlock_Control(false); //Mở khóa lưu dữ liệu

                            Public.QLP_Ma = Convert.ToInt32(bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_Ma));

                            int kq = cls.TS_QuanLyPhong_Xoa(Public);
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
                    bandedGridView_QuanLyPhong.MoveNext();
                }

                //Chạy lại phần tìm kiếm
                frmQLTS_QuanLyPhong_Load(sender, e);
            }

        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Public.HT_UserCreate = BienToanCuc.HT_USER_ID;
                //Public.QLP_DateCreate =
                Public.HT_UserEditor = BienToanCuc.HT_USER_ID;
                //Public.QLP_DateEditor =

                Public.QLP_HienThi = true;
                Public.QLP_SuDung = BienToanCuc.HT_PB_Ten;

                if (TS_QLP_Add == true || TS_QLP_Edit == true)
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

                    bandedGridView_QuanLyPhong.MoveFirst();
                    for (int i = 0; i < bandedGridView_QuanLyPhong.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_QuanLyPhong.GetFocusedRowCellValue(QLP_Chon))) // == true
                        {
							Public.QLP_Ma =int.Parse("0" + bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_Ma ));
							Public.QLP_CoSo=bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_CoSo);
							Public.QLP_DiaDiem=bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_DiaDiem);
							Public.QLP_ToaNha=bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_ToaNha);
							Public.QLP_MaPhong=bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_MaPhong);
							Public.QLP_TenPhong=bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_TenPhong);
							Public.QLP_LoaiPhong=bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_LoaiPhong);
							Public.QLP_MoTa=bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_MoTa);
							Public.QLP_TinhTrangSuDung=Convert.ToBoolean(bandedGridView_QuanLyPhong.GetFocusedRowCellValue(QLP_TinhTrangSuDung));
							Public.QLP_KichThuocDai=bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_KichThuocDai);
							Public.QLP_KichThuocRong=bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_KichThuocRong);
							Public.QLP_KichThuocCao=bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_KichThuocCao);
							Public.QLP_SoCho=int.Parse("0" + bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_SoCho));
							Public.QLP_BGSV_Ban=int.Parse("0" + bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_BGSV_Ban));
							Public.QLP_BGSV_Ghe=int.Parse("0" + bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_BGSV_Ghe));
							Public.QLP_BGGV_Ban=int.Parse("0" + bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_BGGV_Ban));
							Public.QLP_BGGV_Ghe=int.Parse("0" + bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_BGGV_Ghe));
							Public.QLP_NSSD_Ma=int.Parse("0" + bandedGridView_QuanLyPhong.GetFocusedRowCellValue(QLP_NSSD_Ma));
							Public.QLP_NSQL_Ma=int.Parse("0" + bandedGridView_QuanLyPhong.GetFocusedRowCellValue(QLP_NSQL_Ma));
                            if (bandedGridView_QuanLyPhong.GetFocusedRowCellValue(QLP_AnhPhong).GetType().ToString() == "System.DBNull")
                                Public.QLP_AnhPhong = null;
                            else
                                Public.QLP_AnhPhong = (byte[])bandedGridView_QuanLyPhong.GetFocusedRowCellValue(QLP_AnhPhong);
                            if (bandedGridView_QuanLyPhong.GetFocusedRowCellValue(QLP_BanVe).GetType().ToString() == "System.DBNull")
                                Public.QLP_BanVe = null;
                            else
                                Public.QLP_BanVe = (byte[])bandedGridView_QuanLyPhong.GetFocusedRowCellValue(QLP_BanVe);
                            
							Public.QLP_GhiChu=bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_GhiChu);
                            Public.QLP_HoanThanh = Convert.ToBoolean(bandedGridView_QuanLyPhong.GetFocusedRowCellValue(QLP_HoanThanh));
							Public.QLP_HT_MoTa=Convert.ToBoolean(bandedGridView_QuanLyPhong.GetFocusedRowCellValue(QLP_HT_MoTa));
							Public.QLP_HT_MoTaChiTiet=bandedGridView_QuanLyPhong.GetFocusedRowCellDisplayText(QLP_HT_MoTaChiTiet);
							if (TS_QLP_Add == true)
                            {
                                int kq = cls.TS_QuanLyPhong_Them(Public);
                            }

                            if (TS_QLP_Edit == true)
                            {
                                //C?p nh?t d? li?u vào b?ng
                                int kq = cls.TS_QuanLyPhong_Sua(Public);
                            }
                        }
                        bandedGridView_QuanLyPhong.MoveNext();
                    }
                }

                TraVe_DongDLChon();

                //Unlock_Control(true); //M? khóa toàn b?
                frmQLTS_QuanLyPhong_Load(sender, e);
                Lock_Unlock_Control_Input(false); //Khóa di?u khi?n nh?p d? li?u
                Lock_Unlock_Control(true); //M? khóa toàn b?

                TS_QLP_Add = false;
                TS_QLP_Edit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            TS_QLP_Add = false;
            TS_QLP_Edit = false;

            Unlock_Control(true); //Mở khóa toàn bộ

            Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
            Lock_Unlock_Control(true); //Mở khóa toàn bộ
        }

        private void btnIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadHamDungChung.PreviewPrintableComponent(gridControl_QuanLyPhong, gridControl_QuanLyPhong.LookAndFeel);
        }

        #region Cho phép thực hiện thao tác CLICK phải chuột

        void Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_QuanLyPhong.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyPhong.RowCount; i++)
            {
                bandedGridView_QuanLyPhong.SetFocusedRowCellValue(QLP_Chon, true);
                bandedGridView_QuanLyPhong.MoveNext();
            }
            bandedGridView_QuanLyPhong.MoveFirst();
        }

        void No_Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_QuanLyPhong.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyPhong.RowCount; i++)
            {
                bandedGridView_QuanLyPhong.SetFocusedRowCellValue(QLP_Chon, false);
                bandedGridView_QuanLyPhong.MoveNext();
            }
            bandedGridView_QuanLyPhong.MoveFirst();
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