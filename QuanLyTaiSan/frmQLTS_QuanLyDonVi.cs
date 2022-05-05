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
    public partial class frmQLTS_QuanLyDonVi : DevExpress.XtraEditors.XtraForm
    {
        public frmQLTS_QuanLyDonVi()
        {
            InitializeComponent();
            Lock_Unlock_Control_Input(false);
            new MultiSelectionEditingHelper(bandedGridView_QuanLyDonVi);
        }

        QuanLyDonViBLL cls = new QuanLyDonViBLL();
        QuanLyDonViPublic Public = new QuanLyDonViPublic();
        Boolean TS_QLDV_Add = false;
        Boolean TS_QLDV_Edit = false;
        HT_PQ_USERBLL cls_HT_PQ_USER = new HT_PQ_USERBLL();
        HT_PQ_USERPublic Public_HT_PQ_USER = new HT_PQ_USERPublic();


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
            this.QLDV_Ma.OptionsColumn.ReadOnly = true;
            this.QLDV_MaDonVi.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLDV_TenDonVi.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLDV_MoTa.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLDV_GhiChu.OptionsColumn.ReadOnly = !Lock_Control;
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
            bandedGridView_QuanLyDonVi.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyDonVi.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_QuanLyDonVi.GetFocusedRowCellValue(QLDV_Chon)) &&
                        (
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyDonVi.GetFocusedRowCellDisplayText(QLDV_MaDonVi))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyDonVi.GetFocusedRowCellDisplayText(QLDV_TenDonVi)))
                        )
                    )
                {
                    return false;
                }
                bandedGridView_QuanLyDonVi.MoveNext();
            }
            return true;
        }

        private bool KiemTra()
        {
            bandedGridView_QuanLyDonVi.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyDonVi.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_QuanLyDonVi.GetFocusedRowCellValue(QLDV_Chon)))
                {
                    return true;
                }
                bandedGridView_QuanLyDonVi.MoveNext();
            }
            return false;
        }

        private void TraVe_DongDLChon()
        {
            bandedGridView_QuanLyDonVi.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyDonVi.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_QuanLyDonVi.GetFocusedRowCellValue(QLDV_Chon)))
                {
                    //Trả con trỏ về vị trí được chọn
                    break;
                }
                bandedGridView_QuanLyDonVi.MoveNext();
            }
        }

        private void frmQLTS_QuanLyDonVi_Load(object sender, EventArgs e)
        {
            gridControl_QuanLyDonVi.DataSource = cls.TS_QuanLyDonVi_Load();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQLTS_QuanLyDonVi_Load(sender, e);
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            TS_QLDV_Add = true;
            TS_QLDV_Edit = false;

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

            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyDonVi.GetFocusedRowCellDisplayText(QLDV_Chon))))
            {
                MessageBox.Show("Bạn phải lựa chọn lại dữ liệu trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {
                TS_QLDV_Add = false;
                TS_QLDV_Edit = true;

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
                bandedGridView_QuanLyDonVi.MoveFirst();
                for (int i = 0; i < bandedGridView_QuanLyDonVi.RowCount; i++)
                {
                    if (Convert.ToBoolean(bandedGridView_QuanLyDonVi.GetFocusedRowCellValue(QLDV_Chon))) // == true
                    {
                        if (!string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_QuanLyDonVi.GetFocusedRowCellDisplayText(QLDV_Chon))))
                        {
                            Lock_Unlock_Control(false); //Mở khóa lưu dữ liệu

                            Public.QLDV_Ma = Convert.ToInt32(bandedGridView_QuanLyDonVi.GetFocusedRowCellDisplayText(QLDV_Ma));

                            int kq = cls.TS_QuanLyDonVi_Xoa(Public);
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
                    bandedGridView_QuanLyDonVi.MoveNext();
                }

                //Chạy lại phần tìm kiếm
                frmQLTS_QuanLyDonVi_Load(sender, e);
            }

        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Public.HT_UserCreate = BienToanCuc.HT_USER_ID;
                //Public.QLDV_DateCreate =
                Public.HT_UserEditor = BienToanCuc.HT_USER_ID;
                //Public.QLDV_DateEditor =

                Public.QLDV_HienThi = true;
                Public.QLDV_SuDung = BienToanCuc.HT_PB_Ten;

                if (TS_QLDV_Add == true || TS_QLDV_Edit == true)
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

                    bandedGridView_QuanLyDonVi.MoveFirst();
                    for (int i = 0; i < bandedGridView_QuanLyDonVi.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_QuanLyDonVi.GetFocusedRowCellValue(QLDV_Chon))) // == true
                        {
                            Public.QLDV_Ma=int.Parse("0" + bandedGridView_QuanLyDonVi.GetFocusedRowCellValue(QLDV_Ma));
                            Public.QLDV_MaDonVi=bandedGridView_QuanLyDonVi.GetFocusedRowCellDisplayText(QLDV_MaDonVi);
                            Public.QLDV_TenDonVi= bandedGridView_QuanLyDonVi.GetFocusedRowCellDisplayText(QLDV_TenDonVi);
                            Public.QLDV_MoTa = bandedGridView_QuanLyDonVi.GetFocusedRowCellDisplayText(QLDV_MoTa );
                            Public.QLDV_GhiChu = bandedGridView_QuanLyDonVi.GetFocusedRowCellDisplayText(QLDV_GhiChu);

                            if (TS_QLDV_Add == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.TS_QuanLyDonVi_Them(Public);
                            }

                            if (TS_QLDV_Edit == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.TS_QuanLyDonVi_Sua(Public);
                            }
                        }
                        bandedGridView_QuanLyDonVi.MoveNext();
                    }
                }

                TraVe_DongDLChon();

                //Unlock_Control(true); //Mở khóa toàn bộ
                frmQLTS_QuanLyDonVi_Load(sender, e);
                Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
                Lock_Unlock_Control(true); //Mở khóa toàn bộ

                TS_QLDV_Add = false;
                TS_QLDV_Edit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            TS_QLDV_Add = false;
            TS_QLDV_Edit = false;

            Unlock_Control(true); //Mở khóa toàn bộ

            Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
            Lock_Unlock_Control(true); //Mở khóa toàn bộ
        }

        private void btnIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadHamDungChung.PreviewPrintableComponent(gridControl_QuanLyDonVi, gridControl_QuanLyDonVi.LookAndFeel);
        }

        #region Cho phép thực hiện thao tác CLICK phải chuột

        void Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_QuanLyDonVi.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyDonVi.RowCount; i++)
            {
                bandedGridView_QuanLyDonVi.SetFocusedRowCellValue(QLDV_Chon, true);
                bandedGridView_QuanLyDonVi.MoveNext();
            }
            bandedGridView_QuanLyDonVi.MoveFirst();
        }

        void No_Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_QuanLyDonVi.MoveFirst();
            for (int i = 0; i < bandedGridView_QuanLyDonVi.RowCount; i++)
            {
                bandedGridView_QuanLyDonVi.SetFocusedRowCellValue(QLDV_Chon, false);
                bandedGridView_QuanLyDonVi.MoveNext();
            }
            bandedGridView_QuanLyDonVi.MoveFirst();
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