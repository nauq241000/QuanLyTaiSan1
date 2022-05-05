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
using System.Security.Cryptography;

namespace QuanLyTaiSan
{
    public partial class frmQLTS_QuanLyNhanSu : DevExpress.XtraEditors.XtraForm
    {
        public frmQLTS_QuanLyNhanSu()
        {
            InitializeComponent();
            Lock_Unlock_Control_Input(false);
            new MultiSelectionEditingHelper(bandedGridView_QuanLyNhanSu);
        }

        QuanLyNhanSuBLL cls = new QuanLyNhanSuBLL();
        QuanLyNhanSuPublic Public = new QuanLyNhanSuPublic();

        HT_PQ_USERBLL cls_HT_PQ_USER = new HT_PQ_USERBLL();
        HT_PQ_USERPublic Public_HT_PQ_USER = new HT_PQ_USERPublic();

        Boolean TS_QLNS_Add = false;
        Boolean TS_QLNS_Edit = false;
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

        private void frmQLTS_QuanLyNhanSu_Load(object sender, EventArgs e)
        {
            repositoryItemLookUpEdit_QLDV_Ma.DataSource = cls.TS_QuanLyNhanSu_DonVi_Load();
            repositoryItemLookUpEdit_QLDV_Ma.DisplayMember = "QLDV_TenDonVi";
            repositoryItemLookUpEdit_QLDV_Ma.ValueMember = "QLDV_Ma";

            repositoryItemLookUpEdit_QLDV_Ma.PopupWidth = 500;
            repositoryItemLookUpEdit_QLDV_Ma.ShowFooter = false;
            repositoryItemLookUpEdit_QLDV_Ma.Columns.Clear();
            //repositoryItemLookUpEdit_QLDV_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLDV_Ma", "Mã đơn vị", 100));
            repositoryItemLookUpEdit_QLDV_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLDV_MaDonVi", "Mã đơn vị", 100));
            repositoryItemLookUpEdit_QLDV_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLDV_TenDonVi", "TenDonVi", 200));
            repositoryItemLookUpEdit_QLDV_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLDV_MoTa", "Mô tả", 200));

            gridControl_QuanLyNhanSu.DataSource = cls.TS_QuanLyNhanSu_Load();
        }

