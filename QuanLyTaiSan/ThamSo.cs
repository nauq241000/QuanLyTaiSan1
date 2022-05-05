using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using DevExpress.XtraPrinting;
using DevExpress.LookAndFeel;
using BLL;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using MaHoaGiaiMaConnectionString;

namespace QuanLyTaiSan
{
    class ThamSo
    {
    }

    #region Load form main
    public static class LoadMain
    {
        //public static int STT = 001;

        #region Quy trình Quản lý hệ thống

        static frmQLTS_TaiSanYeuCau f_frmTaiSanYeuCau = null;
        public static void HienThi_frmTaiSanYeuCau()
        {
            if (f_frmTaiSanYeuCau == null || f_frmTaiSanYeuCau.IsDisposed)
            {
                f_frmTaiSanYeuCau = new frmQLTS_TaiSanYeuCau();
                f_frmTaiSanYeuCau.MdiParent = frmMain.ActiveForm;
                f_frmTaiSanYeuCau.Show();
            }
            else
                f_frmTaiSanYeuCau.Activate();
        }

        static frmQLTS_YeuCau f_frmYeuCau = null;
        public static void HienThi_frmYeuCau()
        {
            if (f_frmYeuCau == null || f_frmYeuCau.IsDisposed)
            {
                f_frmYeuCau = new frmQLTS_YeuCau();
                f_frmYeuCau.MdiParent = frmMain.ActiveForm;
                f_frmYeuCau.Show();
            }
            else
                f_frmYeuCau.Activate();
        }

        static frmQLTS_NhomTaiSan f_frmNhomTaiSan = null;
        public static void HienThi_frmNhomTaiSan()
        {
            if (f_frmNhomTaiSan == null || f_frmNhomTaiSan.IsDisposed)
            {
                f_frmNhomTaiSan = new frmQLTS_NhomTaiSan();
                f_frmNhomTaiSan.MdiParent = frmMain.ActiveForm;
                f_frmNhomTaiSan.Show();
            }
            else
                f_frmNhomTaiSan.Activate();
        }

        static frmQLTS_TaiSanMuaSam f_frmTaiSanMuaSam = null;
        public static void HienThi_frmTaiSanMuaSam()
        {
            if (f_frmTaiSanMuaSam == null || f_frmTaiSanMuaSam.IsDisposed)
            {
                f_frmTaiSanMuaSam = new frmQLTS_TaiSanMuaSam();
                f_frmTaiSanMuaSam.MdiParent = frmMain.ActiveForm;
                f_frmTaiSanMuaSam.Show();
            }
            else
                f_frmTaiSanMuaSam.Activate();
        }

        static frmQLTS_QuanLyNhanSu f_frmQuanLyNhanSu = null;
        public static void HienThi_frmQuanLyNhanSu()
        {
            if (f_frmQuanLyNhanSu == null || f_frmQuanLyNhanSu.IsDisposed)
            {
                f_frmQuanLyNhanSu = new frmQLTS_QuanLyNhanSu();
                f_frmQuanLyNhanSu.MdiParent = frmMain.ActiveForm;
                f_frmQuanLyNhanSu.Show();
            }
            else
                f_frmQuanLyNhanSu.Activate();
        }

        static frmQLTS_QuanLyDonVi f_frmQuanLyDonVi = null;
        public static void HienThi_frmQuanLyDonVi()
        {
            if (f_frmQuanLyDonVi == null || f_frmQuanLyDonVi.IsDisposed)
            {
                f_frmQuanLyDonVi = new frmQLTS_QuanLyDonVi();
                f_frmQuanLyDonVi.MdiParent = frmMain.ActiveForm;
                f_frmQuanLyDonVi.Show();
            }
            else
                f_frmQuanLyDonVi.Activate();
        }

        static frmQLTS_QuanLyPhong f_frmQuanLyPhong = null;
        public static void HienThi_frmQuanLyPhong()
        {
            if (f_frmQuanLyPhong == null || f_frmQuanLyPhong.IsDisposed)
            {
                f_frmQuanLyPhong = new frmQLTS_QuanLyPhong();
                f_frmQuanLyPhong.MdiParent = frmMain.ActiveForm;
                f_frmQuanLyPhong.Show();
            }
            else
                f_frmQuanLyPhong.Activate();
        }

