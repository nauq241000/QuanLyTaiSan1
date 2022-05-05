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
using System.Data.SqlClient;
using DevExpress.XtraBars;
using System.IO;
using MessagingToolkit.QRCode.Codec;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using System.Drawing.Printing;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraPrinting.NativeBricks;

namespace QuanLyTaiSan
{
    public partial class frmQLTS_TaiSanHienCo : DevExpress.XtraEditors.XtraForm
    {
        public frmQLTS_TaiSanHienCo()
        {
            InitializeComponent();
            Lock_Unlock_Control_Input(false);
            new MultiSelectionEditingHelper(bandedGridView_TaiSanHienCo);
        }

        TaiSanHienCoBLL cls = new TaiSanHienCoBLL();
        TaiSanHienCoPublic Public = new TaiSanHienCoPublic();

        QuanLyPhongBLL cls_QuanLyPhongBLL = new QuanLyPhongBLL();
        QuanLyPhongPublic Public_QuanLyPhong = new QuanLyPhongPublic();

        TaiSanYeuCauBLL cls_TaiSanYeuCauBLL = new TaiSanYeuCauBLL();

        QuanLyNhanSuBLL cls_QuanLyNhanSuBLL = new QuanLyNhanSuBLL();
        QuanLyNhanSuPublic Public_QuanLyNhanSu = new QuanLyNhanSuPublic();

        QuanLyDonViBLL cls_QuanLyDonViBLL = new QuanLyDonViBLL();
        QuanLyDonViPublic Public_QuanLyDonVi = new QuanLyDonViPublic();

        HT_PQ_USERBLL cls_HT_PQ_USER = new HT_PQ_USERBLL();
        HT_PQ_USERPublic Public_HT_PQ_USER = new HT_PQ_USERPublic();

        Boolean TS_TSHC_Add = false;
        Boolean TS_TSHC_Edit = false;

