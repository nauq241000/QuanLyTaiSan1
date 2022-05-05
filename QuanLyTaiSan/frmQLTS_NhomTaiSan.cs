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
    public partial class frmQLTS_NhomTaiSan : DevExpress.XtraEditors.XtraForm
    {
        public frmQLTS_NhomTaiSan()
        {
            InitializeComponent();
            Lock_Unlock_Control_Input(false);
            new MultiSelectionEditingHelper(bandedGridView_NhomTaiSan);
        }

        NhomTaiSanBLL cls = new NhomTaiSanBLL();
        NhomTaiSanPublic Public = new NhomTaiSanPublic();
        Boolean TS_NTS_Add = false;
        Boolean TS_NTS_Edit = false;
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
            this.NTS_Ma.OptionsColumn.ReadOnly = true;
            this.NTS_Ten.OptionsColumn.ReadOnly = !Lock_Control;
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
            bandedGridView_NhomTaiSan.MoveFirst();
            for (int i = 0; i < bandedGridView_NhomTaiSan.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_NhomTaiSan.GetFocusedRowCellValue(NTS_Chon)) &&
                        (
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_NhomTaiSan.GetFocusedRowCellDisplayText(NTS_Ten)))
                        )
                    )
                {
                    return false;
                }
                bandedGridView_NhomTaiSan.MoveNext();
            }
            return true;
        }

        private bool KiemTra()
        {
            bandedGridView_NhomTaiSan.MoveFirst();
            for (int i = 0; i < bandedGridView_NhomTaiSan.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_NhomTaiSan.GetFocusedRowCellValue(NTS_Chon)))
                {
                    return true;
                }
                bandedGridView_NhomTaiSan.MoveNext();
            }
            return false;
        }

        private void TraVe_DongDLChon()
        {
            bandedGridView_NhomTaiSan.MoveFirst();
            for (int i = 0; i < bandedGridView_NhomTaiSan.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_NhomTaiSan.GetFocusedRowCellValue(NTS_Chon)))
                {
                    //Trả con trỏ về vị trí được chọn
                    break;
                }
                bandedGridView_NhomTaiSan.MoveNext();
            }
        }

        private void frmNhomTaiSan_Load(object sender, EventArgs e)
        {
            gridControl_NhomTaiSan.DataSource = cls.TS_NhomTaiSan_Load();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhomTaiSan_Load(sender, e);
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            TS_NTS_Add = true;
            TS_NTS_Edit = false;

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

            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_NhomTaiSan.GetFocusedRowCellDisplayText(NTS_Chon))))
            {
                MessageBox.Show("Bạn phải lựa chọn lại dữ liệu trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {
                TS_NTS_Add = false;
                TS_NTS_Edit = true;

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
                bandedGridView_NhomTaiSan.MoveFirst();
                for (int i = 0; i < bandedGridView_NhomTaiSan.RowCount; i++)
                {
                    if (Convert.ToBoolean(bandedGridView_NhomTaiSan.GetFocusedRowCellValue(NTS_Chon))) // == true
                    {
                        if (!string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_NhomTaiSan.GetFocusedRowCellDisplayText(NTS_Chon))))
                        {
                            Lock_Unlock_Control(false); //Mở khóa lưu dữ liệu

                            Public.NTS_Ma = Convert.ToInt32(bandedGridView_NhomTaiSan.GetFocusedRowCellDisplayText(NTS_Ma));

                            int kq = cls.TS_NhomTaiSan_Xoa(Public);
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
                    bandedGridView_NhomTaiSan.MoveNext();
                }

                //Chạy lại phần tìm kiếm
                frmNhomTaiSan_Load(sender, e);
            }

        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Public.HT_UserCreate = BienToanCuc.HT_USER_ID;
                //Public.NTS_DateCreate =
                Public.HT_UserEditor = BienToanCuc.HT_USER_ID;
                //Public.NTS_DateEditor =

                Public.NTS_HienThi = true;
                Public.NTS_SuDung = BienToanCuc.HT_PB_Ten;

                if (TS_NTS_Add == true || TS_NTS_Edit == true)
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

                    bandedGridView_NhomTaiSan.MoveFirst();
                    for (int i = 0; i < bandedGridView_NhomTaiSan.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_NhomTaiSan.GetFocusedRowCellValue(NTS_Chon))) // == true
                        {
                            Public.NTS_Ma = int.Parse("0" + bandedGridView_NhomTaiSan.GetFocusedRowCellDisplayText(NTS_Ma));
                            Public.NTS_Ten = bandedGridView_NhomTaiSan.GetFocusedRowCellDisplayText(NTS_Ten);

                            if (TS_NTS_Add == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.TS_NhomTaiSan_Them(Public);
                            }

                            if (TS_NTS_Edit == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.TS_NhomTaiSan_Sua(Public);
                            }
                        }
                        bandedGridView_NhomTaiSan.MoveNext();
                    }
                }

                TraVe_DongDLChon();

                //Unlock_Control(true); //Mở khóa toàn bộ
                frmNhomTaiSan_Load(sender, e);
                Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
                Lock_Unlock_Control(true); //Mở khóa toàn bộ

                TS_NTS_Add = false;
                TS_NTS_Edit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            TS_NTS_Add = false;
            TS_NTS_Edit = false;

            Unlock_Control(true); //Mở khóa toàn bộ

            Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
            Lock_Unlock_Control(true); //Mở khóa toàn bộ
        }

        private void btnIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadHamDungChung.PreviewPrintableComponent(gridControl_NhomTaiSan, gridControl_NhomTaiSan.LookAndFeel);
        }

        #region Cho phép thực hiện thao tác CLICK phải chuột

        void Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_NhomTaiSan.MoveFirst();
            for (int i = 0; i < bandedGridView_NhomTaiSan.RowCount; i++)
            {
                bandedGridView_NhomTaiSan.SetFocusedRowCellValue(NTS_Chon, true);
                bandedGridView_NhomTaiSan.MoveNext();
            }
            bandedGridView_NhomTaiSan.MoveFirst();
        }

        void No_Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_NhomTaiSan.MoveFirst();
            for (int i = 0; i < bandedGridView_NhomTaiSan.RowCount; i++)
            {
                bandedGridView_NhomTaiSan.SetFocusedRowCellValue(NTS_Chon, false);
                bandedGridView_NhomTaiSan.MoveNext();
            }
            bandedGridView_NhomTaiSan.MoveFirst();
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