        static frmQLTS_TaiSanHienCo f_frmTaiSanHienCo = null;
        public static void HienThi_frmTaiSanHienCo()
        {
            if (f_frmTaiSanHienCo == null || f_frmTaiSanHienCo.IsDisposed)
            {
                f_frmTaiSanHienCo = new frmQLTS_TaiSanHienCo();
                f_frmTaiSanHienCo.MdiParent = frmMain.ActiveForm;
                f_frmTaiSanHienCo.Show();
            }
            else
                f_frmTaiSanHienCo.Activate();
        }

        static frmQLTS_QuanLyFileHopDong f_frmQuanLyFileHopDong = null;
        public static void HienThi_frmQuanLyFileHopDong()
        {
            if (f_frmQuanLyFileHopDong == null || f_frmQuanLyFileHopDong.IsDisposed)
            {
                f_frmQuanLyFileHopDong = new frmQLTS_QuanLyFileHopDong();
                f_frmQuanLyFileHopDong.MdiParent = frmMain.ActiveForm;
                f_frmQuanLyFileHopDong.Show();
            }
            else
                f_frmQuanLyFileHopDong.Activate();
        }

        static frmQLTS_LichSuBanGiao f_frmLichSuBanGiao = null;
        public static void HienThi_frmQLTS_LichSuBanGiao()
        {
            if (f_frmLichSuBanGiao == null || f_frmLichSuBanGiao.IsDisposed)
            {
                f_frmLichSuBanGiao = new frmQLTS_LichSuBanGiao();
                f_frmLichSuBanGiao.MdiParent = frmMain.ActiveForm;
                f_frmLichSuBanGiao.Show();
            }
            else
                f_frmLichSuBanGiao.Activate();
        }

        static frmPCCV_DanhMucCongViec f_frmDanhMucCongViec = null;
        public static void HienThi_frmPCCV_DanhMucCongViec()
        {
            if (f_frmDanhMucCongViec == null || f_frmDanhMucCongViec.IsDisposed)
            {
                f_frmDanhMucCongViec = new frmPCCV_DanhMucCongViec();
                f_frmDanhMucCongViec.MdiParent = frmMain.ActiveForm;
                f_frmDanhMucCongViec.Show();
            }
            else
                f_frmDanhMucCongViec.Activate();
        }

        static frmMaHoaGiaiMa f_frmMaHoaGiaiMa = null;
        public static void HienThi_frmMaHoaGiaiMa()
        {
            if (f_frmMaHoaGiaiMa == null || f_frmMaHoaGiaiMa.IsDisposed)
            {
                f_frmMaHoaGiaiMa = new frmMaHoaGiaiMa();
                f_frmMaHoaGiaiMa.MdiParent = frmMain.ActiveForm;
                f_frmMaHoaGiaiMa.Show();
            }
            else
                f_frmMaHoaGiaiMa.Activate();
        }

        static frmPCCV_ThucHienCongViec f_frmPCCV_ThucHienCongViec = null;
        public static void HienThi_frmPCCV_ThucHienCongViec()
        {
            if (f_frmPCCV_ThucHienCongViec == null || f_frmPCCV_ThucHienCongViec.IsDisposed)
            {
                f_frmPCCV_ThucHienCongViec = new frmPCCV_ThucHienCongViec();
                f_frmPCCV_ThucHienCongViec.MdiParent = frmMain.ActiveForm;
                f_frmPCCV_ThucHienCongViec.Show();
            }
            else
                f_frmPCCV_ThucHienCongViec.Activate();
        }

        static frmPCCV_PhanCongCongViec f_frmPCCV_PhanCongCongViec = null;
        public static void HienThi_frmPCCV_PhanCongCongViec()
        {
            if (f_frmPCCV_PhanCongCongViec == null || f_frmPCCV_PhanCongCongViec.IsDisposed)
            {
                f_frmPCCV_PhanCongCongViec = new frmPCCV_PhanCongCongViec();
                f_frmPCCV_PhanCongCongViec.MdiParent = frmMain.ActiveForm;
                f_frmPCCV_PhanCongCongViec.Show();
            }
            else
                f_frmPCCV_PhanCongCongViec.Activate();
        }

