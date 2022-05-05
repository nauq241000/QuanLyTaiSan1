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
using System.IO;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;

namespace QuanLyTaiSan
{
    public partial class frmQLTS_YeuCau : DevExpress.XtraEditors.XtraForm
    {
        public frmQLTS_YeuCau()
        {
            InitializeComponent();
            Lock_Unlock_Control_Input(false);
            new MultiSelectionEditingHelper(bandedGridView_YeuCau);
        }

        YeuCauBLL cls = new YeuCauBLL();
        YeuCauPublic Public = new YeuCauPublic();

        QuanLyPhongBLL cls_QuanLyPhongBLL = new QuanLyPhongBLL();

        HT_PQ_USERBLL cls_HT_PQ_USER = new HT_PQ_USERBLL();
        HT_PQ_USERPublic Public_HT_PQ_USER = new HT_PQ_USERPublic();

        Boolean TS_YC_Add = false;
        Boolean TS_YC_Edit = false;
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

        private void frmYeuCau_Load(object sender, EventArgs e)
        {
            repositoryItemLookUpEdit_QLNS_Ma.DataSource = cls_QuanLyPhongBLL.TS_QuanLyPhong_NhanSu_Load();
            repositoryItemLookUpEdit_QLNS_Ma.DisplayMember = "QLNS_MaNhanSu";
            repositoryItemLookUpEdit_QLNS_Ma.ValueMember = "QLNS_Ma";

            repositoryItemLookUpEdit_QLNS_Ma.PopupWidth = 1000;
            repositoryItemLookUpEdit_QLNS_Ma.ShowFooter = false;
            repositoryItemLookUpEdit_QLNS_Ma.Columns.Clear();
            repositoryItemLookUpEdit_QLNS_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_Ma", "Mã", 100));
            repositoryItemLookUpEdit_QLNS_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLDV_TenDonVi", "Tên đơn vị", 200));
            repositoryItemLookUpEdit_QLNS_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_CoSo", "Cơ sở", 100));
            repositoryItemLookUpEdit_QLNS_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_MaNhanSu", "Mã nhân sự", 100));
            repositoryItemLookUpEdit_QLNS_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_HoTen", "Họ tên", 200));
            repositoryItemLookUpEdit_QLNS_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_ChucVu", "Chức vụ", 100));
            repositoryItemLookUpEdit_QLNS_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_SoDienThoai", "Số điện thoại", 200));

            repositoryItemLookUpEdit_TenNguoiDeNghi.DataSource = cls_QuanLyPhongBLL.TS_QuanLyPhong_NhanSu_Load();
            repositoryItemLookUpEdit_TenNguoiDeNghi.DisplayMember = "QLNS_HoTen";
            repositoryItemLookUpEdit_TenNguoiDeNghi.ValueMember = "QLNS_Ma";

            repositoryItemLookUpEdit_TenNguoiDeNghi.PopupWidth = 1000;
            repositoryItemLookUpEdit_TenNguoiDeNghi.ShowFooter = false;
            repositoryItemLookUpEdit_TenNguoiDeNghi.Columns.Clear();
            repositoryItemLookUpEdit_TenNguoiDeNghi.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_Ma", "Mã", 100));
            repositoryItemLookUpEdit_TenNguoiDeNghi.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLDV_TenDonVi", "Tên đơn vị", 200));
            repositoryItemLookUpEdit_TenNguoiDeNghi.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_CoSo", "Cơ sở", 100));
            repositoryItemLookUpEdit_TenNguoiDeNghi.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_MaNhanSu", "Mã nhân sự", 100));
            repositoryItemLookUpEdit_TenNguoiDeNghi.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_HoTen", "Họ tên", 200));
            repositoryItemLookUpEdit_TenNguoiDeNghi.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_ChucVu", "Chức vụ", 100));
            repositoryItemLookUpEdit_TenNguoiDeNghi.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_SoDienThoai", "Số điện thoại", 200));

            gridControl_YeuCau.DataSource = cls.TS_YeuCau_Load();
        }

