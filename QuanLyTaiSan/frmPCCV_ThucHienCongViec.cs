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
using BLL;
using Public;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.NativeBricks;
using DevExpress.XtraReports.UI;

namespace QuanLyTaiSan
{
    public partial class frmPCCV_ThucHienCongViec : DevExpress.XtraEditors.XtraForm
    {
        ThucHienCongViecBLL cls = new ThucHienCongViecBLL();
        ThucHienCongViecPublic Public = new ThucHienCongViecPublic();

        TaiSanHienCoBLL cls_TaiSanHienCoBLL = new TaiSanHienCoBLL();
        TaiSanHienCoPublic Public_TaiSanHienCo = new TaiSanHienCoPublic();

        PhanCongCongViecBLL cls_PhanCongCongViecBLL = new PhanCongCongViecBLL();
        PhanCongCongViecPublic Public_PhanCongCongViec = new PhanCongCongViecPublic();

        QuanLyFileHoSoThanhToanBLL cls_QuanLyFileHoSoThanhToanBLL = new QuanLyFileHoSoThanhToanBLL();
        QuanLyFileHoSoThanhToanPublic Public_QuanLyFileHoSoThanhToan = new QuanLyFileHoSoThanhToanPublic();

        QuanLyNhanSuBLL cls_QuanLyNhanSuBLL = new QuanLyNhanSuBLL();
        QuanLyNhanSuPublic Public_QuanLyNhanSu = new QuanLyNhanSuPublic();

        QuanLyPhongBLL cls_QuanLyPhongBLL = new QuanLyPhongBLL();
        QuanLyPhongPublic Public_QuanLyPhong = new QuanLyPhongPublic();

        HT_PQ_USERBLL cls_HT_PQ_USER = new HT_PQ_USERBLL();
        HT_PQ_USERPublic Public_HT_PQ_USER = new HT_PQ_USERPublic();

        Boolean PC_THCV_Add = false;
        Boolean PC_THCV_Edit = false;

        

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


        public frmPCCV_ThucHienCongViec()
        {
            InitializeComponent();
            Lock_Unlock_Control_Input(false);

            new MultiSelectionEditingHelper(bandedGridView_ThucHienCongViec);
        }


