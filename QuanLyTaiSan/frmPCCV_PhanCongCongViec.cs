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
using DevExpress.XtraBars;
using System.Data.SqlClient;
using PhanCong;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;

namespace QuanLyTaiSan
{
    public partial class frmPCCV_PhanCongCongViec : DevExpress.XtraEditors.XtraForm
    {

        PhanCongCongViecBLL cls = new PhanCongCongViecBLL();
        PhanCongCongViecPublic Public = new PhanCongCongViecPublic();

        QuanLyNhanSuBLL cls_QuanLyNhanSuBLL = new QuanLyNhanSuBLL();
        QuanLyNhanSuPublic Public_QuanLyNhanSu = new QuanLyNhanSuPublic();

        DanhMucCongViecBLL cls_DanhMucCongViecBLL = new DanhMucCongViecBLL();
        DanhMucCongViecPublic Public_DanhMucCongViec = new DanhMucCongViecPublic();
        

        HT_PQ_USERBLL cls_HT_PQ_USER = new HT_PQ_USERBLL();
        HT_PQ_USERPublic Public_HT_PQ_USER = new HT_PQ_USERPublic();

        Boolean PC_PCCV_Add = false;
        Boolean PC_PCCV_Edit = false;



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

        public frmPCCV_PhanCongCongViec()
        {
            InitializeComponent();
            Lock_Unlock_Control_Input(false);

            new MultiSelectionEditingHelper(bandedGridView_PhanCongCongViec);

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPCCV_PhanCongCongViec_Load(sender, e);

        }

