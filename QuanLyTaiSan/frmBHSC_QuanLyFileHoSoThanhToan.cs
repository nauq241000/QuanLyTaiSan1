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
using System.IO;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;

namespace QuanLyTaiSan
{
    public partial class frmBHSC_QuanLyFileHoSoThanhToan : DevExpress.XtraEditors.XtraForm
    {
        public frmBHSC_QuanLyFileHoSoThanhToan()
        {
            InitializeComponent();
            Lock_Unlock_Control_Input(false);
            new MultiSelectionEditingHelper(bandedGridView_QuanLyFileHoSoThanhToan);
        }

        QuanLyFileHoSoThanhToanBLL cls = new QuanLyFileHoSoThanhToanBLL();
        QuanLyFileHoSoThanhToanPublic Public = new QuanLyFileHoSoThanhToanPublic();

        HT_PQ_USERBLL cls_HT_PQ_USER = new HT_PQ_USERBLL();
        HT_PQ_USERPublic Public_HT_PQ_USER = new HT_PQ_USERPublic();

        Boolean QL_QLFHSTT_Add = false;
        Boolean QL_QLFHSTT_Edit = false;


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
            this.QLFHSTT_Ma.OptionsColumn.ReadOnly = true;
            this.QLFHSTT_SoHoSo.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLFHSTT_NgayHoSo.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLFHSTT_TenFile.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLFHSTT_DataFile.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLFHSTT_GhiChu.OptionsColumn.ReadOnly = !Lock_Control;
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
            bandedGridView_QuanLyFileHoSoThanhToan.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyFileHoSoThanhToan.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellValue(QLFHSTT_Chon)) &&
                        