        public void UnVisibleControls()
        {
            BarButtonItem[] items = new BarButtonItem[] { btnThemDong, btnSua, btnXoa, btnLuu };

            foreach (BarButtonItem item in items)
            {
                item.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        public void VisibleControls()
        {
            BarButtonItem[] items = new BarButtonItem[] { btnThemDong, btnSua, btnXoa, btnLuu };
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
                    btnThemDong.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
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
            this.TSHC_Ma.OptionsColumn.ReadOnly = true;
            this.NTS_Ma.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_MaNSQL.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_TenNSQL.OptionsColumn.ReadOnly = true;
            this.QLNS_TenNSSD.OptionsColumn.ReadOnly = true;
            this.QLNS_MaNSSD.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_Ma.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_LoaiTaiSan.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_TenTaiSan.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_BoPhanQuanLy.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_QR_Code.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_TinhTrang.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_MoTa.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_NguonGocTaiSan.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_ThuongHieu.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_NamSanXuat.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_NgayDuaVaoSuDung.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_SoHopDong.OptionsColumn.ReadOnly = true;
            this.QLFHD_Ma.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_NgayHopDong.OptionsColumn.ReadOnly = true;
            this.TSHC_XuatXu.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_SoSeri.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_KichThuocDai.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_KichThuocRong.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_KichThuocCao.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_ThoiGianBaoHanh.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_DataFileGiayToKemTheo.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_TenFileGiayToKemTheo.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_AnhChup.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_GhiChu.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_NgayBanGiao.OptionsColumn.ReadOnly = !Lock_Control;
        }


        private void Lock_Unlock_Control(Boolean Lock_Control) //Khóa và mở khóa điều khiển chức năng
        {
            btnRefresh.Enabled = Lock_Control;
            btnThemDong.Enabled = Lock_Control;
            btnSua.Enabled = Lock_Control;
            btnXoa.Enabled = Lock_Control;
            btnLuu.Enabled = !Lock_Control;
            btnUndo.Enabled = !Lock_Control;
        }

        private void Unlock_Control(Boolean Lock_Control) //Mở khóa điều khiển chức năng
        {
            btnRefresh.Enabled = Lock_Control;
            btnThemDong.Enabled = Lock_Control;
            btnSua.Enabled = Lock_Control;
            btnXoa.Enabled = Lock_Control;
            btnLuu.Enabled = Lock_Control;
            btnUndo.Enabled = Lock_Control;
        }


        private bool KiemTra_NhapDuLieu()
        {
            bandedGridView_TaiSanHienCo.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanHienCo.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(TSHC_Chon)) &&
                        (
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(NTS_Ma))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(QLNS_MaNSQL))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(QLP_Ma))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_LoaiTaiSan))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_TenTaiSan))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_BoPhanQuanLy))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_NguonGocTaiSan))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_ThoiGianBaoHanh))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_TinhTrang)))
                        )
                    )
                {
                    return false;
                }
                bandedGridView_TaiSanHienCo.MoveNext();
            }
            return true;
        }

        private bool KiemTra()
        {
            bandedGridView_TaiSanHienCo.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanHienCo.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(TSHC_Chon)))
                {
                    return true;
                }
                bandedGridView_TaiSanHienCo.MoveNext();
            }
            return false;
        }

        private void TraVe_DongDLChon()
        {
            bandedGridView_TaiSanHienCo.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanHienCo.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(TSHC_Chon)))
                {
                    //Trả con trỏ về vị trí được chọn
                    break;
                }
                bandedGridView_TaiSanHienCo.MoveNext();
            }
        }

        private void LoadDataCombobox()
        {
            repositoryItemComboBox_TSHC_BoPhanQuanLy.Items.Clear();
            SqlDataReader dr_01 = LoadHamDungChung.TS_CBB_TSHC_BoPhanQuanLy_Load();
            while (dr_01.Read())
            {
                repositoryItemComboBox_TSHC_BoPhanQuanLy.Items.Add(Convert.ToString(dr_01["TSHC_BoPhanQuanLy"]));
            }
            dr_01.Dispose();
            dr_01.Close();

            repositoryItemComboBox_TSHC_ThuongHieu.Items.Clear();
            SqlDataReader dr_02 = LoadHamDungChung.TS_CBB_TSHC_ThuongHieu_Load();
            while (dr_02.Read())
            {
                repositoryItemComboBox_TSHC_ThuongHieu.Items.Add(Convert.ToString(dr_02["TSHC_ThuongHieu"]));
            }
            dr_02.Dispose();
            dr_02.Close();

            repositoryItemComboBox_TSHC_XuatXu.Items.Clear();
            SqlDataReader dr_03 = LoadHamDungChung.TS_CBB_TSHC_XuatXu_Load();
            while (dr_03.Read())
            {
                repositoryItemComboBox_TSHC_XuatXu.Items.Add(Convert.ToString(dr_03["TSHC_XuatXu"]));
            }
            dr_03.Dispose();
            dr_03.Close();
        }

        private void frmQLTS_TaiSanHienCo_Load(object sender, EventArgs e)
        {
            repositoryItemLookUpEdit_NTS_Ma.DataSource = cls_TaiSanYeuCauBLL.TS_NhomTaiSan_Load();
            repositoryItemLookUpEdit_NTS_Ma.DisplayMember = "NTS_Ten";
            repositoryItemLookUpEdit_NTS_Ma.ValueMember = "NTS_Ma";

            repositoryItemLookUpEdit_NTS_Ma.PopupWidth = 300;
            repositoryItemLookUpEdit_NTS_Ma.ShowFooter = false;
            repositoryItemLookUpEdit_NTS_Ma.Columns.Clear();
            repositoryItemLookUpEdit_NTS_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NTS_Ma", "Mã", 100));
            repositoryItemLookUpEdit_NTS_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NTS_Ten", "Tên nhóm tài sản", 200));


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

            repositoryItemLookUpEdit_QLNS_Ten.DataSource = cls_QuanLyPhongBLL.TS_QuanLyPhong_NhanSu_Load();
            repositoryItemLookUpEdit_QLNS_Ten.DisplayMember = "QLNS_HoTen";
            repositoryItemLookUpEdit_QLNS_Ten.ValueMember = "QLNS_Ma";

            repositoryItemLookUpEdit_QLNS_Ten.PopupWidth = 1000;
            repositoryItemLookUpEdit_QLNS_Ten.ShowFooter = false;
            repositoryItemLookUpEdit_QLNS_Ten.Columns.Clear();
            repositoryItemLookUpEdit_QLNS_Ten.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_Ma", "Mã", 100));
            repositoryItemLookUpEdit_QLNS_Ten.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLDV_TenDonVi", "Tên đơn vị", 200));
            repositoryItemLookUpEdit_QLNS_Ten.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_CoSo", "Cơ sở", 100));
            repositoryItemLookUpEdit_QLNS_Ten.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_MaNhanSu", "Mã nhân sự", 100));
            repositoryItemLookUpEdit_QLNS_Ten.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_HoTen", "Họ tên", 200));
            repositoryItemLookUpEdit_QLNS_Ten.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_ChucVu", "Chức vụ", 100));
            repositoryItemLookUpEdit_QLNS_Ten.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_SoDienThoai", "Số điện thoại", 200));


            repositoryItemLookUpEdit_QLP_Ma.DataSource = cls.TS_TSHC_QuanLyPhong_Load();
            repositoryItemLookUpEdit_QLP_Ma.DisplayMember = "QLP_TenPhong";
            repositoryItemLookUpEdit_QLP_Ma.ValueMember = "QLP_Ma";

            repositoryItemLookUpEdit_QLP_Ma.PopupWidth = 1000;
            repositoryItemLookUpEdit_QLP_Ma.ShowFooter = false;
            repositoryItemLookUpEdit_QLP_Ma.Columns.Clear();
            repositoryItemLookUpEdit_QLP_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_Ma", "Mã", 100));
            repositoryItemLookUpEdit_QLP_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_LoaiPhong", "Loại phòng", 100));
            repositoryItemLookUpEdit_QLP_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_CoSo", "Cơ sở", 200));
            repositoryItemLookUpEdit_QLP_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_DiaDiem", "Địa điểm", 100));
            repositoryItemLookUpEdit_QLP_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_ToaNha", "Toà nhà", 200));
            repositoryItemLookUpEdit_QLP_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_MaPhong", "Mã phòng", 100));
            repositoryItemLookUpEdit_QLP_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_TenPhong", "Tên phòng", 200));

            repositoryItemLookUpEdit_TSHC_MaNhomThietBiDiKem.DataSource = cls.TS_TaiSanHienCo_Load();
            repositoryItemLookUpEdit_TSHC_MaNhomThietBiDiKem.DisplayMember = "TSHC_Ma";
            repositoryItemLookUpEdit_TSHC_MaNhomThietBiDiKem.ValueMember = "TSHC_Ma";

            repositoryItemLookUpEdit_TSHC_MaNhomThietBiDiKem.PopupWidth = 400;
            repositoryItemLookUpEdit_TSHC_MaNhomThietBiDiKem.ShowFooter = false;
            repositoryItemLookUpEdit_TSHC_MaNhomThietBiDiKem.Columns.Clear();
            repositoryItemLookUpEdit_TSHC_MaNhomThietBiDiKem.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TSHC_Ma", "Mã", 100));
            repositoryItemLookUpEdit_TSHC_MaNhomThietBiDiKem.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TSHC_TenTaiSan", "Tên tài sản", 100));
            repositoryItemLookUpEdit_TSHC_MaNhomThietBiDiKem.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TSHC_LoaiTaiSan", "Loại tài sản", 200));

            repositoryItemLookUpEdit_QLFHD_Ma.DataSource = cls.TS_TSHC_QuanLyFileHopDong_Load();
            repositoryItemLookUpEdit_QLFHD_Ma.DisplayMember = "QLFHD_Ma";
            repositoryItemLookUpEdit_QLFHD_Ma.ValueMember = "QLFHD_Ma";

            repositoryItemLookUpEdit_QLFHD_Ma.PopupWidth = 500;
            repositoryItemLookUpEdit_QLFHD_Ma.ShowFooter = false;
            repositoryItemLookUpEdit_QLFHD_Ma.Columns.Clear();
            repositoryItemLookUpEdit_QLFHD_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLFHD_Ma", "Mã", 100));
            repositoryItemLookUpEdit_QLFHD_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLFHD_SoHopDong", "Số hợp đồng", 100));
            repositoryItemLookUpEdit_QLFHD_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLFHD_NgayHopDong", "Ngày hợp đồng", 100));
            repositoryItemLookUpEdit_QLFHD_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLFHD_TenFileHopDong", "Tên File hợp đồng", 100));
            repositoryItemLookUpEdit_QLFHD_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLFHD_GhiChu", "Ghi chú", 200));

            repositoryItemLookUpEdit_SoHopDong.DataSource = cls.TS_TSHC_QuanLyFileHopDong_Load();
            repositoryItemLookUpEdit_SoHopDong.DisplayMember = "QLFHD_SoHopDong";
            repositoryItemLookUpEdit_SoHopDong.ValueMember = "QLFHD_Ma";

            repositoryItemLookUpEdit_NgayHopDong.DataSource = cls.TS_TSHC_QuanLyFileHopDong_Load();
            repositoryItemLookUpEdit_NgayHopDong.DisplayMember = "QLFHD_NgayHopDong";
            repositoryItemLookUpEdit_NgayHopDong.ValueMember = "QLFHD_Ma";


            DataTable dt = cls.TS_TaiSanHienCo_Load();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][8].ToString() == "")
                {
                    try
                    {
                        string URL = cls.TS_QRCode_Load().Rows[0][1] + "?ID=" + dt.Rows[i][1].ToString() + "";
                        QRCodeEncoder barcode = new QRCodeEncoder();
                        var image = new ImageConverter().ConvertTo(barcode.Encode(URL), typeof(Byte[]));

                        Public.TSHC_Ma = int.Parse("0" + dt.Rows[i][1].ToString());
                        Public.TSHC_QR_Code = (byte[])image;

                        cls.TS_TaiSanHienCo_AddQRCode(Public);
                    }
                    catch { }
                }
            }

            LoadDataCombobox();
            gridControl_TaiSanHienCo.DataSource = cls.TS_TaiSanHienCo_Load();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQLTS_TaiSanHienCo_Load(sender, e);
        }

        private void btnThemTSMS_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQLTS_TSHC_ChonTaiSanHienCo frm_ChonTaiSanMuaSam = new frmQLTS_TSHC_ChonTaiSanHienCo();
            frm_ChonTaiSanMuaSam.ShowDialog();
            frmQLTS_TaiSanHienCo_Load(sender, e);
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            TS_TSHC_Add = true;
            TS_TSHC_Edit = false;

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

            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_Chon))))
            {
                MessageBox.Show("Bạn phải lựa chọn lại dữ liệu trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {
                TS_TSHC_Add = false;
                TS_TSHC_Edit = true;

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
                bandedGridView_TaiSanHienCo.MoveFirst();
                for (int i = 0; i < bandedGridView_TaiSanHienCo.RowCount; i++)
                {
                    if (Convert.ToBoolean(bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(TSHC_Chon))) // == true
                    {
                        if (!string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_Chon))))
                        {
                            Lock_Unlock_Control(false); //Mở khóa lưu dữ liệu

                            Public.TSHC_Ma = Convert.ToInt32(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_Ma));

                            int kq = cls.TS_TaiSanHienCo_Xoa(Public);
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
                    bandedGridView_TaiSanHienCo.MoveNext();
                }

                //Chạy lại phần tìm kiếm
                frmQLTS_TaiSanHienCo_Load(sender, e);

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

                Public.TSHC_HienThi = true;
                Public.TSHC_SuDung = BienToanCuc.HT_PB_Ten;

                if (TS_TSHC_Add == true || TS_TSHC_Edit == true)
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

                    bandedGridView_TaiSanHienCo.MoveFirst();
                    for (int i = 0; i < bandedGridView_TaiSanHienCo.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(TSHC_Chon)))
                        {
                            Public.TSHC_Ma = int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_Ma));
                            Public.NTS_Ma=int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(NTS_Ma));
                            Public.QLNS_MaNSQL=int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(QLNS_MaNSQL));
                            Public.QLNS_MaNSSD = int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(QLNS_MaNSSD));
                            Public.QLP_Ma=int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(QLP_Ma));
                            Public.TSHC_LoaiTaiSan=bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_LoaiTaiSan);
                            Public.TSHC_TenTaiSan=bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_TenTaiSan);
                            Public.TSHC_MaNhomThietBiDiKem = bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_MaNhomThietBiDiKem);
                            Public.TSHC_BoPhanQuanLy=bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_BoPhanQuanLy);
                            if (bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(TSHC_QR_Code).GetType().ToString() == "System.DBNull")
                                Public.TSHC_QR_Code = null;
                            else
                                Public.TSHC_QR_Code = (byte[])bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(TSHC_QR_Code);
                            Public.TSHC_TinhTrang=bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_TinhTrang);
                            Public.TSHC_MoTa=bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_MoTa);
                            Public.TSHC_NguonGocTaiSan=bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_NguonGocTaiSan);
                            Public.TSHC_ThuongHieu=bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_ThuongHieu);
                            Public.TSHC_NamSanXuat=int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_NamSanXuat));
                            if (bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_NgayDuaVaoSuDung).ToString()=="")
                                Public.TSHC_NgayDuaVaoSuDung=null;
                            else
                                Public.TSHC_NgayDuaVaoSuDung=Convert.ToDateTime(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_NgayDuaVaoSuDung));
                            Public.QLFHD_Ma = int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(QLFHD_Ma));
                            Public.TSHC_XuatXu=bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_XuatXu);
                            Public.TSHC_SoSeri=bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_SoSeri);
                            Public.TSHC_KichThuocDai=bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_KichThuocDai);
                            Public.TSHC_KichThuocRong=bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_KichThuocRong);
                            Public.TSHC_KichThuocCao=bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_KichThuocCao);
                            Public.TSHC_ThoiGianBaoHanh = int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_ThoiGianBaoHanh));

                            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_TenFileGiayToKemTheo))) &&
                                string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_DataFileGiayToKemTheo)))
                                )
                            {
                                Public.TSHC_TenFileGiayToKemTheo = null;
                                Public.TSHC_DataFileGiayToKemTheo = null;
                            }
                            else
                            {
                                Public.TSHC_TenFileGiayToKemTheo = bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_TenFileGiayToKemTheo);
                                Public.TSHC_DataFileGiayToKemTheo = ReadFile(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_DataFileGiayToKemTheo));
                            }

                            if (bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(TSHC_AnhChup).GetType().ToString() == "System.DBNull")
                                Public.TSHC_AnhChup=null;
                            else
                                Public.TSHC_AnhChup = (byte[])bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(TSHC_AnhChup);
                            
                            Public.TSHC_GhiChu=bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_GhiChu);

                            if (bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_NgayBanGiao).ToString() == "")
                                Public.TSHC_NgayBanGiao = null;
                            else
                                Public.TSHC_NgayBanGiao = Convert.ToDateTime(bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_NgayBanGiao));
                            

                            if (TS_TSHC_Add == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.TS_TaiSanHienCo_Them(Public);
                            }

                            if (TS_TSHC_Edit == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.TS_TaiSanHienCo_Sua(Public);
                            }
                        }
                        bandedGridView_TaiSanHienCo.MoveNext();
                    }
                }

                TraVe_DongDLChon();

                //Unlock_Control(true); //Mở khóa toàn bộ
                frmQLTS_TaiSanHienCo_Load(sender, e);
                Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
                Lock_Unlock_Control(true); //Mở khóa toàn bộ

                TS_TSHC_Add = false;
                TS_TSHC_Edit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInDuLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadHamDungChung.PreviewPrintableComponent(gridControl_TaiSanHienCo, gridControl_TaiSanHienCo.LookAndFeel);
        }

        private void btnInQRCode_ItemClick(object sender, ItemClickEventArgs e)
        {

            XtraReport reportMerge = new XtraReport();
            IList<XtraReport> reportList = new List<XtraReport>();
            reportMerge.CreateDocument();
            bandedGridView_TaiSanHienCo.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanHienCo.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(TSHC_Chon)))
                {

                    XtraReport report = new XtraReport();
                    DetailBand Detail = new DetailBand();
                    XRRichText NoiDung = new XRRichText();
                    XRPictureBox AnhQR = new XRPictureBox();
                    XRPageBreak xrPageBreak0 = new XRPageBreak();

                    string NamSanXuat = "", Ma = "",TenTaiSan="";

                    report.ReportUnit = ReportUnit.TenthsOfAMillimeter; //"TenthsOfAMillimeter";


                    System.Drawing.Size p = new System.Drawing.Size();
                    report.PaperKind = System.Drawing.Printing.PaperKind.Custom;
                    report.Margins = new Margins(0, 0, 0, 0);

                    p.Width = 600;
                    p.Height = 200;


                    report.PageSize = p;

                    //report.Margins.Left = report.Margins.Right = report.Margins.Top = report.Margins.Bottom = 0;

                    //NoiDung1.Font = System.


                    Public.TSHC_Ma = int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_Ma));
                    SqlDataReader reader = cls.TS_TaiSanHienCo_Load_R_Para_File(Public);
                    if (reader.Read())
                    {
                        MemoryStream stream = new MemoryStream(reader.GetSqlBytes(9).Buffer);
                        AnhQR.Image = Image.FromStream(stream);

                        AnhQR.Sizing = ImageSizeMode.StretchImage;

                        AnhQR.WidthF = XRConvert.Convert(150, GraphicsDpi.TenthsOfAMillimeter, GraphicsDpi.Pixel);
                        AnhQR.HeightF = XRConvert.Convert(150, GraphicsDpi.TenthsOfAMillimeter, GraphicsDpi.Pixel);

                        NamSanXuat = reader.GetInt32(14).ToString();
                        Ma = reader.GetInt32(0).ToString();

                        TenTaiSan = reader.GetString(6);

                    }
                    reader.Close();


                    AnhQR.LeftF = AnhQR.TopF = XRConvert.Convert(25, GraphicsDpi.TenthsOfAMillimeter, GraphicsDpi.Pixel);

                    //NoiDung.WidthF = 36;
                    //NoiDung.HeightF = 10;

                    string string_NoiDung = "";

                    string_NoiDung += " <table width='100%' border='0' cellspacing='0' cellpadding='0' style='margin-bottom:0px'>";
                    string_NoiDung += "<tr style='font-size:12px'><td width='100%' align='center' style='padding:0px;'><b>TEM THẺ TÀI SẢN</b></td></tr>";
                    string_NoiDung += "<tr style='font-size:12px'><td width='100%' align='center' style='padding:0px;'><br/>"+NamSanXuat+"."+Ma+"</td></tr>";
                    string_NoiDung += "<tr style='font-size:12px'><td width='100%' align='center' style='padding:0px;'>"+TenTaiSan+"</td></tr>";

                    NoiDung.Html = string_NoiDung;

                    NoiDung.TopF = XRConvert.Convert(25, GraphicsDpi.TenthsOfAMillimeter, GraphicsDpi.Pixel);
                    NoiDung.LeftF = XRConvert.Convert(200, GraphicsDpi.TenthsOfAMillimeter, GraphicsDpi.Pixel);
                    NoiDung.WidthF = XRConvert.Convert(400, GraphicsDpi.TenthsOfAMillimeter, GraphicsDpi.Pixel);


                    Detail.Controls.Add(NoiDung);
                    Detail.Controls.Add(AnhQR);


                    //Detail.Controls.Add(xrPageBreak0);

                    //System.Drawing.Size p = new System.Drawing.Size(600,10000); //hundredths of an inch

                    

                    report.Bands.Add(Detail);


                    report.CreateDocument();

                    reportList.Add(report);

                    for (int j = 0; j < reportList.Count; j++)
                    {
                        reportMerge.Pages.AddRange(reportList[j].Pages);
                    }

                }
                bandedGridView_TaiSanHienCo.MoveNext();
            }
            int sotrang = reportMerge.Pages.Count;

            for (int j = 1; j <= sotrang / 2; j++)
            {
                reportMerge.Pages.RemoveAt(j);
            }
            
            reportMerge.ShowPreview();
        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            TS_TSHC_Add = false;
            TS_TSHC_Edit = false;

            Unlock_Control(true); //Mở khóa toàn bộ

            Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
            Lock_Unlock_Control(true); //Mở khóa toàn bộ
        }

        

        private void btnDownloadFileDinhKem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //Start - Download
                Public.TSHC_Ma = int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_Ma));

                SqlDataReader dr = cls.TS_TaiSanHienCo_Load_R_Para_File(Public);
                dr.Read();

                string TenFile = "";
                saveFileDialog1.FileName = Convert.ToString(dr["TSHC_TenFileGiayToKemTheo"].ToString());

                DialogResult DR = saveFileDialog1.ShowDialog();
                if (DR == DialogResult.OK)
                {
                    TenFile = saveFileDialog1.FileName;
                    //Get File data from dataset row.
                    byte[] FileDinhKem = (byte[])dr["TSHC_DataFileGiayToKemTheo"];

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
                MessageBox.Show("Không tồn tại file NỘI DUNG ĐÍNH KÈM! (ID file: " + Public.TSHC_Ma + ")", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

        private void repositoryItemButtonEdit_TSHC_TenFileGiayToKemTheo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgRes = dlg.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {
                //Provide file path in txtVBM_DataFileUpload text box.
                //txtVBM_DataFileUpload.Text = dlg.FileName;
                bandedGridView_TaiSanHienCo.SetFocusedRowCellValue(TSHC_DataFileGiayToKemTheo, dlg.FileName);

                //FileInfo Ten_File = new FileInfo(txtVBM_DataFileUpload.Text);
                FileInfo Ten_File = new FileInfo(dlg.FileName);

                //txtVBM_FileNameUpload.Text = Ten_File.Name;
                bandedGridView_TaiSanHienCo.SetFocusedRowCellValue(TSHC_TenFileGiayToKemTheo, Ten_File.Name);
            }
        }

        private void btnThayLinkQRCode_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQRCode_Sua frm_QRCode_Sua = new frmQRCode_Sua();
            frm_QRCode_Sua.ShowDialog();
            DataTable dt = cls.TS_TaiSanHienCo_Load();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //string URL = cls.TS_QRCode_Load().Rows[0][1] + "?ID=" + dt.Rows[i][1].ToString();
                string URL = dt.Rows[i][1].ToString();
                QRCodeEncoder barcode = new QRCodeEncoder();
                var image = new ImageConverter().ConvertTo(barcode.Encode(URL), typeof(Byte[]));

                Public.TSHC_Ma = int.Parse("0" + dt.Rows[i][1].ToString());
                Public.TSHC_QR_Code = (byte[])image;

                cls.TS_TaiSanHienCo_AddQRCode(Public);

            }
            frmQLTS_TaiSanHienCo_Load(sender, e);
        }

        private void btnDownloadBienBanBanGiao_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool KTNhanSu = true;
            int demsodong = 0;

            DataTable dt = new DataTable();

            dt.Columns.Add("STT");
            dt.Columns.Add("TSHC_TenTaiSan");
            dt.Columns.Add("TSHC_ThuongHieu");
            dt.Columns.Add("TSHC_XuatXu");
            dt.Columns.Add("TSHC_NamSanXuat");
            dt.Columns.Add("TSHC_SoSeri");
            dt.Columns.Add("TSHC_SoLuong");
            dt.Columns.Add("TSHC_ThoiGianBaoHanh");
            dt.Columns.Add("TSHC_GhiChu");

            bandedGridView_TaiSanHienCo.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanHienCo.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(TSHC_Chon)))// == true
                {
                    demsodong++;
                }
                bandedGridView_TaiSanHienCo.MoveNext();
            }
            int[] NguoiQuanLyKT = new int[demsodong];
            int[] NguoiSuDungKT = new int[demsodong];

            if (demsodong == 0)
            {
                MessageBox.Show("Phải chọn ít nhất một tài sản để lập biên bản!!!", "Thông báo");
                KTNhanSu = false;
            }
            else
            {
                if (demsodong == 1)
                {
                    KTNhanSu = true;
                    int sodem = 0;
                    bandedGridView_TaiSanHienCo.MoveFirst();
                    for (int i = 0; i < bandedGridView_TaiSanHienCo.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(TSHC_Chon)))// == true
                        {
                            NguoiQuanLyKT[sodem] = int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(QLNS_MaNSQL));

                            NguoiSuDungKT[sodem] = int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(QLNS_MaNSSD));

                            sodem++;
                            Public.TSHC_Ma = int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_Ma));

                            SqlDataReader dr = cls.TS_TaiSanHienCo_Load_R_Para_File(Public);
                            dr.Read();

                            dt.Rows.Add(sodem, Convert.ToString(dr["TSHC_TenTaiSan"]), Convert.ToString(dr["TSHC_ThuongHieu"]), Convert.ToString(dr["TSHC_XuatXu"]), Convert.ToString(dr["TSHC_NamSanXuat"]), Convert.ToString(dr["TSHC_SoSeri"]), 1, Convert.ToString(dr["TSHC_ThoiGianBaoHanh"]), Convert.ToString(dr["TSHC_GhiChu"]));

                            dr.Close();
                        }
                        bandedGridView_TaiSanHienCo.MoveNext();
                    }
                }
                else
                {
                    int sodem = 0;
                    bandedGridView_TaiSanHienCo.MoveFirst();
                    for (int i = 0; i < bandedGridView_TaiSanHienCo.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(TSHC_Chon)))// == true
                        {
                            NguoiQuanLyKT[sodem] = int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(QLNS_MaNSQL));

                            NguoiSuDungKT[sodem] = int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(QLNS_MaNSSD));

                            sodem++;
                            Public.TSHC_Ma = int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_Ma));

                            SqlDataReader dr = cls.TS_TaiSanHienCo_Load_R_Para_File(Public);
                            dr.Read();

                            dt.Rows.Add(sodem, Convert.ToString(dr["TSHC_TenTaiSan"]), Convert.ToString(dr["TSHC_ThuongHieu"]), Convert.ToString(dr["TSHC_XuatXu"]), Convert.ToString(dr["TSHC_NamSanXuat"]), Convert.ToString(dr["TSHC_SoSeri"]), 1, Convert.ToString(dr["TSHC_ThoiGianBaoHanh"]), Convert.ToString(dr["TSHC_GhiChu"]));

                            dr.Close();
                        }
                        bandedGridView_TaiSanHienCo.MoveNext();
                    }

                    for (int i = 1; i < demsodong; i++)
                    {
                        if (NguoiQuanLyKT[i] != NguoiQuanLyKT[i - 1])
                        {
                            KTNhanSu = false;
                            break;
                        }
                        else if (NguoiSuDungKT[i] != NguoiSuDungKT[i - 1])
                        {
                            KTNhanSu = false;
                            break;
                        }
                    }
                }

                if (!KTNhanSu)
                {
                    MessageBox.Show("Nhân sự quản lý và nhân sự sử dụng của các tài sản được chọn không khớp nhau!!!", "Thông báo");
                }
                else
                {

                    XtraReport_TaiSanHienCo rpt = new XtraReport_TaiSanHienCo(Public);
                    rpt.DataSource = dt;
                    rpt.BindData();

                    rpt.CreateDocument();


                    float sumHeight = 0;

                    foreach (PSPage page in rpt.Pages)
                        foreach (Brick brick in page.Bricks)
                        {
                            if (brick is TableBrick)
                            {
                                TableBrick tableBrick = brick as TableBrick;

                                if (tableBrick.BrickOwner.Name == "xrTable2")
                                    sumHeight += tableBrick.Size.Height;
                            }
                        }

                    //switch (rpt.ReportUnit)
                    //{
                    //    case DevExpress.XtraReports.UI.ReportUnit.HundredthsOfAnInch:
                    //        sumHeight = GraphicsUnitConverter.Convert(sumHeight, GraphicsUnit.Document, GraphicsUnit.Inch) * 100;
                    //        break;
                    //    case DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter:
                    //        sumHeight = GraphicsUnitConverter.Convert(sumHeight, GraphicsUnit.Document, GraphicsUnit.Millimeter) * 10;
                    //        break;
                    //}
                    float totalHeight = sumHeight % 2550;
                    //rpt.PageHeight = Convert.ToInt32(totalHeight);
                    if (totalHeight >= 76 && totalHeight < 1000)
                    {
                        rpt.SetPageHeader();
                    }
                    //MessageBox.Show(totalHeight + "");

                    rpt.CreateDocument();

                    //reportMerge.ShowPreviewDialog();
                    rpt.ShowPreview();

                }
            }
        }

        private void btnDownloadBienBanXacDinhLoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            int demsodong = 0;

            bandedGridView_TaiSanHienCo.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanHienCo.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(TSHC_Chon)))// == true
                {
                    demsodong++;
                }
                bandedGridView_TaiSanHienCo.MoveNext();
            }

            XtraReport reportMerge = new XtraReport();
            IList<XtraReport> reportList = new List<XtraReport>();
            reportMerge.CreateDocument();

            if (demsodong == 0)
            {
                MessageBox.Show("Phải chọn ít nhất một tài sản để lập biên bản!!!", "Thông báo");
            }
            else
            {
                int sodem = 0;
                bandedGridView_TaiSanHienCo.MoveFirst();
                for (int i = 0; i < bandedGridView_TaiSanHienCo.RowCount; i++)
                {
                    if (Convert.ToBoolean(bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(TSHC_Chon)))// == true
                    {

                        sodem++;
                        Public.TSHC_Ma = int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellDisplayText(TSHC_Ma));
                        Public_QuanLyPhong.QLP_Ma = int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(QLP_Ma));
                        Public_QuanLyNhanSu.QLNS_Ma = int.Parse("0" + bandedGridView_TaiSanHienCo.GetFocusedRowCellValue(QLNS_MaNSSD));


                        SqlDataReader dr = cls.TS_TaiSanHienCo_Load_R_Para_File(Public);
                        dr.Read();

                        SqlDataReader dr_01 = cls_QuanLyPhongBLL.TS_QuanLyPhong_Load_R_Para_File(Public_QuanLyPhong);
                        dr_01.Read();

                        SqlDataReader dr_02 = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_Load_R_Para_File(Public_QuanLyNhanSu);
                        dr_02.Read();
                        //Kiểm tra thành viên trong nhóm
                        //1. Nếu thành viên trong nhóm > 0

                        Public_QuanLyDonVi.QLDV_Ma = int.Parse("0" + dr_02["QLDV_Ma"].ToString());

                        SqlDataReader dr_03 = cls_QuanLyDonViBLL.TS_QuanLyDonVi_Load_R_Para_File(Public_QuanLyDonVi);
                        dr_03.Read();

                        //Danh sách kèm theo giấy giới thiệu cho nhóm SV

                        XtraReport report = new XtraReport();
                        DetailBand Detail = new DetailBand();
                        XRRichText Header = new XRRichText();
                        XRRichText NoiDung = new XRRichText();
                        XRPageBreak xrPageBreak0 = new XRPageBreak();

                        Header.WidthF = 705;
                        NoiDung.WidthF = 705;
                        Header.Font = new System.Drawing.Font("Times New Roman", 14F);
                        NoiDung.Font = new System.Drawing.Font("Times New Roman", 14F);

                        Detail.Controls.Add(Header);
                        Detail.Controls.Add(NoiDung);
                        Detail.Controls.Add(xrPageBreak0);

                        string string_Header = "";
                        string string_NoiDung = "";

                        //Cấu hình
                        report.DisplayName = "Bien Ban Xac Dinh Loi";
                        report.ReportUnit = ReportUnit.TenthsOfAMillimeter; //"TenthsOfAMillimeter";
                        report.PaperKind = System.Drawing.Printing.PaperKind.A4;
                        report.Margins.Top = 200;
                        report.Margins.Bottom = 100;
                        report.Margins.Left = 200;
                        report.Margins.Right = 100;
                        report.Landscape = false;
                        //----Start SqlDataReader-----



                        //Phần string_Header
                        string_Header = "<table border='1' cellpadding='0' cellspacing='0' class='MsoNormalTable' style='border-collapse:collapse;mso-table-layout-alt:fixed;border:none;mso-border-alt:solid windowtext .5pt;mso-padding-alt:0cm 5.4pt 0cm 5.4pt;mso-border-insideh:.5pt solid windowtext;mso-border-insidev:.5pt solid windowtext' width='100%'><tr style='mso-yfti-irow:0;mso-yfti-firstrow:yes;mso-yfti-lastrow:yes'><td style='border-style: none; border-color: inherit; border-width: medium; padding: 0cm 5.4pt;' valign='top' width='40%' class='style1'><p align='center' class='MsoNormal' style='margin-top:6.0pt;margin-right:0cm;margin-bottom:6.0pt;margin-left:0cm;mso-para-margin-top:.5gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.5gd;mso-para-margin-left:0cm;text-align:center'><b>TRƯỜNG ĐẠI HỌC KINH TẾ</b></p><p align='center' class='MsoNormal' style='margin-top:6.0pt;margin-right:0cm;margin-bottom:6.0pt;margin-left:0cm;mso-para-margin-top:.5gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.5gd;mso-para-margin-left:0cm;text-align:center'><b>&nbsp;KỸ THUẬT CÔNG NGHIỆP<br />---------------<o:p></o:p></b></p></td><td style='border:none;padding:0cm 5.4pt 0cm 5.4pt' valign='top' width='60%'><p align='center' class='MsoNormal' style='margin-top:6.0pt;margin-right:0cm;margin-bottom:6.0pt;margin-left:0cm;mso-para-margin-top:.5gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.5gd;mso-para-margin-left:0cm;text-align:center'><b>CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM<o:p></o:p></b></p><p align='center' class='MsoNormal' style='margin-top:6.0pt;margin-right:0cm;margin-bottom:6.0pt;margin-left:0cm;mso-para-margin-top:.5gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.5gd;mso-para-margin-left:0cm;text-align:center'><b>Độc lập - Tự do - Hạnh phúc<br />---------------<o:p></o:p></b></p></td></tr></table>";

                        //Phần string_NoiDung
                        string_NoiDung = "<br/><br/><br/><br/><br/>";
                        string_NoiDung += "<p align='center' class='MsoNormal' style='margin: 6.0pt 0cm; mso-para-margin-top: .5gd; mso-para-margin-right: 0cm; mso-para-margin-bottom: .5gd; mso-para-margin-left: 0cm; text-align: center; line-height: 130%'><b>BIÊN BẢN KIỂM TRA TÌNH TRẠNG HƯ HỎNG CỦA TRANG THIẾT BỊ<o:p></o:p></b></p><br/><br/>";
                        string_NoiDung += "<p class='MsoNormal' style='margin-top:4.8pt;margin-right:0cm;margin-bottom:4.8pt;margin-left:0cm;mso-para-margin-top:.4gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.4gd;mso-para-margin-left:0cm;text-align:justify;text-justify:inter-ideograph;line-height:120%;tab-stops:dotted 420.0pt'>Tên trang thiết bị:<span style='mso-tab-count:1 dotted'> " + dr["TSHC_TenTaiSan"].ToString() + " </span></p>";
                        string_NoiDung += "<p class='MsoNormal' style='margin-top:4.8pt;margin-right:0cm;margin-bottom:4.8pt;margin-left:0cm;mso-para-margin-top:.4gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.4gd;mso-para-margin-left:0cm;text-align:justify;text-justify:inter-ideograph;line-height:120%;tab-stops:dotted 420.0pt'>Tại: Phòng " + dr_01["QLP_TenPhong"] + ", Tòa nhà " + dr_01["QLP_ToaNha"] + ", " + dr_01["QLP_DiaDiem"] + "</p>";
                        string_NoiDung += "<p class='MsoNormal' style='margin: 4.8pt 0cm; mso-para-margin-top: .4gd; mso-para-margin-right: 0cm; mso-para-margin-bottom: .4gd; mso-para-margin-left: 0cm; text-align: left; text-justify: inter-ideograph; line-height: 120%; tab-stops: dotted 420.0pt'>Họ và tên người sử dụng: " + dr_02["QLNS_HoTen"].ToString() + " &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Đơn vị:<span style='mso-tab-count:1 dotted'> " + dr_03["QLDV_TenDonVi"].ToString() + " </p>";
                        string_NoiDung += "<p class='MsoNormal' style='margin-top:4.8pt;margin-right:0cm;margin-bottom:4.8pt;margin-left:0cm;mso-para-margin-top:.4gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.4gd;mso-para-margin-left:0cm;text-align:justify;text-justify:inter-ideograph;line-height:120%;tab-stops:dotted 420.0pt'>Kết quả kiểm tra: <span style='mso-tab-count:1 dotted'> ............................................................................................................................................ </span></p>";
                        string_NoiDung += "<p class='MsoNormal' style='margin-top:4.8pt;margin-right:0cm;margin-bottom:4.8pt;margin-left:0cm;mso-para-margin-top:.4gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.4gd;mso-para-margin-left:0cm;text-align:justify;text-justify:inter-ideograph;line-height:120%;tab-stops:dotted 420.0pt'><span style='mso-tab-count:1 dotted'> ......................................................................................................................................................................... </span></p>";
                        string_NoiDung += "<p class='MsoNormal' style='margin-top:4.8pt;margin-right:0cm;margin-bottom:4.8pt;margin-left:0cm;mso-para-margin-top:.4gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.4gd;mso-para-margin-left:0cm;text-align:justify;text-justify:inter-ideograph;line-height:120%;tab-stops:dotted 420.0pt'><span style='mso-tab-count:1 dotted'> ......................................................................................................................................................................... </span></p>";
                        string_NoiDung += "<p class='MsoNormal' style='margin-top:4.8pt;margin-right:0cm;margin-bottom:4.8pt;margin-left:0cm;mso-para-margin-top:.4gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.4gd;mso-para-margin-left:0cm;text-align:justify;text-justify:inter-ideograph;line-height:120%;tab-stops:dotted 420.0pt'><span style='mso-tab-count:1 dotted'> ......................................................................................................................................................................... </span></p>";
                        string_NoiDung += "<p class='MsoNormal' style='margin-top:4.8pt;margin-right:0cm;margin-bottom:4.8pt;margin-left:0cm;mso-para-margin-top:.4gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.4gd;mso-para-margin-left:0cm;text-align:justify;text-justify:inter-ideograph;line-height:120%;tab-stops:dotted 420.0pt'>Hướng khắc phục: <span style='mso-tab-count:1 dotted'> .......................................................................................................................................... </span></p>";
                        string_NoiDung += "<p class='MsoNormal' style='margin-top:4.8pt;margin-right:0cm;margin-bottom:4.8pt;margin-left:0cm;mso-para-margin-top:.4gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.4gd;mso-para-margin-left:0cm;text-align:justify;text-justify:inter-ideograph;line-height:120%;tab-stops:dotted 420.0pt'><span style='mso-tab-count:1 dotted'> ......................................................................................................................................................................... </span></p>";
                        string_NoiDung += "<p class='MsoNormal' style='margin-top:4.8pt;margin-right:0cm;margin-bottom:4.8pt;margin-left:0cm;mso-para-margin-top:.4gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.4gd;mso-para-margin-left:0cm;text-align:justify;text-justify:inter-ideograph;line-height:120%;tab-stops:dotted 420.0pt'><span style='mso-tab-count:1 dotted'> ......................................................................................................................................................................... </span></p>";
                        string_NoiDung += "<p class='MsoNormal' style='margin-top:4.8pt;margin-right:0cm;margin-bottom:4.8pt;margin-left:0cm;mso-para-margin-top:.4gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.4gd;mso-para-margin-left:0cm;text-align:justify;text-justify:inter-ideograph;line-height:120%;tab-stops:dotted 420.0pt'><span style='mso-tab-count:1 dotted'> ......................................................................................................................................................................... </span></p><br/>";

                        //MessageBox.Show("Đường dẫn" + Environment.CurrentDirectory);
                        //string Duong_Dan = "'" + Environment.CurrentDirectory.ToString().Replace("\\", "/") + "/img_dongke_dam.bmp'";
                        //MessageBox.Show("Đường dẫn: " + Duong_Dan);

                        string_NoiDung += "<table border='1' cellpadding='0' cellspacing='0' class='MsoNormalTable' style='border-collapse:collapse;mso-table-layout-alt:fixed;border:none;mso-border-alt:solid windowtext .5pt;mso-padding-alt:0cm 5.4pt 0cm 5.4pt;mso-border-insideh:.5pt solid windowtext;mso-border-insidev:.5pt solid windowtext' width='100%'><tr style='mso-yfti-irow:0;mso-yfti-firstrow:yes'><td colspan='3' style='border:none;padding:0cm 5.4pt 0cm 5.4pt' valign='top' width='100%' class='style2'><p align='right' class='MsoNormal' style='margin-top:4.8pt;margin-right:0cm;margin-bottom:4.8pt;margin-left:0cm;mso-para-margin-top:.4gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.4gd;mso-para-margin-left:0cm;text-align:right;word-break:break-all'><i>...................................., ngày...........tháng...........năm..................<o:p></o:p></i></p></td></tr><tr style='mso-yfti-irow:1;mso-yfti-lastrow:yes'><td style='border:none;padding:0cm 5.4pt 0cm 5.4pt' valign='top' width='35%'><p align='center' class='MsoNormal' style='margin-top:4.8pt;margin-right:0cm;margin-bottom:4.8pt;margin-left:0cm;mso-para-margin-top:.4gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.4gd;mso-para-margin-left:0cm;text-align:center'><b>ĐẠI DIỆN PHÒNG QUẢN TRỊ<br /></b><i>(Ký, ghi rõ họ tên)</i><o:p></o:p></p></td><td style='border:none;padding:0cm 5.4pt 0cm 5.4pt' valign='top' width='35%'><p align='center' class='MsoNormal' style='margin-top:4.8pt;margin-right:0cm;margin-bottom:4.8pt;margin-left:0cm;mso-para-margin-top:.4gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.4gd;mso-para-margin-left:0cm;text-align:center'><b>NGƯỜI SỬ DỤNG<br /></b><i>(Ký, ghi rõ họ tên)</i><o:p></o:p></p></td><td style='border:none;padding:0cm 5.4pt 0cm 5.4pt' valign='top' width='30%'><p align='center' class='MsoNormal' style='margin-top:4.8pt;margin-right:0cm;margin-bottom:4.8pt;margin-left:0cm;mso-para-margin-top:.4gd;mso-para-margin-right:0cm;mso-para-margin-bottom:.4gd;mso-para-margin-left:0cm;text-align:center'><b>NGƯỜI KIỂM TRA</b><br /><i>(Ký, ghi rõ họ tên)</i><o:p></o:p></p></td></tr></table>";

                        //----End SqlDataReader-----

                        Header.Html = string_Header;
                        NoiDung.Html = string_NoiDung;

                        report.Bands.Add(Detail);
                        report.CreateDocument();

                        reportList.Add(report);


                        dr.Close();
                        dr_01.Close();
                        dr_02.Close();
                        dr_03.Close();
                    }
                    bandedGridView_TaiSanHienCo.MoveNext();
                }

                for (int i = 0; i < reportList.Count; i++)
                {
                    reportMerge.Pages.AddRange(reportList[i].Pages);
                }

                //reportMerge.ShowPreviewDialog();
                reportMerge.ShowPreview();
            }

        }

        
        //void itemDelete_Click(object sender, EventArgs e)
        //{
        //    //OnDelete();
        //}

        #region Cho phép thực hiện thao tác CLICK phải chuột

        void Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_TaiSanHienCo.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanHienCo.RowCount; i++)
            {
                bandedGridView_TaiSanHienCo.SetFocusedRowCellValue(TSHC_Chon, true);
                bandedGridView_TaiSanHienCo.MoveNext();
            }
            bandedGridView_TaiSanHienCo.MoveFirst();
        }

        void No_Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_TaiSanHienCo.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanHienCo.RowCount; i++)
            {
                bandedGridView_TaiSanHienCo.SetFocusedRowCellValue(TSHC_Chon, false);
                bandedGridView_TaiSanHienCo.MoveNext();
            }
            bandedGridView_TaiSanHienCo.MoveFirst();
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