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
    public partial class frmPCCV_DanhMucCongViec : DevExpress.XtraEditors.XtraForm
    {
        public frmPCCV_DanhMucCongViec()
        {
            InitializeComponent();
            Lock_Unlock_Control_Input(false);
            new MultiSelectionEditingHelper(bandedGridView_DanhMucCongViec);
        }

        DanhMucCongViecBLL cls = new DanhMucCongViecBLL();
        DanhMucCongViecPublic Public = new DanhMucCongViecPublic();

        QuanLyNhanSuBLL cls_QuanLuNhanSuBLL = new QuanLyNhanSuBLL();

        HT_PQ_USERBLL cls_HT_PQ_USER = new HT_PQ_USERBLL();
        HT_PQ_USERPublic Public_HT_PQ_USER = new HT_PQ_USERPublic();

        Boolean PC_DMCV_Add = false;
        Boolean PC_DMCV_Edit = false;


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
            this.DMCV_Ma.OptionsColumn.ReadOnly = true;
            this.DMCV_NhomCongViec.OptionsColumn.ReadOnly = !Lock_Control;
            this.DMCV_LoaiCongViec.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLDV_Ma.OptionsColumn.ReadOnly = !Lock_Control;
            this.DMCV_TenCongViec.OptionsColumn.ReadOnly = !Lock_Control;
            this.DMCV_DacTinh.OptionsColumn.ReadOnly = !Lock_Control;
            this.DMCV_DiaDiem.OptionsColumn.ReadOnly = !Lock_Control;
            this.DMCV_ThoiGianBatDau.OptionsColumn.ReadOnly = !Lock_Control;
            this.DMCV_ThoiGianHoanThanh.OptionsColumn.ReadOnly = !Lock_Control;
            this.DMCV_TenFileDinhKem.OptionsColumn.ReadOnly = !Lock_Control;
            this.DMCV_DataFileDinhKem.OptionsColumn.ReadOnly = !Lock_Control;
            this.DMCV_MoTa.OptionsColumn.ReadOnly = !Lock_Control;
            this.DMCV_GhiChu.OptionsColumn.ReadOnly = !Lock_Control;
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

        private bool KiemTra_NhapDuLieu()
        {
            bandedGridView_DanhMucCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_DanhMucCongViec.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_DanhMucCongViec.GetFocusedRowCellValue(DMCV_Chon)) &&
                        (
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_NhomCongViec))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_LoaiCongViec))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(QLDV_Ma))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_TenCongViec))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_DacTinh ))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_DiaDiem )))
                        )
                    )
                {
                    return false;
                }
                bandedGridView_DanhMucCongViec.MoveNext();
            }
            return true;
        }

        private bool KiemTra()
        {
            bandedGridView_DanhMucCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_DanhMucCongViec.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_DanhMucCongViec.GetFocusedRowCellValue(DMCV_Chon)))
                {
                    return true;
                }
                bandedGridView_DanhMucCongViec.MoveNext();
            }
            return false;
        }

        private void TraVe_DongDLChon()
        {
            bandedGridView_DanhMucCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_DanhMucCongViec.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_DanhMucCongViec.GetFocusedRowCellValue(DMCV_Chon)))
                {
                    //Trả con trỏ về vị trí được chọn
                    break;
                }
                bandedGridView_DanhMucCongViec.MoveNext();
            }
        }

        private void LoadDataCombobox()
        {
            repositoryItemComboBox_LoaiCongViec.Items.Clear();
            SqlDataReader dr_01 = LoadHamDungChung.PC_CBB_DMCV_LoaiCongViec_Load();
            while (dr_01.Read())
            {
                repositoryItemComboBox_LoaiCongViec.Items.Add(Convert.ToString(dr_01["DMCV_LoaiCongViec"]));
            }
            dr_01.Dispose();
            dr_01.Close();

        }

        private void frmPCCV_DanhMucCongViec_Load(object sender, EventArgs e)
        {

            repositoryItemLookUpEdit_DonVi.DataSource = cls_QuanLuNhanSuBLL.TS_QuanLyNhanSu_DonVi_Load();
            repositoryItemLookUpEdit_DonVi.DisplayMember = "QLDV_TenDonVi";
            repositoryItemLookUpEdit_DonVi.ValueMember = "QLDV_Ma";

            repositoryItemLookUpEdit_DonVi.PopupWidth = 500;
            repositoryItemLookUpEdit_DonVi.ShowFooter = false;
            repositoryItemLookUpEdit_DonVi.Columns.Clear();
            repositoryItemLookUpEdit_DonVi.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLDV_Ma", "Mã đơn vị", 100));
            repositoryItemLookUpEdit_DonVi.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLDV_MaDonVi", "Mã đơn vị", 100));
            repositoryItemLookUpEdit_DonVi.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLDV_TenDonVi", "TenDonVi", 200));
            repositoryItemLookUpEdit_DonVi.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLDV_MoTa", "Mô tả", 200));

            LoadDataCombobox();
            gridControl_DanhMucCongViec.DataSource = cls.PC_DanhMucCongViec_Load();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPCCV_DanhMucCongViec_Load(sender, e);
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            PC_DMCV_Add = true;
            PC_DMCV_Edit = false;

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

            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_Chon))))
            {
                MessageBox.Show("Bạn phải lựa chọn lại dữ liệu trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {
                PC_DMCV_Add = false;
                PC_DMCV_Edit = true;

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
                bandedGridView_DanhMucCongViec.MoveFirst();
                for (int i = 0; i < bandedGridView_DanhMucCongViec.RowCount; i++)
                {
                    if (Convert.ToBoolean(bandedGridView_DanhMucCongViec.GetFocusedRowCellValue(DMCV_Chon))) // == true
                    {
                        if (!string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_Chon))))
                        {
                            Lock_Unlock_Control(false); //Mở khóa lưu dữ liệu

                            Public.DMCV_Ma = Convert.ToInt32(bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_Ma));

                            int kq = cls.PC_DanhMucCongViec_Xoa(Public);
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
                    bandedGridView_DanhMucCongViec.MoveNext();
                }

                //Chạy lại phần tìm kiếm
                frmPCCV_DanhMucCongViec_Load(sender, e);

            }

        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            PC_DMCV_Add = false;
            PC_DMCV_Edit = false;

            Unlock_Control(true); //Mở khóa toàn bộ

            Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
            Lock_Unlock_Control(true); //Mở khóa toàn bộ
        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Public.HT_UserCreate = BienToanCuc.HT_USER_ID;
                //Public.PCP_DateCreate =
                Public.HT_UserEditor = BienToanCuc.HT_USER_ID;
                //Public.PCP_DateEditor =

                Public.DMCV_HienThi = true;
                Public.DMCV_SuDung = BienToanCuc.HT_PB_Ten;

                if (PC_DMCV_Add == true || PC_DMCV_Edit == true)
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

                    bandedGridView_DanhMucCongViec.MoveFirst();
                    for (int i = 0; i < bandedGridView_DanhMucCongViec.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_DanhMucCongViec.GetFocusedRowCellValue(DMCV_Chon))) // == true
                        {
                            Public.DMCV_Ma=int.Parse("0" + bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_Ma));
                            Public.DMCV_NhomCongViec=bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_NhomCongViec);
                            Public.DMCV_LoaiCongViec=bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_LoaiCongViec);
                            Public.QLDV_Ma = int.Parse("0" + bandedGridView_DanhMucCongViec.GetFocusedRowCellValue(QLDV_Ma));
                            Public.DMCV_TenCongViec=bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_TenCongViec);
                            Public.DMCV_DacTinh=bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_DacTinh);
                            Public.DMCV_DiaDiem=bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_DiaDiem);
                            Public.DMCV_ThoiGianBatDau=Convert.ToDateTime(bandedGridView_DanhMucCongViec.GetFocusedRowCellValue(DMCV_ThoiGianBatDau));
                            Public.DMCV_ThoiGianHoanThanh=bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_ThoiGianHoanThanh);
                            Public.DMCV_MoTa=bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_MoTa);
                            Public.DMCV_MucDoKho = int.Parse("0"+bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_MucDoKho));
                            Public.DMCV_GhiChu=bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_GhiChu);

                            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_TenFileDinhKem))) &&
                                string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_DataFileDinhKem)))
                                )
                            {
                                Public.DMCV_TenFileDinhKem = null;
                                Public.DMCV_DataFileDinhKem = null;
                            }
                            else
                            {
                                Public.DMCV_TenFileDinhKem = bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_TenFileDinhKem);
                                Public.DMCV_DataFileDinhKem = ReadFile(bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_DataFileDinhKem));
                            }


                            if (PC_DMCV_Add == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.PC_DanhMucCongViec_Them(Public);
                            }

                            if (PC_DMCV_Edit == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.PC_DanhMucCongViec_Sua(Public);
                            }
                        }
                        bandedGridView_DanhMucCongViec.MoveNext();
                    }
                }

                TraVe_DongDLChon();

                //Unlock_Control(true); //Mở khóa toàn bộ
                frmPCCV_DanhMucCongViec_Load(sender, e);
                Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
                Lock_Unlock_Control(true); //Mở khóa toàn bộ

                PC_DMCV_Add = false;
                PC_DMCV_Edit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadHamDungChung.PreviewPrintableComponent(gridControl_DanhMucCongViec, gridControl_DanhMucCongViec.LookAndFeel);
        }

        private void btnDownloadFileDinhKem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //Start - Download
                Public.DMCV_Ma = int.Parse("0" + bandedGridView_DanhMucCongViec.GetFocusedRowCellDisplayText(DMCV_Ma));

                SqlDataReader dr = cls.PC_DanhMucCongViec_Load_R_Para_File(Public);
                dr.Read();

                string TenFile = "";
                saveFileDialog1.FileName = Convert.ToString(dr["DMCV_TenFileDinhKem"].ToString());

                DialogResult DR = saveFileDialog1.ShowDialog();
                if (DR == DialogResult.OK)
                {
                    TenFile = saveFileDialog1.FileName;
                    //Get File data from dataset row.
                    byte[] FileDinhKem = (byte[])dr["DMCV_DataFileDinhKem"];

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
                MessageBox.Show("Không tồn tại file NỘI DUNG ĐÍNH KÈM! (ID file: " + Public.DMCV_Ma + ")", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void repositoryItemButtonEdit_FileDinhKem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgRes = dlg.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {
                //Provide file path in txtVBM_DataFileUpload text box.
                //txtVBM_DataFileUpload.Text = dlg.FileName;
                bandedGridView_DanhMucCongViec.SetFocusedRowCellValue(DMCV_DataFileDinhKem, dlg.FileName);

                //FileInfo Ten_File = new FileInfo(txtVBM_DataFileUpload.Text);
                FileInfo Ten_File = new FileInfo(dlg.FileName);

                //txtVBM_FileNameUpload.Text = Ten_File.Name;
                bandedGridView_DanhMucCongViec.SetFocusedRowCellValue(DMCV_TenFileDinhKem, Ten_File.Name);
            }
        }

        #region Cho phép thực hiện thao tác CLICK phải chuột

        void Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_DanhMucCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_DanhMucCongViec.RowCount; i++)
            {
                bandedGridView_DanhMucCongViec.SetFocusedRowCellValue(DMCV_Chon, true);
                bandedGridView_DanhMucCongViec.MoveNext();
            }
            bandedGridView_DanhMucCongViec.MoveFirst();
        }

        void No_Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_DanhMucCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_DanhMucCongViec.RowCount; i++)
            {
                bandedGridView_DanhMucCongViec.SetFocusedRowCellValue(DMCV_Chon, false);
                bandedGridView_DanhMucCongViec.MoveNext();
            }
            bandedGridView_DanhMucCongViec.MoveFirst();
        }

        private void bandedGridView_DanhMucCongViec_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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