                        (
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellDisplayText(QLFHSTT_SoHoSo))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellDisplayText(QLFHSTT_NgayHoSo ))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellDisplayText(QLFHSTT_TenFile)))
                        )
                    )
                {
                    return false;
                }
                bandedGridView_QuanLyFileHoSoThanhToan.MoveNext();
            }
            return true;
        }

        private bool KiemTra()
        {
            bandedGridView_QuanLyFileHoSoThanhToan.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyFileHoSoThanhToan.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellValue(QLFHSTT_Chon)))
                {
                    return true;
                }
                bandedGridView_QuanLyFileHoSoThanhToan.MoveNext();
            }
            return false;
        }

        private void TraVe_DongDLChon()
        {
            bandedGridView_QuanLyFileHoSoThanhToan.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyFileHoSoThanhToan.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellValue(QLFHSTT_Chon)))
                {
                    //Trả con trỏ về vị trí được chọn
                    break;
                }
                bandedGridView_QuanLyFileHoSoThanhToan.MoveNext();
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

        private void frmBHSC_QuanLyFileHoSoThanhToan_Load(object sender, EventArgs e)
        {
            gridControl_QuanLyFileHoSoThanhToan.DataSource = cls.QL_QuanLyFileHoSoThanhToan_Load();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBHSC_QuanLyFileHoSoThanhToan_Load(sender, e);
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            QL_QLFHSTT_Add = true;
            QL_QLFHSTT_Edit = false;

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

            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellDisplayText(QLFHSTT_Chon))))
            {
                MessageBox.Show("Bạn phải lựa chọn lại dữ liệu trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {
                QL_QLFHSTT_Add = false;
                QL_QLFHSTT_Edit = true;

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
                bandedGridView_QuanLyFileHoSoThanhToan.MoveFirst();
                for (int i = 0; i < bandedGridView_QuanLyFileHoSoThanhToan.RowCount; i++)
                {
                    if (Convert.ToBoolean(bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellValue(QLFHSTT_Chon))) // == true
                    {
                        if (!string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellDisplayText(QLFHSTT_Chon))))
                        {
                            Lock_Unlock_Control(false); //Mở khóa lưu dữ liệu

                            Public.QLFHSTT_Ma = Convert.ToInt32(bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellDisplayText(QLFHSTT_Ma));

                            int kq = cls.QL_QuanLyFileHoSoThanhToan_Xoa(Public);
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
                    bandedGridView_QuanLyFileHoSoThanhToan.MoveNext();
                }

                //Chạy lại phần tìm kiếm
                frmBHSC_QuanLyFileHoSoThanhToan_Load(sender, e);
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

                Public.QLFHSTT_HienThi = true;
                Public.QLFHSTT_SuDung = BienToanCuc.HT_PB_Ten;

                if (QL_QLFHSTT_Add == true || QL_QLFHSTT_Edit == true)
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

                    bandedGridView_QuanLyFileHoSoThanhToan.MoveFirst();
                    for (int i = 0; i < bandedGridView_QuanLyFileHoSoThanhToan.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellValue(QLFHSTT_Chon))) // == true
                        {


                            Public.QLFHSTT_Ma = int.Parse("0" + bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellDisplayText(QLFHSTT_Ma));
                            Public.QLFHSTT_SoHoSo = bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellDisplayText(QLFHSTT_SoHoSo);
                            Public.QLFHSTT_NgayHoSo = Convert.ToDateTime(bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellDisplayText(QLFHSTT_NgayHoSo));



                            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellDisplayText(QLFHSTT_TenFile))) &&
                                string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellDisplayText(QLFHSTT_DataFile)))
                                )
                            {
                                Public.QLFHSTT_TenFile = null;
                                Public.QLFHSTT_DataFile = null;

                            }
                            else
                            {
                                Public.QLFHSTT_TenFile = bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellDisplayText(QLFHSTT_TenFile);
                                Public.QLFHSTT_DataFile = ReadFile(bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellDisplayText(QLFHSTT_DataFile));
                            }



                            Public.QLFHSTT_GhiChu = bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellDisplayText(QLFHSTT_GhiChu);

                            if (QL_QLFHSTT_Add == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.QL_QuanLyFileHoSoThanhToan_Them(Public);
                            }

                            if (QL_QLFHSTT_Edit == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.QL_QuanLyFileHoSoThanhToan_Sua(Public);
                            }
                        }
                        bandedGridView_QuanLyFileHoSoThanhToan.MoveNext();
                    }
                }

                TraVe_DongDLChon();

                //Unlock_Control(true); //Mở khóa toàn bộ
                frmBHSC_QuanLyFileHoSoThanhToan_Load(sender, e);
                Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
                Lock_Unlock_Control(true); //Mở khóa toàn bộ

                QL_QLFHSTT_Add = false;
                QL_QLFHSTT_Edit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            QL_QLFHSTT_Add = false;
            QL_QLFHSTT_Edit = false;

            Unlock_Control(true); //Mở khóa toàn bộ

            Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
            Lock_Unlock_Control(true); //Mở khóa toàn bộ
        }

        private void btnDown_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //Start - Download
                Public.QLFHSTT_Ma = int.Parse("0" + bandedGridView_QuanLyFileHoSoThanhToan.GetFocusedRowCellDisplayText(QLFHSTT_Ma));

                SqlDataReader dr = cls.TS_QuanLyFileHoSoThanhToan_Load_R_Para_File(Public);
                dr.Read();

                string TenFile = "";
                saveFileDialog1.FileName = Convert.ToString(dr["QLFHSTT_TenFile"].ToString());

                DialogResult DR = saveFileDialog1.ShowDialog();
                if (DR == DialogResult.OK)
                {
                    TenFile = saveFileDialog1.FileName;
                    //Get File data from dataset row.
                    byte[] FileDinhKem = (byte[])dr["QLFHSTT_DataFile"];

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
                MessageBox.Show("Không tồn tại file NỘI DUNG ĐÍNH KÈM! (ID file: " + Public.QLFHSTT_Ma + ")", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                bandedGridView_QuanLyFileHoSoThanhToan.SetFocusedRowCellValue(QLFHSTT_DataFile, dlg.FileName);

                //FileInfo Ten_File = new FileInfo(txtVBM_DataFileUpload.Text);
                FileInfo Ten_File = new FileInfo(dlg.FileName);

                //txtVBM_FileNameUpload.Text = Ten_File.Name;
                bandedGridView_QuanLyFileHoSoThanhToan.SetFocusedRowCellValue(QLFHSTT_TenFile, Ten_File.Name);
            }
        }

        #region Cho phép thực hiện thao tác CLICK phải chuột

        void Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_QuanLyFileHoSoThanhToan.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyFileHoSoThanhToan.RowCount; i++)
            {
                bandedGridView_QuanLyFileHoSoThanhToan.SetFocusedRowCellValue(QLFHSTT_Chon, true);
                bandedGridView_QuanLyFileHoSoThanhToan.MoveNext();
            }
            bandedGridView_QuanLyFileHoSoThanhToan.MoveFirst();
        }

        void No_Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_QuanLyFileHoSoThanhToan.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyFileHoSoThanhToan.RowCount; i++)
            {
                bandedGridView_QuanLyFileHoSoThanhToan.SetFocusedRowCellValue(QLFHSTT_Chon, false);
                bandedGridView_QuanLyFileHoSoThanhToan.MoveNext();
            }
            bandedGridView_QuanLyFileHoSoThanhToan.MoveFirst();
        }

        private void bandedGridView_QuanLyFileHoSoThanhToan_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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