        private void Lock_Unlock_Control_Input(bool Lock_Control)
        {
            this.QLNS_Ma.OptionsColumn.ReadOnly = true;
            this.QLDV_Ma.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_CoSo.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_MaNhanSu.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_HoTen.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_ChucVu.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_ChuyenMon.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_DiaChi.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_SoCMT.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_NgayCap.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_NoiCap.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_SoDienThoai.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_Email.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_GhiChu.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_TenFile.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_DataFile.OptionsColumn.ReadOnly = !Lock_Control;

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
            bandedGridView_QuanLyNhanSu.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyNhanSu.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_QuanLyNhanSu.GetFocusedRowCellValue(QLNS_Chon)) &&
                        (
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLDV_Ma))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_CoSo))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_MaNhanSu))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_HoTen))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_ChucVu)))
                        )
                    )
                {
                    return false;
                }
                bandedGridView_QuanLyNhanSu.MoveNext();
            }
            return true;
        }

        private bool KiemTra()
        {
            bandedGridView_QuanLyNhanSu.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyNhanSu.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_QuanLyNhanSu.GetFocusedRowCellValue(QLNS_Chon)))
                {
                    return true;
                }
                bandedGridView_QuanLyNhanSu.MoveNext();
            }
            return false;
        }

        private void TraVe_DongDLChon()
        {
            bandedGridView_QuanLyNhanSu.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyNhanSu.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_QuanLyNhanSu.GetFocusedRowCellValue(QLNS_Chon)))
                {
                    //Trả con trỏ về vị trí được chọn
                    break;
                }
                bandedGridView_QuanLyNhanSu.MoveNext();
            }
        }


        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQLTS_QuanLyNhanSu_Load(sender, e);
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            TS_QLNS_Add = true;
            TS_QLNS_Edit = false;

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

            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_Chon))))
            {
                MessageBox.Show("Bạn phải lựa chọn lại dữ liệu trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {
                TS_QLNS_Add = false;
                TS_QLNS_Edit = true;

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
                bandedGridView_QuanLyNhanSu.MoveFirst();
                for (int i = 0; i < bandedGridView_QuanLyNhanSu.RowCount; i++)
                {
                    if (Convert.ToBoolean(bandedGridView_QuanLyNhanSu.GetFocusedRowCellValue(QLNS_Chon))) // == true
                    {
                        if (!string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_Chon))))
                        {
                            Lock_Unlock_Control(false); //Mở khóa lưu dữ liệu

                            Public.QLNS_Ma = Convert.ToInt32(bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_Ma));

                            int kq = cls.TS_QuanLyNhanSu_Xoa(Public);
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
                    bandedGridView_QuanLyNhanSu.MoveNext();
                }

                //Chạy lại phần tìm kiếm
                frmQLTS_QuanLyNhanSu_Load(sender, e);
            }
        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Public.HT_USER_Create = BienToanCuc.HT_USER_ID;
                //Public.QLNS_DateCreate =
                Public.HT_USER_Editor = BienToanCuc.HT_USER_ID;
                //Public.QLNS_DateEditor =

                Public.QLNS_HienThi = true;
                Public.QLNS_SuDung = BienToanCuc.HT_PB_Ten;

                if (TS_QLNS_Add == true || TS_QLNS_Edit == true)
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

                    bandedGridView_QuanLyNhanSu.MoveFirst();
                    for (int i = 0; i < bandedGridView_QuanLyNhanSu.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_QuanLyNhanSu.GetFocusedRowCellValue(QLNS_Chon))) // == true
                        {
                            Public.QLNS_Ma = int.Parse("0" + bandedGridView_QuanLyNhanSu.GetFocusedRowCellValue(QLNS_Ma));
                            Public.QLDV_Ma = int.Parse("0" + bandedGridView_QuanLyNhanSu.GetFocusedRowCellValue(QLDV_Ma));
                            Public.QLNS_CoSo = bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_CoSo);
                            Public.QLNS_MaNhanSu = bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_MaNhanSu);
                            Public.QLNS_HoTen = bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_HoTen);
                            Public.QLNS_ChucVu = bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_ChucVu);
                            Public.QLNS_ChuyenMon = bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_ChuyenMon);
                            Public.QLNS_DiaChi = bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_DiaChi);
                            Public.QLNS_SoCMT = bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_SoCMT);

                            if (bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_NgayCap).ToString() == "")
                                Public.QLNS_NgayCap = null;
                            else
                                Public.QLNS_NgayCap = Convert.ToDateTime(bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_NgayCap));

                            
                            Public.QLNS_NoiCap = bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_NoiCap);
                            Public.QLNS_SoDienThoai = bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_SoDienThoai);
                            Public.QLNS_Email = bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_Email);
                            Public.QLNS_GhiChu = bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_GhiChu);

                            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_TenFile))) &&
                                string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_DataFile)))
                                )
                            {
                                Public.QLNS_TenFile = null;
                                Public.QLNS_DataFile = null;

                            }
                            else
                            {
                                Public.QLNS_TenFile = bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_TenFile);
                                Public.QLNS_DataFile = ReadFile(bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_DataFile));
                            }

                            if (TS_QLNS_Add == true)
                            {
                                //Cập nhật dữ liệu vào bảng

                                NhanSuDangNhapPublic Public_DangNhapNhanSu = new NhanSuDangNhapPublic();
                                Public_DangNhapNhanSu.QLNS_MaNhanSu = Public.QLNS_MaNhanSu;
                                Public_DangNhapNhanSu.NSDN_MatKhau = toMD5("123");
                                cls.AddLogin(Public_DangNhapNhanSu);
                                int kq = cls.TS_QuanLyNhanSu_Them(Public);

                            }

                            if (TS_QLNS_Edit == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.TS_QuanLyNhanSu_Sua(Public);
                            }
                        }
                        bandedGridView_QuanLyNhanSu.MoveNext();
                    }
                }

                TraVe_DongDLChon();

                //Unlock_Control(true); //Mở khóa toàn bộ
                frmQLTS_QuanLyNhanSu_Load(sender, e);
                Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
                Lock_Unlock_Control(true); //Mở khóa toàn bộ

                TS_QLNS_Add = false;
                TS_QLNS_Edit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            TS_QLNS_Add = false;
            TS_QLNS_Edit = false;

            Unlock_Control(true); //Mở khóa toàn bộ

            Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
            Lock_Unlock_Control(true); //Mở khóa toàn bộ
        }

        private void btnIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadHamDungChung.PreviewPrintableComponent(gridControl_QuanLyNhanSu, gridControl_QuanLyNhanSu.LookAndFeel);
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

        private void btnDownload_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //Start - Download
                Public.QLNS_Ma = int.Parse("0" + bandedGridView_QuanLyNhanSu.GetFocusedRowCellDisplayText(QLNS_Ma));

                SqlDataReader dr = cls.TS_QuanLyNhanSu_Load_R_Para_File(Public);
                dr.Read();

                string TenFile = "";
                saveFileDialog1.FileName = Convert.ToString(dr["QLNS_TenFile"].ToString());

                DialogResult DR = saveFileDialog1.ShowDialog();
                if (DR == DialogResult.OK)
                {
                    TenFile = saveFileDialog1.FileName;
                    //Get File data from dataset row.
                    byte[] FileDinhKem = (byte[])dr["QLNS_DataFile"];

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
                MessageBox.Show("Không tồn tại file NỘI DUNG ĐÍNH KÈM! (ID file: " + Public.QLNS_Ma + ")", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void repositoryItemButtonEdit_QLNS_TenFile_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgRes = dlg.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {
                //Provide file path in txtVBM_DataFileUpload text box.
                //txtVBM_DataFileUpload.Text = dlg.FileName;
                bandedGridView_QuanLyNhanSu.SetFocusedRowCellValue(QLNS_DataFile, dlg.FileName);

                //FileInfo Ten_File = new FileInfo(txtVBM_DataFileUpload.Text);
                FileInfo Ten_File = new FileInfo(dlg.FileName);

                //txtVBM_FileNameUpload.Text = Ten_File.Name;
                bandedGridView_QuanLyNhanSu.SetFocusedRowCellValue(QLNS_TenFile, Ten_File.Name);
            }
        }

        public static string toMD5(string pass)
        {
            MD5CryptoServiceProvider myMD5 = new MD5CryptoServiceProvider();
            byte[] myPass = System.Text.Encoding.UTF8.GetBytes(pass);
            myPass = myMD5.ComputeHash(myPass);

            StringBuilder s = new StringBuilder();
            foreach (byte p in myPass)
            {
                s.Append(p.ToString("x2").ToLower());
            }
            return s.ToString();
        }

        #region Cho phép thực hiện thao tác CLICK phải chuột

        void Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_QuanLyNhanSu.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyNhanSu.RowCount; i++)
            {
                bandedGridView_QuanLyNhanSu.SetFocusedRowCellValue(QLNS_Chon, true);
                bandedGridView_QuanLyNhanSu.MoveNext();
            }
            bandedGridView_QuanLyNhanSu.MoveFirst();
        }

        void No_Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_QuanLyNhanSu.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyNhanSu.RowCount; i++)
            {
                bandedGridView_QuanLyNhanSu.SetFocusedRowCellValue(QLNS_Chon, false);
                bandedGridView_QuanLyNhanSu.MoveNext();
            }
            bandedGridView_QuanLyNhanSu.MoveFirst();
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