        static frmBHSC_QuanLyFileHoSoThanhToan f_frmBHSC_QuanLyFileHoSoThanhToan = null;
        public static void HienThi_frmBHSC_QuanLyFileHoSoThanhToan()
        {
            if (f_frmBHSC_QuanLyFileHoSoThanhToan == null || f_frmBHSC_QuanLyFileHoSoThanhToan.IsDisposed)
            {
                f_frmBHSC_QuanLyFileHoSoThanhToan = new frmBHSC_QuanLyFileHoSoThanhToan();
                f_frmBHSC_QuanLyFileHoSoThanhToan.MdiParent = frmMain.ActiveForm;
                f_frmBHSC_QuanLyFileHoSoThanhToan.Show();
            }
            else
                f_frmBHSC_QuanLyFileHoSoThanhToan.Activate();
        }

        


        #endregion

    }
    #endregion

    #region BienToanCuc
    public class BienToanCuc
    {
        //Khóa nhập dữ liệu chính xác
        //1. Nếu đặt == true => Kích thoạt chức năng (BienToanCuc.Lock_NhapDuLieu = true)
        //2. Nếu đặt == false => Không kích hoạt
        public static bool Lock_NhapDuLieu = true;

        //địa chỉ host gửi email
        public static string CHECK_INTERNET = "google.com.vn";

        public static DateTime Time_Server; //Ngày lấy từ server
        public static DateTime Time_Server_KichHoatDT; //Ngày lấy từ server
        public static string HT_CQ_Ten; //Tên cơ quan của người đăng nhập
        public static int HT_PB_ID; //ID phòng ban của người đăng nhập
        public static string HT_PB_Ten = "a"; //Tên phòng ban của người đăng nhập
        public static string HT_PQDL_PB_Ten; //Tên của các phòng ban được phân quyền dữ liệu
        public static string HoTenNguoiDung; //Họ tên đầy đủ người đăng nhập
        public static string SentEmail_HoTen; //Họ tên của người đăng nhập (HT_USER_Ten)
        public static string SentEmail_DienThoai; //Điện thoại của người đăng nhập (HT_USER_DienThoai)
        public static string SentEmail_Email; //Email của người đăng nhập (HT_USER_Email)
        public static string MaNguoiDung; //Tên đăng nhập
        public static int HT_USER_ID; //ID người đăng nhập        

    }
    #endregion

    #region Load Hàm dùng chung
    public static class LoadHamDungChung
    {
        #region In dữ liệu trên lưới
        public static void PreviewPrintableComponent(IPrintable component, UserLookAndFeel lookAndFeel)
        {
            // Create a link that will print a control.            
            PrintableComponentLink link = new PrintableComponentLink()
            {
                PrintingSystemBase = new PrintingSystemBase(),
                Component = component,
                Landscape = true
                //Margins = new Mar
                //PaperKind = PaperKind.A5,
                //Margins = new Margins(20, 20, 20, 20)
            };

            // Show the report. 
            link.Margins.Bottom = 20;
            link.Margins.Top = 20;
            link.Margins.Left = 20;
            link.Margins.Right = 20;
            link.Landscape = true;
            link.PaperKind = System.Drawing.Printing.PaperKind.A4;

            link.ShowPreview(lookAndFeel);
            //link.ShowRibbonPreview(lookAndFeel);
        }
        #endregion

        static QuanLyNhanSuBLL cls_QuanLyNhanSuBLL = new QuanLyNhanSuBLL();
        static TaiSanYeuCauBLL cls_TaiSanYeuCauBLL = new TaiSanYeuCauBLL();
        static TaiSanHienCoBLL cls_TaiSanHienCoBLL = new TaiSanHienCoBLL();
        static QuanLyPhongBLL cls_QuanLyPhongBLL = new QuanLyPhongBLL();
        static TaiSanMuaSamBLL cls_TaiSanMuaSamBLL = new TaiSanMuaSamBLL();
        static DanhMucCongViecBLL cls_DanhMucCongViecBLL = new DanhMucCongViecBLL();

        #region LoadCombobox

        public static SqlDataReader TS_CBB_TSYC_XuatXu_Load()
        {
            return cls_TaiSanYeuCauBLL.TS_CBB_TSYC_XuatXu_Load();
        }

