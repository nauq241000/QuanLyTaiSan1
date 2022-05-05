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
using System.IO;
using Public;
using MessagingToolkit.QRCode.Codec;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;

namespace QuanLyTaiSan
{
    public partial class frmQLTS_TSHC_ChonTaiSanHienCo : DevExpress.XtraEditors.XtraForm
    {
        public frmQLTS_TSHC_ChonTaiSanHienCo()
        {
            InitializeComponent();
            new MultiSelectionEditingHelper(bandedGridView_TaiSanMuaSam);
        }

        TaiSanMuaSamBLL cls = new TaiSanMuaSamBLL();
        TaiSanMuaSamPublic Public = new TaiSanMuaSamPublic();

        QuanLyPhongBLL cls_QuanLyPhongBLL = new QuanLyPhongBLL();
        TaiSanHienCoBLL cls_TaiSanHienCoBLL = new TaiSanHienCoBLL();

        TaiSanHienCoBLL cls_TaiSanHienCo = new TaiSanHienCoBLL();
        TaiSanHienCoPublic Public_TaiSanHienCo = new TaiSanHienCoPublic();

        DataTable dt;

        private bool KiemTra_NhapDuLieu()
        {
            bandedGridView_TaiSanMuaSam.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanMuaSam.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_Chon)) &&
                        (
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(YC_Ma))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(NTS_Ma))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_LoaiTaiSan))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_TenTaiSan))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_BoPhanQuanLy))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_PhongHienTai))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_TenNhanSuQuanLy))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_ThoiGianBaoHanh))) ||
                            string.IsNullOrWhiteSpace(Convert.ToString(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(QLFHD_Ma)))
                        )
                    )
                {
                    return false;
                }
                bandedGridView_TaiSanMuaSam.MoveNext();
            }
            return true;
        }

        private bool KiemTra()
        {
            bandedGridView_TaiSanMuaSam.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanMuaSam.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_Chon)))
                {
                    return true;
                }
                bandedGridView_TaiSanMuaSam.MoveNext();
            }
            return false;
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

        private void LoadDataCombobox()
        {
            repositoryItemComboBox_TSYC_LoaiTaiSan.Items.Clear();
            SqlDataReader dr_01 = LoadHamDungChung.TS_CBB_TSYC_LoaiTaiSan_Load();
            while (dr_01.Read())
            {
                repositoryItemComboBox_TSYC_LoaiTaiSan.Items.Add(Convert.ToString(dr_01["TSYC_LoaiTaiSan"]));
            }
            dr_01.Dispose();
            dr_01.Close();

            repositoryItemComboBox_TSYC_ThuongHieu.Items.Clear();
            SqlDataReader dr_02 = LoadHamDungChung.TS_CBB_TSYC_ThuongHieu_Load();
            while (dr_02.Read())
            {
                repositoryItemComboBox_TSYC_ThuongHieu.Items.Add(Convert.ToString(dr_02["TSYC_ThuongHieu"]));
            }
            dr_02.Dispose();
            dr_02.Close();

            repositoryItemComboBox_TSYC_XuatXu.Items.Clear();
            SqlDataReader dr_03 = LoadHamDungChung.TS_CBB_TSYC_XuatXu_Load();
            while (dr_03.Read())
            {
                repositoryItemComboBox_TSYC_XuatXu.Items.Add(Convert.ToString(dr_03["TSYC_XuatXu"]));
            }
            dr_03.Dispose();
            dr_03.Close();

            repositoryItemComboBox_TSMS_BoPhanQuanLy.Items.Clear();
            SqlDataReader dr_04 = LoadHamDungChung.TS_CBB_TSMS_BoPhanQuanLy_Load();
            while (dr_04.Read())
            {
                repositoryItemComboBox_TSMS_BoPhanQuanLy.Items.Add(Convert.ToString(dr_04["TSHC_BoPhanQuanLy"]));
            }
            dr_04.Dispose();
            dr_04.Close();
        }


        private void frmQLTS_TSHC_ChonTaiSanHienCo_Load(object sender, EventArgs e)
        {
            repositoryItemLookUpEdit_TSMS_TenNhanSu.DataSource = cls_QuanLyPhongBLL.TS_QuanLyPhong_NhanSu_Load();
            repositoryItemLookUpEdit_TSMS_TenNhanSu.DisplayMember = "QLNS_HoTen";
            repositoryItemLookUpEdit_TSMS_TenNhanSu.ValueMember = "QLNS_Ma";

            repositoryItemLookUpEdit_TSMS_TenNhanSu.PopupWidth = 1000;
            repositoryItemLookUpEdit_TSMS_TenNhanSu.ShowFooter = false;
            repositoryItemLookUpEdit_TSMS_TenNhanSu.Columns.Clear();
            repositoryItemLookUpEdit_TSMS_TenNhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_Ma", "Mã", 100));
            repositoryItemLookUpEdit_TSMS_TenNhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLDV_TenDonVi", "Tên đơn vị", 200));
            repositoryItemLookUpEdit_TSMS_TenNhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_CoSo", "Cơ sở", 100));
            repositoryItemLookUpEdit_TSMS_TenNhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_MaNhanSu", "Mã nhân sự", 100));
            repositoryItemLookUpEdit_TSMS_TenNhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_HoTen", "Họ tên", 200));
            repositoryItemLookUpEdit_TSMS_TenNhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_ChucVu", "Chức vụ", 100));
            repositoryItemLookUpEdit_TSMS_TenNhanSu.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_SoDienThoai", "Số điện thoại", 200));


            repositoryItemLookUpEdit_TSMS_PhongHienTai.DataSource = cls_TaiSanHienCoBLL.TS_TSHC_QuanLyPhong_Load();
            repositoryItemLookUpEdit_TSMS_PhongHienTai.DisplayMember = "QLP_TenPhong";
            repositoryItemLookUpEdit_TSMS_PhongHienTai.ValueMember = "QLP_Ma";

            repositoryItemLookUpEdit_TSMS_PhongHienTai.PopupWidth = 1000;
            repositoryItemLookUpEdit_TSMS_PhongHienTai.ShowFooter = false;
            repositoryItemLookUpEdit_TSMS_PhongHienTai.Columns.Clear();
            repositoryItemLookUpEdit_TSMS_PhongHienTai.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_Ma", "Mã", 100));
            repositoryItemLookUpEdit_TSMS_PhongHienTai.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_LoaiPhong", "Loại phòng", 100));
            repositoryItemLookUpEdit_TSMS_PhongHienTai.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_CoSo", "Cơ sở", 200));
            repositoryItemLookUpEdit_TSMS_PhongHienTai.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_DiaDiem", "Địa điểm", 100));
            repositoryItemLookUpEdit_TSMS_PhongHienTai.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_ToaNha", "Toà nhà", 200));
            repositoryItemLookUpEdit_TSMS_PhongHienTai.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_MaPhong", "Mã phòng", 100));
            repositoryItemLookUpEdit_TSMS_PhongHienTai.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_TenPhong", "Tên phòng", 200));

            repositoryItemLookUpEdit_MaNhomThietBiDiKem.DataSource = cls_TaiSanHienCo.TS_TaiSanHienCo_Load();
            repositoryItemLookUpEdit_MaNhomThietBiDiKem.DisplayMember = "TSHC_Ma";
            repositoryItemLookUpEdit_MaNhomThietBiDiKem.ValueMember = "TSHC_Ma";

            repositoryItemLookUpEdit_MaNhomThietBiDiKem.PopupWidth = 400;
            repositoryItemLookUpEdit_MaNhomThietBiDiKem.ShowFooter = false;
            repositoryItemLookUpEdit_MaNhomThietBiDiKem.Columns.Clear();
            repositoryItemLookUpEdit_MaNhomThietBiDiKem.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TSHC_Ma", "Mã", 100));
            repositoryItemLookUpEdit_MaNhomThietBiDiKem.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TSHC_TenTaiSan", "Tên tài sản", 100));
            repositoryItemLookUpEdit_MaNhomThietBiDiKem.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TSHC_LoaiTaiSan", "Loại tài sản", 200));

            repositoryItemLookUpEdit_QLFHD_Ma.DataSource = cls_TaiSanHienCo.TS_TSHC_QuanLyFileHopDong_Load();
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

            dt = cls.TS_ChonTaiSanMuaSam_Load();

            LoadDataCombobox();
            gridControl_TaiSanMuaSam.DataSource = cls.TS_ChonTaiSanMuaSam_Load();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            Public_TaiSanHienCo.HT_UserCreate = Public.HT_UserCreate = BienToanCuc.HT_USER_ID;
            //Public.TSYC_DateCreate =
            Public_TaiSanHienCo.HT_UserEditor = Public.HT_UserEditor = BienToanCuc.HT_USER_ID;
            //Public.TSYC_DateEditor =

            Public_TaiSanHienCo.TSHC_HienThi = true;
            Public_TaiSanHienCo.TSHC_SuDung = BienToanCuc.HT_PB_Ten;

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

            bandedGridView_TaiSanMuaSam.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanMuaSam.RowCount; i++)
            {
                if (Convert.ToBoolean(bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_Chon))) // == true
                {
                    Public.TSMS_Ma = int.Parse("0" + bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_Ma));
                    Public.TSMS_SoLuong = int.Parse("0" + bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_SoLuong));
                    Public_TaiSanHienCo.NTS_Ma = int.Parse("0" + bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(NTS_Ma));
                    Public_TaiSanHienCo.TSHC_LoaiTaiSan = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_LoaiTaiSan);
                    Public_TaiSanHienCo.TSHC_TenTaiSan = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_TenTaiSan);
                    Public_TaiSanHienCo.TSHC_MoTa = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_Mota);
                    Public_TaiSanHienCo.TSHC_ThuongHieu = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_ThuongHieu);
                    Public_TaiSanHienCo.TSHC_XuatXu = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_XuatXu);
                    Public_TaiSanHienCo.TSHC_KichThuocDai = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_KichThuoc_Dai);
                    Public_TaiSanHienCo.TSHC_KichThuocRong = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_KichThuoc_Rong);
                    Public_TaiSanHienCo.TSHC_KichThuocCao = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_KichThuoc_Cao);

                    if (bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_AnhChupTaiSan).GetType().ToString() == "System.DBNull")
                        Public_TaiSanHienCo.TSHC_AnhChup = null;
                    else
                        Public_TaiSanHienCo.TSHC_AnhChup = (byte[])bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_AnhChupTaiSan);

                    Public_TaiSanHienCo.TSHC_GhiChu = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_GhiChu);
                    Public_TaiSanHienCo.TSHC_BoPhanQuanLy = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_BoPhanQuanLy);
                    Public_TaiSanHienCo.TSHC_MaNhomThietBiDiKem = bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_MaNhomThietBiDiKem);
                    Public_TaiSanHienCo.QLP_Ma = int.Parse("0" + bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_PhongHienTai));
                    Public_TaiSanHienCo.QLNS_MaNSQL = int.Parse("0" + bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_TenNhanSuQuanLy));
                    Public_TaiSanHienCo.QLNS_MaNSSD = int.Parse("0" + bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_TenNhanSuSuDung));

                    if (bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_NgayBanGiao).ToString() == "")
                        Public_TaiSanHienCo.TSHC_NgayBanGiao = null;
                    else
                        Public_TaiSanHienCo.TSHC_NgayBanGiao = Convert.ToDateTime(bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(TSMS_NgayBanGiao));

                    Public_TaiSanHienCo.TSHC_ThoiGianBaoHanh = int.Parse("0" + bandedGridView_TaiSanMuaSam.GetFocusedRowCellValue(TSMS_ThoiGianBaoHanh));


                    Public_TaiSanHienCo.QLFHD_Ma = int.Parse("0" + bandedGridView_TaiSanMuaSam.GetFocusedRowCellDisplayText(QLFHD_Ma));


                    Public_TaiSanHienCo.TSHC_NguonGocTaiSan = "Mua mới";
                    Public_TaiSanHienCo.TSHC_TinhTrang = "Hoạt động";

                    Public_TaiSanHienCo.TSHC_QR_Code = null;
                    Public_TaiSanHienCo.TSHC_NamSanXuat = 0;
                    Public_TaiSanHienCo.TSHC_SoSeri = "";
                    Public_TaiSanHienCo.TSHC_TenFileGiayToKemTheo = null;
                    Public_TaiSanHienCo.TSHC_DataFileGiayToKemTheo = null;

                    if(Convert.ToInt32(dt.Rows[i][15].ToString()) < Public.TSMS_SoLuong)
                    {
                        MessageBox.Show("Không được phép nhập số lượng quá " + dt.Rows[i][15].ToString() + " !!!", "Thông báo!!!");
                    }
                    else
                    {
                        for (int so = 0; so < Public.TSMS_SoLuong; so++)
                        {
                            int kqthem = cls_TaiSanHienCoBLL.TS_TaiSanHienCo_Them(Public_TaiSanHienCo);
                        }

                        if (dt.Rows[i][15].ToString() == Public.TSMS_SoLuong.ToString())
                        {
                            int kqxoa = cls.TS_TaiSanMuaSam_Xoa(Public);
                        }
                        else
                        {
                            Public.TSMS_ThanhTien = Public.TSMS_DonGia * Public.TSMS_SoLuong;
                            Public.TSMS_SoLuong = Convert.ToInt32(dt.Rows[i][15].ToString()) - Public.TSMS_SoLuong;
                            int kqsua = cls.TS_TaiSanMuaSam_SuaSoLuong(Public);
                        }
                    }
                }
                bandedGridView_TaiSanMuaSam.MoveNext();
            }
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Cho phép thực hiện thao tác CLICK phải chuột

        void Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_TaiSanMuaSam.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanMuaSam.RowCount; i++)
            {
                bandedGridView_TaiSanMuaSam.SetFocusedRowCellValue(TSMS_Chon, true);
                bandedGridView_TaiSanMuaSam.MoveNext();
            }
            bandedGridView_TaiSanMuaSam.MoveFirst();
        }

        void No_Check_All_Click(object sender, EventArgs e)
        {
            bandedGridView_TaiSanMuaSam.MoveFirst();
            for (int i = 0; i < bandedGridView_TaiSanMuaSam.RowCount; i++)
            {
                bandedGridView_TaiSanMuaSam.SetFocusedRowCellValue(TSMS_Chon, false);
                bandedGridView_TaiSanMuaSam.MoveNext();
            }
            bandedGridView_TaiSanMuaSam.MoveFirst();
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