        private void Lock_Unlock_Control_Input(bool Lock_Control)
        {
            this.YC_Ma.OptionsColumn.ReadOnly = true;
            this.YC_NhomYeuCau.OptionsColumn.ReadOnly = !Lock_Control;
            this.YC_TenYeuCau.OptionsColumn.ReadOnly = !Lock_Control;
            this.YC_NgayYeuCau.OptionsColumn.ReadOnly = !Lock_Control;
            this.YC_DonViYeuCau.OptionsColumn.ReadOnly = !Lock_Control;
            this.YC_NguoiDeNghi.OptionsColumn.ReadOnly = !Lock_Control;
            this.YC_TenFile.OptionsColumn.ReadOnly = !Lock_Control;
            this.YC_DataFile.OptionsColumn.ReadOnly = !Lock_Control;
            this.YC_GhiChu.OptionsColumn.ReadOnly = !Lock_Control;
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
            bandedGridView_YeuCau.MoveFirst();
            for (int i = 0; i < bandedGridView_YeuCau.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_YeuCau.GetFocusedRowCellValue(YC_Chon)) &&
                        (
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_TenYeuCau))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_DonViYeuCau))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_NgayYeuCau))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_NguoiDeNghi))) 
                        )
                    )
                {
                    return false;
                }
                bandedGridView_YeuCau.MoveNext();
            }
            return true;
        }

        private bool KiemTra()
        {
            bandedGridView_YeuCau.MoveFirst();
            for (int i = 0; i < bandedGridView_YeuCau.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_YeuCau.GetFocusedRowCellValue(YC_Chon)))
                {
                    return true;
                }
                bandedGridView_YeuCau.MoveNext();
            }
            return false;
        }

        private void TraVe_DongDLChon()
        {
            bandedGridView_YeuCau.MoveFirst();
            for (int i = 0; i < bandedGridView_YeuCau.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_YeuCau.GetFocusedRowCellValue(YC_Chon)))
                {
                    //Trả con trỏ về vị trí được chọn
                    break;
                }
                bandedGridView_YeuCau.MoveNext();
            }
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmYeuCau_Load(sender, e);
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            TS_YC_Add = true;
            TS_YC_Edit = false;

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

            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_Chon))))
            {
                MessageBox.Show("Bạn phải lựa chọn lại dữ liệu trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {
                TS_YC_Add = false;
                TS_YC_Edit = true;

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
                bandedGridView_YeuCau.MoveFirst();
                for (int i = 0; i < bandedGridView_YeuCau.RowCount; i++)
                {
                    if (Convert.ToBoolean(bandedGridView_YeuCau.GetFocusedRowCellValue(YC_Chon))) // == true
                    {
                        if (!string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_Chon))))
                        {
                            Lock_Unlock_Control(false); //Mở khóa lưu dữ liệu

                            Public.YC_Ma = Convert.ToInt32(bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_Ma));

                            int kq = cls.TS_YeuCau_Xoa(Public);
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
                    bandedGridView_YeuCau.MoveNext();
                }

                //Chạy lại phần tìm kiếm
                frmYeuCau_Load(sender, e);
            }
        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Public.HT_UserCreate = BienToanCuc.HT_USER_ID;
                //Public.YC_DateCreate =
                Public.HT_UserEditor = BienToanCuc.HT_USER_ID;
                //Public.YC_DateEditor =

                Public.YC_HienThi = true;
                Public.YC_SuDung = BienToanCuc.HT_PB_Ten;

                if (TS_YC_Add == true || TS_YC_Edit == true)
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

                    bandedGridView_YeuCau.MoveFirst();
                    for (int i = 0; i < bandedGridView_YeuCau.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_YeuCau.GetFocusedRowCellValue(YC_Chon))) // == true
                        {
                            Public.YC_Ma = int.Parse("0" + bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_Ma));
                            Public.YC_NhomYeuCau = bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_NhomYeuCau);
                            Public.YC_TenYeuCau = bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_TenYeuCau);
                            Public.YC_NgayYeuCau = Convert.ToDateTime(bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_NgayYeuCau));
                            Public.YC_DonViYeuCau = bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_DonViYeuCau);
                            Public.YC_NguoiDeNghi = bandedGridView_YeuCau.GetFocusedRowCellValue(YC_NguoiDeNghi).ToString();

                            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_TenFile))) &&
                                string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_DataFile)))
                                )
                            {
                                Public.YC_TenFile = null;
                                Public.YC_DataFile = null;

                            }
                            else
                            {
                                Public.YC_TenFile = bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_TenFile);
                                Public.YC_DataFile = ReadFile(bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_DataFile));
                            }

                            Public.YC_GhiChu = bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_GhiChu);

                            if (TS_YC_Add == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.TS_YeuCau_Them(Public);
                            }

                            if (TS_YC_Edit == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.TS_YeuCau_Sua(Public);
                            }
                        }
                        bandedGridView_YeuCau.MoveNext();
                    }
                }

                TraVe_DongDLChon();

                //Unlock_Control(true); //Mở khóa toàn bộ
                frmYeuCau_Load(sender, e);
                Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
                Lock_Unlock_Control(true); //Mở khóa toàn bộ

                TS_YC_Add = false;
                TS_YC_Edit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        byte[] ReadFile(string sPath)
        {
            //Nếu Upload Logo
            if (!string.IsNullOrWhiteSpace(sPath))
            {
                //Initialize byte array with a null value initially.
                byte[] data = null;

                //Use FileInfo object to get file size.
                FileInfo fInfo = new FileInfo(sPath);
                long numBytes = fInfo.Length;

                //Open FileStream to read file
                FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

                //Use BinaryReader to read file stream into byte array.
                BinaryReader br = new BinaryReader(fStream);

                //When you use BinaryReader, you need to supply number of bytes to read from file.
                //In this case we want to read entire file. So supplying total number of bytes.
                data = br.ReadBytes((int)numBytes);

                //Close BinaryReader
                br.Close();

                //Close FileStream
                fStream.Close();

                return data;
            }
            //Nếu không Upload Logo
            else
            {
                byte[] data = null;
                return data;
            }
        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            TS_YC_Add = false;
            TS_YC_Edit = false;

            Unlock_Control(true); //Mở khóa toàn bộ

            Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
            Lock_Unlock_Control(true); //Mở khóa toàn bộ
        }

        private void btnIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadHamDungChung.PreviewPrintableComponent(gridControl_YeuCau, gridControl_YeuCau.LookAndFeel);
        }

        private void btnDownload_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //Start - Download
                Public.YC_Ma = int.Parse("0" + bandedGridView_YeuCau.GetFocusedRowCellDisplayText(YC_Ma));

                SqlDataReader dr = cls.TS_YeuCau_Load_R_Para_File(Public);
                dr.Read();

                string TenFile = "";
                saveFileDialog1.FileName = Convert.ToString(dr["YC_TenFile"].ToString());

                DialogResult DR = saveFileDialog1.ShowDialog();
                if (DR == DialogResult.OK)
                {
                    TenFile = saveFileDialog1.FileName;
                    //Get File data from dataset row.
                    byte[] FileDinhKem = (byte[])dr["YC_DataFile"];

                    using (FileStream fs = new FileStream(TenFile, FileMode.Create))
                    {
                        fs.Write(FileDinhKem, 0, FileDinhKem.Length);
                        fs.Close();
                    }
                }
                else
                {
                    dr.Dispose();
                    dr.Close();
                    return;
                }

                dr.Dispose();
                dr.Close();

                MessageBox.Show("Tải file thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.None);

                //End - Download mẫu lấy thông tin
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại file NỘI DUNG ĐÍNH KÈM! (ID file: " + Public.YC_Ma + ")", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void repositoryItemButtonEdit_TenFile_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgRes = dlg.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {
                //Provide file path in txtVBM_DataFileUpload text box.
                //txtVBM_DataFileUpload.Text = dlg.FileName;
                bandedGridView_YeuCau.SetFocusedRowCellValue(YC_DataFile, dlg.FileName);

                //FileInfo Ten_File = new FileInfo(txtVBM_DataFileUpload.Text);
                FileInfo Ten_File = new FileInfo(dlg.FileName);

                //txtVBM_FileNameUpload.Text = Ten_File.Name;
                bandedGridView_YeuCau.SetFocusedRowCellValue(YC_TenFile, Ten_File.Name);
            }
        }

        #region Cho phép thực hiện thao tác CLICK phải chuột

        void Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_YeuCau.MoveFirst();
            for (int i = 0; i < bandedGridView_YeuCau.RowCount; i++)
            {
                bandedGridView_YeuCau.SetFocusedRowCellValue(YC_Chon, true);
                bandedGridView_YeuCau.MoveNext();
            }
            bandedGridView_YeuCau.MoveFirst();
        }

        void No_Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_YeuCau.MoveFirst();
            for (int i = 0; i < bandedGridView_YeuCau.RowCount; i++)
            {
                bandedGridView_YeuCau.SetFocusedRowCellValue(YC_Chon, false);
                bandedGridView_YeuCau.MoveNext();
            }
            bandedGridView_YeuCau.MoveFirst();
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