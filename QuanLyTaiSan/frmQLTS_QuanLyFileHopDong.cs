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
    public partial class frmQLTS_QuanLyFileHopDong : DevExpress.XtraEditors.XtraForm
    {
        QuanLyFileHopDongBLL cls = new QuanLyFileHopDongBLL();
        QuanLyFileHopDongPublic Public = new QuanLyFileHopDongPublic();

        HT_PQ_USERBLL cls_HT_PQ_USER = new HT_PQ_USERBLL();
        HT_PQ_USERPublic Public_HT_PQ_USER = new HT_PQ_USERPublic();

        Boolean QL_QLFHD_Add = false;
        Boolean QL_QLFHD_Edit = false;

        public frmQLTS_QuanLyFileHopDong()
        {
            InitializeComponent();
            Lock_Unlock_Control_Input(false);
            new MultiSelectionEditingHelper(bandedGridView_QuanLyFileHopDong);
        }

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
       

        private void frmQuanLyFileHopDong_Load(object sender, EventArgs e)
        {
            gridControl_QuanLyFileHopDong.DataSource = cls.QL_QuanLyFileHopDong_Load();
        }

        private void Lock_Unlock_Control_Input(bool Lock_Control)
        {
            this.QLFHD_Ma.OptionsColumn.ReadOnly = true;
            this.QLFHD_SoHopDong.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLFHD_NgayHopDong.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLFHD_TenFileHopDong.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLFHD_DataFileHopDong.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLFHD_GhiChu.OptionsColumn.ReadOnly = !Lock_Control;
            

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
            bandedGridView_QuanLyFileHopDong.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyFileHopDong.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_QuanLyFileHopDong.GetFocusedRowCellValue(QLFHD_Chon)) &&
                        
                        (
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyFileHopDong.GetFocusedRowCellDisplayText(QLFHD_SoHopDong))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyFileHopDong.GetFocusedRowCellDisplayText(QLFHD_NgayHopDong ))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyFileHopDong.GetFocusedRowCellDisplayText(QLFHD_TenFileHopDong)))
                        )
                    )
                {
                    return false;
                }
                bandedGridView_QuanLyFileHopDong.MoveNext();
            }
            return true;
        }

    private bool KiemTra()
    {
        bandedGridView_QuanLyFileHopDong.MoveFirst();
        for (int i = 0; i < bandedGridView_QuanLyFileHopDong.RowCount; i++)
        {
            if (Convert.ToBoolean(bandedGridView_QuanLyFileHopDong.GetFocusedRowCellValue(QLFHD_Chon)))
            {
                return true;
            }
            bandedGridView_QuanLyFileHopDong.MoveNext();
        }
        return false;
    }

        private void TraVe_DongDLChon()
        {
            bandedGridView_QuanLyFileHopDong.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyFileHopDong.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_QuanLyFileHopDong.GetFocusedRowCellValue(QLFHD_Chon)))
                {
                    //Trả con trỏ về vị trí được chọn
                    break;
                }
                bandedGridView_QuanLyFileHopDong.MoveNext();
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
                            
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuanLyFileHopDong_Load(sender, e);

        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            QL_QLFHD_Add = true;
            QL_QLFHD_Edit = false;

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

            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyFileHopDong.GetFocusedRowCellDisplayText(QLFHD_Chon))))
            {
                MessageBox.Show("Bạn phải lựa chọn lại dữ liệu trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {
                QL_QLFHD_Add = false;
                QL_QLFHD_Edit = true;

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
                bandedGridView_QuanLyFileHopDong.MoveFirst();
                for (int i = 0; i < bandedGridView_QuanLyFileHopDong.RowCount; i++)
                {
                    if (Convert.ToBoolean(bandedGridView_QuanLyFileHopDong.GetFocusedRowCellValue(QLFHD_Chon))) // == true
                    {
                        if (!string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyFileHopDong.GetFocusedRowCellDisplayText(QLFHD_Chon))))
                        {
                            Lock_Unlock_Control(false); //Mở khóa lưu dữ liệu

                            Public.QLFHD_Ma = Convert.ToInt32(bandedGridView_QuanLyFileHopDong.GetFocusedRowCellDisplayText(QLFHD_Ma));

                            int kq = cls.QL_QuanLyFileHopDong_Xoa(Public);
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
                    bandedGridView_QuanLyFileHopDong.MoveNext();
                }

                //Chạy lại phần tìm kiếm
                frmQuanLyFileHopDong_Load(sender, e);
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

                Public.QLFHD_HienThi = true;
                Public.QLFHD_SuDung = BienToanCuc.HT_PB_Ten;

                if (QL_QLFHD_Add == true || QL_QLFHD_Edit == true)
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

                    bandedGridView_QuanLyFileHopDong.MoveFirst();
                    for (int i = 0; i < bandedGridView_QuanLyFileHopDong.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_QuanLyFileHopDong.GetFocusedRowCellValue(QLFHD_Chon))) // == true
                        {


                            Public.QLFHD_Ma =int.Parse("0" + bandedGridView_QuanLyFileHopDong.GetFocusedRowCellDisplayText(QLFHD_Ma ));
                            Public.QLFHD_SoHopDong = bandedGridView_QuanLyFileHopDong.GetFocusedRowCellDisplayText(QLFHD_SoHopDong);
                            Public.QLFHD_NgayHopDong = Convert.ToDateTime(bandedGridView_QuanLyFileHopDong.GetFocusedRowCellDisplayText(QLFHD_NgayHopDong));



                            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyFileHopDong.GetFocusedRowCellDisplayText(QLFHD_TenFileHopDong))) &&
                                string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyFileHopDong.GetFocusedRowCellDisplayText(QLFHD_DataFileHopDong)))
                                )
                            {
                                Public.QLFHD_TenFileHopDong = null;
                                Public.QLFHD_DataFileHopDong = null;

                            }
                            else
                            {
                                Public.QLFHD_TenFileHopDong = bandedGridView_QuanLyFileHopDong.GetFocusedRowCellDisplayText(QLFHD_TenFileHopDong);
                                Public.QLFHD_DataFileHopDong = ReadFile(bandedGridView_QuanLyFileHopDong.GetFocusedRowCellDisplayText(QLFHD_DataFileHopDong));
                            }

                       

                        Public.QLFHD_GhiChu =bandedGridView_QuanLyFileHopDong.GetFocusedRowCellDisplayText(QLFHD_GhiChu);

                            if (QL_QLFHD_Add == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.QL_QuanLyFileHopDong_Them(Public);
                            }

                            if (QL_QLFHD_Edit == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.QL_QuanLyFileHopDong_Sua(Public);
                            }
                        }
                        bandedGridView_QuanLyFileHopDong.MoveNext();
                    }
                }

                TraVe_DongDLChon();

                //Unlock_Control(true); //Mở khóa toàn bộ
                frmQuanLyFileHopDong_Load(sender, e);
                Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
                Lock_Unlock_Control(true); //Mở khóa toàn bộ

                QL_QLFHD_Add = false;
                QL_QLFHD_Edit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            QL_QLFHD_Add = false;
            QL_QLFHD_Edit = false;

            Unlock_Control(true); //Mở khóa toàn bộ

            Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
            Lock_Unlock_Control(true); //Mở khóa toàn bộ
        }

        private void btnDown_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //Start - Download
                Public.QLFHD_Ma = int.Parse("0" + bandedGridView_QuanLyFileHopDong.GetFocusedRowCellDisplayText(QLFHD_Ma));

                SqlDataReader dr = cls.TS_QuanLyFileHopDong_Load_R_Para_File(Public);
                dr.Read();

                string TenFile = "";
                saveFileDialog1.FileName = Convert.ToString(dr["QLFHD_TenFileHopDong"].ToString());

                DialogResult DR = saveFileDialog1.ShowDialog();
                if (DR == DialogResult.OK)
                {
                    TenFile = saveFileDialog1.FileName;
                    //Get File data from dataset row.
                    byte[] FileDinhKem = (byte[])dr["QLFHD_DataFileHopDong"];

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
                MessageBox.Show("Không tồn tại file NỘI DUNG ĐÍNH KÈM! (ID file: " + Public.QLFHD_Ma + ")", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_Tenfile_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgRes = dlg.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {
                //Provide file path in txtVBM_DataFileUpload text box.
                //txtVBM_DataFileUpload.Text = dlg.FileName;
                bandedGridView_QuanLyFileHopDong.SetFocusedRowCellValue(QLFHD_DataFileHopDong, dlg.FileName);

                //FileInfo Ten_File = new FileInfo(txtVBM_DataFileUpload.Text);
                FileInfo Ten_File = new FileInfo(dlg.FileName);

                //txtVBM_FileNameUpload.Text = Ten_File.Name;
                bandedGridView_QuanLyFileHopDong.SetFocusedRowCellValue(QLFHD_TenFileHopDong, Ten_File.Name);
            }
        }


        #region Cho phép thực hiện thao tác CLICK phải chuột

        void Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_QuanLyFileHopDong.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyFileHopDong.RowCount; i++)
            {
                bandedGridView_QuanLyFileHopDong.SetFocusedRowCellValue(QLFHD_Chon, true);
                bandedGridView_QuanLyFileHopDong.MoveNext();
            }
            bandedGridView_QuanLyFileHopDong.MoveFirst();
        }

        void No_Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_QuanLyFileHopDong.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyFileHopDong.RowCount; i++)
            {
                bandedGridView_QuanLyFileHopDong.SetFocusedRowCellValue(QLFHD_Chon, false);
                bandedGridView_QuanLyFileHopDong.MoveNext();
            }
            bandedGridView_QuanLyFileHopDong.MoveFirst();
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