        public static SqlDataReader TS_CBB_TSYC_ThuongHieu_Load()
        {
            return cls_TaiSanYeuCauBLL.TS_CBB_TSYC_ThuongHieu_Load();
        }

        public static SqlDataReader TS_CBB_QLP_LoaiPhong_Load()
        {
            return cls_QuanLyPhongBLL.TS_CBB_QLP_LoaiPhong_Load();
        }

        public static SqlDataReader TS_CBB_TSHC_BoPhanQuanLy_Load()
        {
            return cls_TaiSanHienCoBLL.TS_CBB_TSHC_BoPhanQuanLy_Load();
        }

        public static SqlDataReader TS_CBB_TSHC_ThuongHieu_Load()
        {
            return cls_TaiSanHienCoBLL.TS_CBB_TSHC_ThuongHieu_Load();
        }

        public static SqlDataReader TS_CBB_TSHC_XuatXu_Load()
        {
            return cls_TaiSanHienCoBLL.TS_CBB_TSHC_XuatXu_Load();
        }

        public static SqlDataReader TS_CBB_TSYC_LoaiTaiSan_Load()
        {
            return cls_TaiSanYeuCauBLL.TS_CBB_TSYC_LoaiTaiSan_Load();
        }

        public static SqlDataReader TS_CBB_TSMS_BoPhanQuanLy_Load()
        {
            return cls_TaiSanMuaSamBLL.TS_CBB_TSMS_BoPhanQuanLy_Load();
        }

        public static SqlDataReader PC_CBB_DMCV_LoaiCongViec_Load()
        {
            return cls_DanhMucCongViecBLL.PC_CBB_DMCV_LoaiCongViec_Load();
        }

        public static SqlDataReader PC_CBB_DMCV_NhomCongViec_Load()
        {
            return cls_DanhMucCongViecBLL.PC_CBB_DMCV_NhomCongViec_Load();
        }





        #endregion

        #region kiểm tra sự tồn tại của địa chỉ
        //Kiểm tra sự tồn tại của HOST gửi email
        public static bool isAddressAvailable_LoadDungChung(string address)
        {
            Ping ping = new Ping();
            try
            {
                //return ping.Send(address, 100).Status == IPStatus.Success;
                return ping.Send(address, 10000).Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }
        #endregion


    }
    #endregion

    #region Load lớp cho phép chỉnh sửa nhiều dòng, ô trên lưới
    public class MultiSelectionEditingHelper
    {
        private GridView _View;
        public MultiSelectionEditingHelper(GridView view)
        {
            _View = view;
            _View.OptionsBehavior.EditorShowMode = EditorShowMode.MouseDownFocused;
            _View.MouseUp += _View_MouseUp;
            _View.CellValueChanged += new CellValueChangedEventHandler(_View_CellValueChanged);
            _View.MouseDown += new MouseEventHandler(_View_MouseDown);
        }

        void _View_MouseDown(object sender, MouseEventArgs e)
        {
            if (GetInSelectedCell(e))
            {
                GridHitInfo hi = _View.CalcHitInfo(e.Location);
                if (_View.FocusedRowHandle == hi.RowHandle)
                {
                    _View.FocusedColumn = hi.Column;
                    DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }

        void _View_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            OnCellValueChanged(e);
        }

        bool lockEvents;
        private void OnCellValueChanged(CellValueChangedEventArgs e)
        {
            if (lockEvents)
                return;
            lockEvents = true;
            SetSelectedCellsValues(e.Value);
            lockEvents = false;
        }

        private void SetSelectedCellsValues(object value)
        {
            try
            {
                _View.BeginUpdate();
                GridCell[] cells = _View.GetSelectedCells();
                foreach (GridCell cell in cells)
                {
                    _View.SetRowCellValue(cell.RowHandle, cell.Column, value);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _View.EndUpdate();
            }

        }
        private bool GetInSelectedCell(MouseEventArgs e)
        {
            GridHitInfo hi = _View.CalcHitInfo(e.Location);
            return hi.InRowCell && hi.InRowCell && _View.IsCellSelected(hi.RowHandle, hi.Column);
        }

        void _View_MouseUp(object sender, MouseEventArgs e)
        {
            bool inSelectedCell = GetInSelectedCell(e);
            if (inSelectedCell)
            {
                DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                _View.ShowEditorByMouse();
            }
        }
    }
    #endregion
}