        private void frmPCCV_ThucHienCongViec_Load(object sender, EventArgs e)
        {

            repositoryItemLookUpEdit_Phong.DataSource = cls_TaiSanHienCoBLL.TS_TSHC_QuanLyPhong_Load();
            repositoryItemLookUpEdit_Phong.DisplayMember = "QLP_MaPhong";
            repositoryItemLookUpEdit_Phong.ValueMember = "QLP_Ma";

            repositoryItemLookUpEdit_Phong.PopupWidth = 1000;
            repositoryItemLookUpEdit_Phong.ShowFooter = false;
            repositoryItemLookUpEdit_Phong.Columns.Clear();
            repositoryItemLookUpEdit_Phong.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_Ma", "Mã", 100));
            repositoryItemLookUpEdit_Phong.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_LoaiPhong", "Loại phòng", 100));
            repositoryItemLookUpEdit_Phong.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_CoSo", "Cơ sở", 200));
            repositoryItemLookUpEdit_Phong.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_DiaDiem", "Địa điểm", 100));
            repositoryItemLookUpEdit_Phong.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_ToaNha", "Toà nhà", 200));
            repositoryItemLookUpEdit_Phong.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_MaPhong", "Mã phòng", 100));
            repositoryItemLookUpEdit_Phong.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_TenPhong", "Tên phòng", 200));

            repositoryItemLookUpEdit_CoSo.DataSource = cls_TaiSanHienCoBLL.TS_TSHC_QuanLyPhong_Load();
            repositoryItemLookUpEdit_CoSo.DisplayMember = "QLP_CoSo";
            repositoryItemLookUpEdit_CoSo.ValueMember = "QLP_Ma";

            repositoryItemLookUpEdit_DiaDiem.DataSource = cls_TaiSanHienCoBLL.TS_TSHC_QuanLyPhong_Load();
            repositoryItemLookUpEdit_DiaDiem.DisplayMember = "QLP_DiaDiem";
            repositoryItemLookUpEdit_DiaDiem.ValueMember = "QLP_Ma";

            repositoryItemLookUpEdit_ToaNha.DataSource = cls_TaiSanHienCoBLL.TS_TSHC_QuanLyPhong_Load();
            repositoryItemLookUpEdit_ToaNha.DisplayMember = "QLP_ToaNha";
            repositoryItemLookUpEdit_ToaNha.ValueMember = "QLP_Ma";

            repositoryItemLookUpEdit_TenPhong.DataSource = cls_TaiSanHienCoBLL.TS_TSHC_QuanLyPhong_Load();
            repositoryItemLookUpEdit_TenPhong.DisplayMember = "QLP_TenPhong";
            repositoryItemLookUpEdit_TenPhong.ValueMember = "QLP_Ma";

            repositoryItemLookUpEdit_CongViec.DataSource = cls_PhanCongCongViecBLL.PC_PhanCongCongViec_Load();
            repositoryItemLookUpEdit_CongViec.DisplayMember = "DMCV_TenCongViec";
            repositoryItemLookUpEdit_CongViec.ValueMember = "PCCV_Ma";

            repositoryItemLookUpEdit_CongViec.PopupWidth = 600;
            repositoryItemLookUpEdit_CongViec.ShowFooter = false;
            repositoryItemLookUpEdit_CongViec.Columns.Clear();
            repositoryItemLookUpEdit_CongViec.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PCCV_Ma", "Mã", 100));
            repositoryItemLookUpEdit_CongViec.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DMCV_TenCongViec", "Tên công việc", 200));
            repositoryItemLookUpEdit_CongViec.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_MaNSTH", "Mã NSTH", 100));
            repositoryItemLookUpEdit_CongViec.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_HoTen", "Tên NSTH", 200));

            repositoryItemLookUpEdit_QLFHSTT_Ma.DataSource = cls_QuanLyFileHoSoThanhToanBLL.QL_QuanLyFileHoSoThanhToan_Load();
            repositoryItemLookUpEdit_QLFHSTT_Ma.DisplayMember = "QLFHSTT_SoHoSo";
            repositoryItemLookUpEdit_QLFHSTT_Ma.ValueMember = "QLFHSTT_Ma";

            repositoryItemLookUpEdit_QLFHSTT_Ma.PopupWidth = 500;
            repositoryItemLookUpEdit_QLFHSTT_Ma.ShowFooter = false;
            repositoryItemLookUpEdit_QLFHSTT_Ma.Columns.Clear();
            repositoryItemLookUpEdit_QLFHSTT_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLFHSTT_Ma", "Mã", 100));
            repositoryItemLookUpEdit_QLFHSTT_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLFHSTT_SoHoSo", "Số hồ sơ", 200));
            repositoryItemLookUpEdit_QLFHSTT_Ma.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLFHSTT_NgayHoSo", "Ngày hồ sơ", 200));

            RepositoryItemLookUpEdit r1 = new RepositoryItemLookUpEdit();
            r1.DataSource = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_Load();
            r1.DisplayMember = "QLNS_MaNhanSu";
            r1.ValueMember = "QLNS_Ma";

            r1.PopupWidth = 900;
            r1.ShowFooter = false;
            r1.Columns.Clear();
            r1.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_Ma", "Mã đơn vị", 100));
            r1.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_MaNhanSu", "Mã nhân sự", 100));
            r1.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_HoTen", "Tên nhân sự", 200));
            r1.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLDV_TenDonVi", "Tên đơn vị", 200));
            r1.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_CoSo", "Cơ sở", 100));

            QLNS_MaNSTH.ColumnEdit = r1;
            QLNS_MaNSKT.ColumnEdit = r1;


            RepositoryItemLookUpEdit r2 = new RepositoryItemLookUpEdit();
            r2.DataSource = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_Load();
            r2.DisplayMember = "QLNS_HoTen";
            r2.ValueMember = "QLNS_Ma";
            THCV_TenNSTH.ColumnEdit = r2;
            QLNS_TenNSKT.ColumnEdit = r2;
       
            

            RepositoryItemLookUpEdit r5 = new RepositoryItemLookUpEdit();
            r5.DataSource = cls_TaiSanHienCoBLL.TS_TaiSanHienCo_Load();
            r5.DisplayMember = "TSHC_TenTaiSan";
            r5.ValueMember = "TSHC_Ma";
            TSHC_TenTaiSan.ColumnEdit = r5;



            gridControl_ThucHienCongViec.DataSource = cls.PC_ThucHienCongViec_Load();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPCCV_ThucHienCongViec_Load(sender, e);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PC_THCV_Add = true;
            PC_THCV_Edit = false;

            Lock_Unlock_Control_Input(true);
            Lock_Unlock_Control(false);

        }
        private void Lock_Unlock_Control_Input(bool Lock_Control)
        {
            this.THCV_Ma.OptionsColumn.ReadOnly = true;
            this.THCV_NgayThucHien.OptionsColumn.ReadOnly = !Lock_Control;
            this.THCV_ThuTrongTrongTuan.OptionsColumn.ReadOnly = !Lock_Control;
            this.THCV_NguonCongViec.OptionsColumn.ReadOnly = !Lock_Control;
            this.THCV_MucDoUuTien.OptionsColumn.ReadOnly = !Lock_Control;
            this.THCV_NgayYeuCau.OptionsColumn.ReadOnly = !Lock_Control;
            this.THCV_NgayDeNghiHoanThanh.OptionsColumn.ReadOnly = !Lock_Control;
            this.THCV_YeuCau.OptionsColumn.ReadOnly = !Lock_Control;
            this.THCV_MoTa.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLP_Ma.OptionsColumn.ReadOnly = !Lock_Control;
            this.THCV_CoSo.OptionsColumn.ReadOnly = true;
            this.THCV_DiaDiem.OptionsColumn.ReadOnly = true;
            this.THCV_ToaNha.OptionsColumn.ReadOnly = true;
            this.THCV_Phong.OptionsColumn.ReadOnly = true;
            this.THCV_GhiChu.OptionsColumn.ReadOnly = !Lock_Control;
            this.PCCV_Ma.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_Ma.OptionsColumn.ReadOnly = !Lock_Control;
            this.TSHC_TenTaiSan.OptionsColumn.ReadOnly = true;
            this.QLNS_MaNSTH.OptionsColumn.ReadOnly = !Lock_Control;
            this.THCV_TenNSTH.OptionsColumn.ReadOnly = true;
            this.QLNS_MaNSKT.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLNS_TenNSKT.OptionsColumn.ReadOnly = true;
            this.THCV_MoTaCongViec.OptionsColumn.ReadOnly = !Lock_Control;
            this.THCV_TuDanhGia.OptionsColumn.ReadOnly = !Lock_Control;
            this.THCV_ThoiGianBatDau.OptionsColumn.ReadOnly = !Lock_Control;
            this.THCV_ThoiGianKetThuc.OptionsColumn.ReadOnly = !Lock_Control;
            this.THCV_SoPhut.OptionsColumn.ReadOnly = !Lock_Control;
            this.THCV_DeXuat.OptionsColumn.ReadOnly = !Lock_Control;
            this.THCV_DanhGia.OptionsColumn.ReadOnly = !Lock_Control;
            this.THCV_GhiChuNguoiKiemTra.OptionsColumn.ReadOnly = !Lock_Control;
            this.QLFHSTT_Ma.OptionsColumn.ReadOnly = !Lock_Control;

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
            bandedGridView_ThucHienCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_ThucHienCongViec.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_Chon)) &&
                        (

                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_NgayThucHien))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_NguonCongViec))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_MucDoUuTien))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_NgayDeNghiHoanThanh))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_NgayYeuCau ))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(QLP_Ma))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(QLNS_MaNSKT))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(QLNS_MaNSTH))) 


                        )
                    )
                {
                    return false;
                }
                bandedGridView_ThucHienCongViec.MoveNext();
            }
            return true;
        }

        private bool KiemTra()
        {
            bandedGridView_ThucHienCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_ThucHienCongViec.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_Chon)))
                {
                    return true;
                }
                bandedGridView_ThucHienCongViec.MoveNext();
            }
            return false;
        }

        private void TraVe_DongDLChon()
        {
            bandedGridView_ThucHienCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_ThucHienCongViec.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_Chon)))
                {
                    //Trả con trỏ về vị trí được chọn
                    break;
                }
                bandedGridView_ThucHienCongViec.MoveNext();
            }
        }


        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTra() == false)
            {
                MessageBox.Show("Bạn phải chọn dữ liệu", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_Chon))))
            {
                MessageBox.Show("Bạn phải lựa chọn lại dữ liệu trên lưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {
                PC_THCV_Add = false;
                PC_THCV_Edit = true;

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
                bandedGridView_ThucHienCongViec.MoveFirst();
                for (int i = 0; i < bandedGridView_ThucHienCongViec.RowCount; i++)
                {
                    if (Convert.ToBoolean(bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_Chon))) // == true
                    {
                        if (!string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_Chon))))
                        {
                            Lock_Unlock_Control(false); //Mở khóa lưu dữ liệu

                            Public.THCV_Ma = Convert.ToInt32(bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_Ma));

                            int kq = cls.PC_ThucHienCongViec_Xoa(Public);
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
                    bandedGridView_ThucHienCongViec.MoveNext();
                }

                //Chạy lại phần tìm kiếm
                frmPCCV_ThucHienCongViec_Load(sender, e);

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

                Public.THCV_HienThi = true;
                Public.THCV_SuDung = BienToanCuc.HT_PB_Ten;

                if (PC_THCV_Add == true || PC_THCV_Edit == true)
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

                    bandedGridView_ThucHienCongViec.MoveFirst();
                    for (int i = 0; i < bandedGridView_ThucHienCongViec.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_Chon))) // == true
                        {


                            Public.THCV_Ma = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_Ma));
                            Public.THCV_NgayThucHien = Convert.ToDateTime(bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_NgayThucHien));
                            Public.THCV_ThuTrongTrongTuan = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_ThuTrongTrongTuan));
                            Public.THCV_NguonCongViec = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_NguonCongViec);
                            Public.THCV_MucDoUuTien = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_MucDoUuTien));
                            Public.THCV_NgayYeuCau = Convert.ToDateTime(bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_NgayYeuCau));
                            Public.THCV_NgayDeNghiHoanThanh = Convert.ToDateTime(bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_NgayDeNghiHoanThanh));
                            Public.THCV_YeuCau = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_YeuCau);
                            Public.THCV_MoTa = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_MoTa);
                            Public.QLP_Ma = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_CoSo));

                            Public.THCV_GhiChu = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_GhiChu);
                            Public.PCCV_Ma = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(PCCV_Ma));

                            Public.QLNS_MaNSTH = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(QLNS_MaNSTH));
                            Public.QLNS_MaNSKT = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(QLNS_MaNSKT));
                            Public.TSHC_Ma = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(TSHC_Ma));

                            Public.THCV_MoTaCongViec = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_MoTaCongViec);
                            Public.THCV_TuDanhGia = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_TuDanhGia);

                            if (bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_ThoiGianBatDau).ToString() == "")
                                Public.THCV_ThoiGianBatDau = null;
                            else
                                Public.THCV_ThoiGianBatDau = Convert.ToDateTime(bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_ThoiGianBatDau));

                            if (bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_ThoiGianKetThuc).ToString() == "")
                                Public.THCV_ThoiGianKetThuc = null;
                            else
                                Public.THCV_ThoiGianKetThuc = Convert.ToDateTime(bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_ThoiGianKetThuc));

                            Public.THCV_SoPhut = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_SoPhut));
                            Public.THCV_DeXuat = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_DeXuat);
                            Public.THCV_KetQuaThucHien = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_KetQuaThucHien);
                            Public.THCV_GhiChuNguoiThucHien = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_GhiChuNguoiThucHien);
                            Public.THCV_DanhGia = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_DanhGia);
                            Public.THCV_GhiChuNguoiKiemTra = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_GhiChuNguoiKiemTra);
                            Public.QLFHSTT_Ma = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(QLFHSTT_Ma));

                            if (PC_THCV_Add == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.PC_ThucHienCongViec_Them(Public);
                            }

                            if (PC_THCV_Edit == true)
                            {
                                //Cập nhật dữ liệu vào bảng
                                int kq = cls.PC_ThucHienCongViec_Sua(Public);
                            }
                        }
                        bandedGridView_ThucHienCongViec.MoveNext();
                    }
                }


                TraVe_DongDLChon();

                //Unlock_Control(true); //Mở khóa toàn bộ
                frmPCCV_ThucHienCongViec_Load(sender, e);
                Lock_Unlock_Control_Input(false); //Khóa điều khiển nhập dữ liệu
                Lock_Unlock_Control(true); //Mở khóa toàn bộ

                PC_THCV_Add = false;
                PC_THCV_Edit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemTuDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPCCV_THCV_ChonNgayThucHienCongViec frm_ChonNgayThucHienCongViec = new frmPCCV_THCV_ChonNgayThucHienCongViec();
            frm_ChonNgayThucHienCongViec.ShowDialog();
            frmPCCV_ThucHienCongViec_Load(sender,e);


        //    DataTable LocDS = cls_DanhMucCongViecBLL.PC_DanhMucCongViec_LoadDistinct();

        //    for (int stt = 0; stt < LocDS.Rows.Count; stt++)
        //    {
        //        CacHamXuLyPhanCong pc = new CacHamXuLyPhanCong();

        //        int soluongcongviec, soluongnhansu;

        //        DataTable congviectrung;

        //        Public_DanhMucCongViec.DMCV_NhomCongViec = LocDS.Rows[stt]["DMCV_NhomCongViec"].ToString();
        //        Public_DanhMucCongViec.DMCV_DiaDiem = LocDS.Rows[stt]["DMCV_DiaDiem"].ToString();

        //        soluongcongviec = cls_DanhMucCongViecBLL.PC_DanhMucCongViec_SoLuong(Public_DanhMucCongViec);

        //        Public_QuanLyNhanSu.QLNS_ChuyenMon = LocDS.Rows[stt]["DMCV_NhomCongViec"].ToString();
        //        Public_QuanLyNhanSu.QLNS_CoSo = LocDS.Rows[stt]["DMCV_DiaDiem"].ToString();

        //        soluongnhansu = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_SoLuong(Public_QuanLyNhanSu);

        //        if (soluongcongviec > 0 && soluongnhansu > 0)
        //        {
        //            CongViec[] congviec = new CongViec[soluongcongviec];

        //            DataTable dt = cls_DanhMucCongViecBLL.PC_DanhMucCongViec_Loc(Public_DanhMucCongViec);

        //            for (int i = 0; i < soluongcongviec; i++)
        //            {
        //                congviec[i] = new CongViec();
        //                congviec[i].CV_MaCongViec = Convert.ToInt32(dt.Rows[i]["DMCV_Ma"]);
        //                congviec[i].CV_ThoiGian = Convert.ToInt32(dt.Rows[i]["DMCV_ThoiGianHoanThanh"]);
        //                //congviec[i].CV_NgayBatDau = Convert.ToDateTime(dt.Rows[stt]["DMCV_ThoiGianBatDau"]);
        //            }

        //            NhanSu[] nhansu = new NhanSu[soluongnhansu];

        //            DataTable dt0 = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_Loc(Public_QuanLyNhanSu);
        //            for (int i = 0; i < soluongnhansu; i++)
        //            {
        //                nhansu[i] = new NhanSu();
        //                nhansu[i].NS_MaNhanSu = Convert.ToInt32(dt0.Rows[i]["QLNS_Ma"]);
        //                nhansu[i].NS_TongThoiGian = 0;
        //                nhansu[i].NS_SoCongViec = 0;
        //            }

        //            pc.SapXepCongViec(congviec, soluongcongviec);

        //            pc.ChiaCongViec(nhansu, soluongnhansu, congviec, soluongcongviec);


        //            for (int i = 0; i < soluongnhansu; i++)
        //            {

        //                for (int j = 0; j < nhansu[i].NS_SoCongViec; j++)
        //                {
        //                    bool ktra = false;

        //                    Public.HT_UserCreate = BienToanCuc.HT_USER_ID;
        //                    //Public.QLP_DateCreate =
        //                    Public.HT_UserEditor = BienToanCuc.HT_USER_ID;
        //                    //Public.QLP_DateEditor =

        //                    Public.PCCV_HienThi = true;
        //                    Public.PCCV_SuDung = BienToanCuc.HT_PB_Ten;
        //                    Public.PCCV_GhiChu = "";

        //                    Public.QLNS_MaNSTH = nhansu[i].NS_MaNhanSu;
        //                    Public.DMCV_Ma = nhansu[i].NS_CongViec[j].CV_MaCongViec;
        //                    Public.PCCV_TrongTrach = 1;

        //                    //SqlDataReader reader = cls_DanhMucCongViecBLL.PC_DanhMucCongViec_Load_R_Para();

        //                    //while (reader.Read())
        //                    //{
        //                    //    //if (nhansu[i].NS_CongViec[j].CV_MaCongViec == Convert.ToDateTime(reader["DMCV_ThoiGianBatDau"]))
        //                    //    //{
        //                    //    //    ktra = true;
        //                    //    //}
        //                    //}

        //                    //if (ktra == false)
        //                    //{
        //                    //    cls.PC_PhanCongCongViec_Them(Public);
        //                    //}
        //                    //else 
        //                    //{
        //                    //    congviectrung = cls.PC_PhanCongCongViec_Load();

        //                    //    congviectrung.Rows.Clear();

        //                    //    //congviectrung.Rows.Add("","",);
        //                    //}

        //                    cls.PC_PhanCongCongViec_Them(Public);
        //                }
        //            }
        //        }

        //    }
        //    frmPCCV_PhanCongCongViec_Load(sender, e);
        }


        private void btnIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadHamDungChung.PreviewPrintableComponent(gridControl_ThucHienCongViec, gridControl_ThucHienCongViec.LookAndFeel);
        }

        private void btnDownloadBienBanBaoHanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool KTNhanSu = true;
            int demsodong = 0;

            DataTable dt = new DataTable();

            dt.Columns.Add("STT");
            dt.Columns.Add("TSHC_TenTaiSan");
            dt.Columns.Add("QLP_TenPhong");
            dt.Columns.Add("QLP_ToaNha");
            dt.Columns.Add("QLP_DiaDiem");
            dt.Columns.Add("TSHC_NgayDuaVaoSuDung");
            dt.Columns.Add("TSHC_ThoiGianBaoHanh");
            dt.Columns.Add("TSHC_GhiChu");

            bandedGridView_ThucHienCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_ThucHienCongViec.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_Chon)))// == true
                {
                    demsodong++;
                }
                bandedGridView_ThucHienCongViec.MoveNext();
            }

            int[] NguoiThucHien = new int[demsodong];

            if (demsodong == 0)
            {
                MessageBox.Show("Phải chọn ít nhất một công việc để lập biên bản!!!", "Thông báo");
                KTNhanSu = false;
            }
            else
            {
                if (demsodong == 1)
                {
                    KTNhanSu = true;
                    int sodem = 0;
                    bandedGridView_ThucHienCongViec.MoveFirst();
                    for (int i = 0; i < bandedGridView_ThucHienCongViec.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_Chon)))// == true
                        {

                            NguoiThucHien[sodem] = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(QLNS_MaNSTH));

                            sodem++;

                            Public.THCV_Ma = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_Ma));

                            Public_TaiSanHienCo.TSHC_Ma = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(TSHC_Ma));

                            SqlDataReader dr = cls_TaiSanHienCoBLL.TS_TaiSanHienCo_Load_R_Para_File(Public_TaiSanHienCo);
                            dr.Read();

                            Public_QuanLyPhong.QLP_Ma = Convert.ToInt32(dr["QLP_Ma"]);

                            SqlDataReader dr_01 = cls_QuanLyPhongBLL.TS_QuanLyPhong_Load_R_Para_File(Public_QuanLyPhong);
                            dr_01.Read();

                            dt.Rows.Add(sodem, Convert.ToString(dr["TSHC_TenTaiSan"]), Convert.ToString(dr_01["QLP_TenPhong"]), Convert.ToString(dr_01["QLP_ToaNha"]), Convert.ToString(dr_01["QLP_DiaDiem"]), Convert.ToString(dr["TSHC_NgayDuaVaoSuDung"]), Convert.ToString(dr["TSHC_ThoiGianBaoHanh"]), Convert.ToString(dr["TSHC_GhiChu"]));

                            dr.Close();
                            dr_01.Close();
                        }
                        bandedGridView_ThucHienCongViec.MoveNext();
                    }
                }
                else
                {
                    int sodem = 0;
                    bandedGridView_ThucHienCongViec.MoveFirst();
                    for (int i = 0; i < bandedGridView_ThucHienCongViec.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_Chon)))// == true
                        {

                            NguoiThucHien[sodem] = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(QLNS_MaNSTH));

                            sodem++;

                            Public.THCV_Ma = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_Ma));

                            Public_TaiSanHienCo.TSHC_Ma = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(TSHC_Ma));

                            SqlDataReader dr = cls_TaiSanHienCoBLL.TS_TaiSanHienCo_Load_R_Para_File(Public_TaiSanHienCo);
                            dr.Read();

                            Public_QuanLyPhong.QLP_Ma = Convert.ToInt32(dr["QLP_Ma"]);

                            SqlDataReader dr_01 = cls_QuanLyPhongBLL.TS_QuanLyPhong_Load_R_Para_File(Public_QuanLyPhong);
                            dr_01.Read();

                            dt.Rows.Add(sodem, Convert.ToString(dr["TSHC_TenTaiSan"]), Convert.ToString(dr_01["QLP_TenPhong"]), Convert.ToString(dr_01["QLP_ToaNha"]), Convert.ToString(dr_01["QLP_DiaDiem"]), Convert.ToString(dr["TSHC_NgayDuaVaoSuDung"]), Convert.ToString(dr["TSHC_ThoiGianBaoHanh"]), Convert.ToString(dr["TSHC_GhiChu"]));

                            dr.Close();
                            dr_01.Close();
                        }
                        bandedGridView_ThucHienCongViec.MoveNext();
                    }

                    for (int i = 1; i < demsodong; i++)
                    {
                        if (NguoiThucHien[i] != NguoiThucHien[i - 1])
                        {
                            KTNhanSu = false;
                            break;
                        }
                    }

                }

                if (!KTNhanSu)
                {
                    MessageBox.Show("Nhân sự thực hiện của các tài sản được chọn không khớp nhau!!!", "Thông báo");
                }
                else
                {

                    XtraReport_BaoHanh rpt = new XtraReport_BaoHanh(Public,"BẢO HÀNH");
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

                    //MessageBox.Show(sumHeight + "");

                    float totalHeight = sumHeight % 2550;
                    //rpt.PageHeight = Convert.ToInt32(totalHeight);
                    if (totalHeight >= 800 && totalHeight < 1350)
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

        private void btnDownloadBienBanSuaChua_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool KTNhanSu = true;
            int demsodong = 0;

            DataTable dt = new DataTable();

            dt.Columns.Add("STT");
            dt.Columns.Add("TSHC_TenTaiSan");
            dt.Columns.Add("QLP_TenPhong");
            dt.Columns.Add("QLP_ToaNha");
            dt.Columns.Add("QLP_DiaDiem");
            dt.Columns.Add("TSHC_NgayDuaVaoSuDung");
            dt.Columns.Add("TSHC_ThoiGianBaoHanh");
            dt.Columns.Add("TSHC_GhiChu");

            bandedGridView_ThucHienCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_ThucHienCongViec.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_Chon)))// == true
                {
                    demsodong++;
                }
                bandedGridView_ThucHienCongViec.MoveNext();
            }

            int[] NguoiThucHien = new int[demsodong];

            if (demsodong == 0)
            {
                MessageBox.Show("Phải chọn ít nhất một công việc để lập biên bản!!!", "Thông báo");
                KTNhanSu = false;
            }
            else
            {
                if (demsodong == 1)
                {
                    KTNhanSu = true;
                    int sodem = 0;
                    bandedGridView_ThucHienCongViec.MoveFirst();
                    for (int i = 0; i < bandedGridView_ThucHienCongViec.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_Chon)))// == true
                        {

                            NguoiThucHien[sodem] = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(QLNS_MaNSTH));

                            sodem++;

                            Public.THCV_Ma = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_Ma));

                            Public_TaiSanHienCo.TSHC_Ma = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(TSHC_Ma));

                            SqlDataReader dr = cls_TaiSanHienCoBLL.TS_TaiSanHienCo_Load_R_Para_File(Public_TaiSanHienCo);
                            dr.Read();

                            Public_QuanLyPhong.QLP_Ma = Convert.ToInt32(dr["QLP_Ma"]);

                            SqlDataReader dr_01 = cls_QuanLyPhongBLL.TS_QuanLyPhong_Load_R_Para_File(Public_QuanLyPhong);
                            dr_01.Read();

                            dt.Rows.Add(sodem, Convert.ToString(dr["TSHC_TenTaiSan"]), Convert.ToString(dr_01["QLP_TenPhong"]), Convert.ToString(dr_01["QLP_ToaNha"]), Convert.ToString(dr_01["QLP_DiaDiem"]), Convert.ToString(dr["TSHC_NgayDuaVaoSuDung"]), Convert.ToString(dr["TSHC_ThoiGianBaoHanh"]), Convert.ToString(dr["TSHC_GhiChu"]));

                            dr.Close();
                            dr_01.Close();
                        }
                        bandedGridView_ThucHienCongViec.MoveNext();
                    }
                }
                else
                {
                    int sodem = 0;
                    bandedGridView_ThucHienCongViec.MoveFirst();
                    for (int i = 0; i < bandedGridView_ThucHienCongViec.RowCount; i++)
                    {
                        if (Convert.ToBoolean(bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_Chon)))// == true
                        {

                            NguoiThucHien[sodem] = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(QLNS_MaNSTH));

                            sodem++;

                            Public.THCV_Ma = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(THCV_Ma));

                            Public_TaiSanHienCo.TSHC_Ma = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(TSHC_Ma));

                            SqlDataReader dr = cls_TaiSanHienCoBLL.TS_TaiSanHienCo_Load_R_Para_File(Public_TaiSanHienCo);
                            dr.Read();

                            Public_QuanLyPhong.QLP_Ma = Convert.ToInt32(dr["QLP_Ma"]);

                            SqlDataReader dr_01 = cls_QuanLyPhongBLL.TS_QuanLyPhong_Load_R_Para_File(Public_QuanLyPhong);
                            dr_01.Read();

                            dt.Rows.Add(sodem, Convert.ToString(dr["TSHC_TenTaiSan"]), Convert.ToString(dr_01["QLP_TenPhong"]), Convert.ToString(dr_01["QLP_ToaNha"]), Convert.ToString(dr_01["QLP_DiaDiem"]), Convert.ToString(dr["TSHC_NgayDuaVaoSuDung"]), Convert.ToString(dr["TSHC_ThoiGianBaoHanh"]), Convert.ToString(dr["TSHC_GhiChu"]));

                            dr.Close();
                            dr_01.Close();
                        }
                        bandedGridView_ThucHienCongViec.MoveNext();
                    }

                    for (int i = 1; i < demsodong; i++)
                    {
                        if (NguoiThucHien[i] != NguoiThucHien[i - 1])
                        {
                            KTNhanSu = false;
                            break;
                        }
                    }

                }

                if (!KTNhanSu)
                {
                    MessageBox.Show("Nhân sự thực hiện của các tài sản được chọn không khớp nhau!!!", "Thông báo");
                }
                else
                {

                    XtraReport_BaoHanh rpt = new XtraReport_BaoHanh(Public, "SỬA CHỮA");
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
                    if (totalHeight >= 800 && totalHeight < 1350)
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


        #region Cho phép thực hiện thao tác CLICK phải chuột

        void Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_ThucHienCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_ThucHienCongViec.RowCount; i++)
            {
                bandedGridView_ThucHienCongViec.SetFocusedRowCellValue(THCV_Chon, true);
                bandedGridView_ThucHienCongViec.MoveNext();
            }
            bandedGridView_ThucHienCongViec.MoveFirst();
        }

        void No_Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_ThucHienCongViec.MoveFirst();
            for (int i = 0; i < bandedGridView_ThucHienCongViec.RowCount; i++)
            {
                bandedGridView_ThucHienCongViec.SetFocusedRowCellValue(THCV_Chon, false);
                bandedGridView_ThucHienCongViec.MoveNext();
            }
            bandedGridView_ThucHienCongViec.MoveFirst();
        }


        private void bandedGridView_ThucHienCongViec_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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