        private void frmPCCV_PhanCongCongViec_Load(object sender, EventArgs e)
        {

            repositoryItemLookUpEdit_NhanSu.DataSource = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_Load();
            repositoryItemLookUpEdit_NhanSu.DisplayMember = "QLNS_Ma";
            repositoryItemLookUpEdit_NhanSu.ValueMember = "QLNS_Ma";

            repositoryItemLookUpEdit_NhanSu.PopupWidth = 900;
            repositoryItemLookUpEdit_NhanSu.ShowFooter = false;
            repositoryItemLookUpEdit_NhanSu.Columns.Clear();
            repositoryItemLookUpEdit_NhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_Ma", "Mã đơn vị", 100));
            repositoryItemLookUpEdit_NhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_MaNhanSu", "Mã nhân sự", 100));
            repositoryItemLookUpEdit_NhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_HoTen", "Tên nhân sự", 200));
            repositoryItemLookUpEdit_NhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLDV_TenDonVi", "Tên đơn vị", 200));
            repositoryItemLookUpEdit_NhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_CoSo", "Cơ sở", 100));

            repositoryItemLookUpEdit_DonVi.DataSource = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_Load();
            repositoryItemLookUpEdit_DonVi.DisplayMember = "QLDV_TenDonVi";
            repositoryItemLookUpEdit_DonVi.ValueMember = "QLNS_Ma";

            repositoryItemLookUpEdit_HoTen.DataSource = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_Load();
            repositoryItemLookUpEdit_HoTen.DisplayMember = "QLNS_HoTen";
            repositoryItemLookUpEdit_HoTen.ValueMember = "QLNS_Ma";

            repositoryItemLookUpEdit_DiaDiem.DataSource = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_Load();
            repositoryItemLookUpEdit_DiaDiem.DisplayMember = "QLNS_CoSo";
            repositoryItemLookUpEdit_DiaDiem.ValueMember = "QLNS_Ma";

            repositoryItemLookUpEdit_CongViec.DataSource = cls_DanhMucCongViecBLL.PC_DanhMucCongViec_Load();
            repositoryItemLookUpEdit_CongViec.DisplayMember = "DMCV_TenCongViec";
            repositoryItemLookUpEdit_CongViec.ValueMember = "DMCV_Ma";

            repositoryItemLookUpEdit_CongViec.PopupWidth = 800;
            repositoryItemLookUpEdit_CongViec.ShowFooter = false;
            repositoryItemLookUpEdit_CongViec.Columns.Clear();
            repositoryItemLookUpEdit_CongViec.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DMCV_Ma", "Mã đơn vị", 100));
            repositoryItemLookUpEdit_CongViec.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DMCV_NhomCongViec", "Mã nhân sự", 100));
            repositoryItemLookUpEdit_CongViec.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DMCV_LoaiCongViec", "Tên nhân sự", 200));
            repositoryItemLookUpEdit_CongViec.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DMCV_TenCongViec", "Tên công việc", 200));
            repositoryItemLookUpEdit_CongViec.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DMCV_DacTinh", "Đặc tính", 100));
            repositoryItemLookUpEdit_CongViec.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DMCV_DiaDiem", "Địa điểm", 100));


            gridControl_PhanCongCongViec.DataSource = cls.PC_PhanCongCongViec_Load();
        }
        private void Lock_Unlock_Control_Input(bool Lock_Control)
        {
            this.PCCV_Ma.OptionsColumn.ReadOnly = true;
            this.QLNS_MaNSTH.OptionsColumn.ReadOnly = !Lock_Control;

            this.PCCV_DonVi.OptionsColumn.ReadOnly = true;
            this.QLNS_HoTen.OptionsColumn.ReadOnly = true;
            this.PCCV_DiaDiem.OptionsColumn.ReadOnly = true;
            this.PCCV_CongViecDuocGiao.OptionsColumn.ReadOnly = !Lock_Control;        
            this.PCCV_TrongTrach.OptionsColumn.ReadOnly = !Lock_Control;
            this.PCCV_GhiChu.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_MaNSKT.OptionsColumn.ReadOnly = !Lock_Control;
            this.PCCV_DonViKT.OptionsColumn.ReadOnly = true;
            this.PCCV_HoTenKT.OptionsColumn.ReadOnly = true;
            this.QLNS_MaNSQL.OptionsColumn.ReadOnly = !Lock_Control;
            this.PCCV_DonViQL.OptionsColumn.ReadOnly = true;
            this.PCCV_HoTenQL.OptionsColumn.ReadOnly = true;
          
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
            bandedGridView_PhanCongCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_PhanCongCongViec.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_PhanCongCongViec.GetFocusedRowCellValue(PCCV_Chon)) &&
                        (
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(QLNS_MaNSTH ))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(PCCV_DonVi))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(QLNS_HoTen))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(PCCV_DiaDiem))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(PCCV_CongViecDuocGiao))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(PCCV_TrongTrach )))||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(QLNS_MaNSKT))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(PCCV_DonViKT))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(PCCV_HoTenKT))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(QLNS_MaNSQL))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(PCCV_DonViQL))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(PCCV_HoTenQL))) 

                        )
                    )
                {
                    return false;
                }
                bandedGridView_PhanCongCongViec.MoveNext();
            }
            return true;
        }

        private bool KiemTra()
        {
            bandedGridView_PhanCongCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_PhanCongCongViec.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_PhanCongCongViec.GetFocusedRowCellValue(PCCV_Chon)))
                {
                    return true;
                }
                bandedGridView_PhanCongCongViec.MoveNext();
            }
            return false;
        }

        private void TraVe_DongDLChon()
        {
            bandedGridView_PhanCongCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_PhanCongCongViec.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_PhanCongCongViec.GetFocusedRowCellValue(PCCV_Chon)))
                {
                    //Trả con trỏ về vị trí được chọn
                    break;
                }
                bandedGridView_PhanCongCongViec.MoveNext();
            }
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            PC_PCCV_Add = true;
            PC_PCCV_Edit = false;

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

            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(PCCV_Chon))))
            {
                MessageBox.Show("Bạn phải lựa chọn lại dữ liệu trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {
                PC_PCCV_Add = false;
                PC_PCCV_Edit = true;

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
                bandedGridView_PhanCongCongViec.MoveFirst();
                for (int i = 0; i < bandedGridView_PhanCongCongViec.RowCount; i++)
                {
                    if (Convert.ToBoolean(bandedGridView_PhanCongCongViec.GetFocusedRowCellValue(PCCV_Chon))) // == true
                    {
                        if (!string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(PCCV_Chon))))
                        {
                            Lock_Unlock_Control(false); //Mở khóa lưu dữ liệu

                            Public.PCCV_Ma = Convert.ToInt32(bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(PCCV_Ma));

                            int kq = cls.PC_PhanCongCongViec_Xoa(Public);
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
                    bandedGridView_PhanCongCongViec.MoveNext();
                }

                //Chạy lại phần tìm kiếm
                frmPCCV_PhanCongCongViec_Load(sender, e);

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

                Public.PCCV_HienThi = true;
                Public.PCCV_SuDung = BienToanCuc.HT_PB_Ten;

                if (PC_PCCV_Add == true || PC_PCCV_Edit == true)
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

                    bandedGridView_PhanCongCongViec.MoveFirst();
                    for (int i = 0; i < bandedGridView_PhanCongCongViec.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_PhanCongCongViec.GetFocusedRowCellValue(PCCV_Chon))) // == true
                        {


                            Public.PCCV_Ma =int.Parse("0" + bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(PCCV_Ma ));
                            Public.QLNS_MaNSTH =int.Parse("0" + bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(QLNS_MaNSTH ));
                            Public.QLNS_MaNSKT = int.Parse("0" + bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(QLNS_MaNSKT));
                            Public.QLNS_MaNSQL = int.Parse("0" + bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(QLNS_MaNSQL));
                            Public.DMCV_Ma = int.Parse("0" + bandedGridView_PhanCongCongViec.GetFocusedRowCellValue(PCCV_CongViecDuocGiao));                                                    
                            Public.PCCV_TrongTrach =int.Parse("0" + bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(PCCV_TrongTrach ));
                            Public.PCCV_GhiChu = bandedGridView_PhanCongCongViec.GetFocusedRowCellDisplayText(PCCV_GhiChu);






                            if (PC_PCCV_Add == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.PC_PhanCongCongViec_Them(Public);
                            }

                            if (PC_PCCV_Edit == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.PC_PhanCongCongViec_Sua(Public);
                            }
                        }
                        bandedGridView_PhanCongCongViec.MoveNext();
                    
                   }
                }
                TraVe_DongDLChon();

                //Unlock_Control(true); //Mở khóa toàn bộ
                frmPCCV_PhanCongCongViec_Load(sender, e);
                Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
                Lock_Unlock_Control(true); //Mở khóa toàn bộ

                PC_PCCV_Add = false;
                PC_PCCV_Edit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bandedGridView_PhanCongCongViec_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            

        }

        private void bandedGridView_PhanCongCongViec_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            QuanLyNhanSuPublic Public_QuanLyNhanSu = new QuanLyNhanSuPublic();
            DanhMucCongViecPublic Public_DanhMucCongViec = new DanhMucCongViecPublic();

            if (e.Column == PCCV_CongViecDuocGiao)
            {
                //IssueBin bin = (IssueBin)issueBinGridView.GetRow(e.RowHandle);
                //itemSerialBindingSource.DataSource = bin.AvailableSerialIDList;

                repositoryItemLookUpEdit_LocCongViec.DataSource = cls_DanhMucCongViecBLL.PC_DanhMucCongViec_Load();
                repositoryItemLookUpEdit_LocCongViec.DisplayMember = "DMCV_TenCongViec";
                repositoryItemLookUpEdit_LocCongViec.ValueMember = "DMCV_Ma";

                repositoryItemLookUpEdit_LocCongViec.PopupWidth = 800;
                repositoryItemLookUpEdit_LocCongViec.ShowFooter = false;
                repositoryItemLookUpEdit_LocCongViec.Columns.Clear();
                repositoryItemLookUpEdit_LocCongViec.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DMCV_Ma", "Mã công việc", 100));
                repositoryItemLookUpEdit_LocCongViec.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DMCV_NhomCongViec", "Nhóm công việc", 200));
                repositoryItemLookUpEdit_LocCongViec.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DMCV_LoaiCongViec", "Loại công việc", 100));
                repositoryItemLookUpEdit_LocCongViec.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DMCV_TenCongViec", "Tên công việc", 200));
                repositoryItemLookUpEdit_LocCongViec.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DMCV_DacTinh", "Đặc tính", 100));
                repositoryItemLookUpEdit_LocCongViec.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DMCV_DiaDiem", "Địa điểm", 200));


                e.RepositoryItem = repositoryItemLookUpEdit_LocCongViec;
            }

        }


        #region Cho phép thực hiện thao tác CLICK phải chuột

        void Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_PhanCongCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_PhanCongCongViec.RowCount; i++)
            {
                bandedGridView_PhanCongCongViec.SetFocusedRowCellValue(PCCV_Chon, true);
                bandedGridView_PhanCongCongViec.MoveNext();
            }
            bandedGridView_PhanCongCongViec.MoveFirst();
        }

        void No_Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_PhanCongCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_PhanCongCongViec.RowCount; i++)
            {
                bandedGridView_PhanCongCongViec.SetFocusedRowCellValue(PCCV_Chon, false);
                bandedGridView_PhanCongCongViec.MoveNext();
            }
            bandedGridView_PhanCongCongViec.MoveFirst();
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

        private void btnIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadHamDungChung.PreviewPrintableComponent(gridControl_PhanCongCongViec, gridControl_PhanCongCongViec.LookAndFeel);
        }

    }
}