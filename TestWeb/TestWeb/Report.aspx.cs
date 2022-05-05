using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Public;
using BLL;
using System.Data.SqlClient;

namespace TestWeb
{
    public partial class Report : System.Web.UI.Page
    {

        string ID = "";
        string US = "";

        TaiSanHienCoBLL cls = new TaiSanHienCoBLL();
        TaiSanHienCoPublic Public = new TaiSanHienCoPublic();

        QuanLyNhanSuBLL cls_QuanLyNhanSuBLL = new QuanLyNhanSuBLL();
        QuanLyNhanSuPublic Public_QuanLyNhanSu = new QuanLyNhanSuPublic();

        QuanLyDonViBLL cls_QuanLyDonViBLL = new QuanLyDonViBLL();
        QuanLyDonViPublic Public_QuanLyDonVi = new QuanLyDonViPublic();

        QuanLyPhongBLL cls_QuanLyPhongBLL = new QuanLyPhongBLL();
        QuanLyPhongPublic Public_QuanLyPhong = new QuanLyPhongPublic();

        ThucHienCongViecBLL cls_ThucHienCongViecBLL = new ThucHienCongViecBLL();
        ThucHienCongViecPublic Public_ThucHienCongViec = new ThucHienCongViecPublic();

        protected void Page_Load(object sender, EventArgs e)
        {
            ID = Request.QueryString["ID"];
            US = Request.QueryString["US"];

            LoadData();

            btnGuiYeuCau.Enabled = btnHuy.Enabled = false;

        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Report.aspx?ID=" + ID + "&US=" + US);
        }

        public void LoadData()
        {
            Public.TSHC_Ma = Convert.ToInt32(ID);

            cbDiaDiem.DataSource = cls_QuanLyPhongBLL.TS_QuanLyPhongASP_Load();
            cbDiaDiem.DataBind();
            cbDiaDiem.TextField = "QLP_CoSo";
            cbDiaDiem.ValueField = "QLP_Ma";

            cbMaNhanSu.DataSource = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSuASP_Load();
            cbMaNhanSu.DataBind();
            cbMaNhanSu.TextField = "QLNS_Ma";
            cbMaNhanSu.ValueField = "QLNS_Ma";
        }

        protected void btnKiemtra_Click(object sender, EventArgs e)
        {
            Public_QuanLyPhong.QLP_Ma = Convert.ToInt32(cbDiaDiem.Value);

            SqlDataReader reader = cls_QuanLyPhongBLL.TS_QuanLyPhong_ASP_Load_R_Para_File(Public_QuanLyPhong);
            while (reader.Read())
            {
                lb_DiaDiem.Text = reader["QLP_DiaDiem"].ToString();
                lb_ToaNha.Text = reader["QLP_ToaNha"].ToString();
                lb_Phong.Text = reader["QLP_TenPhong"].ToString();

            }

            reader.Close();

            Public_QuanLyNhanSu.QLNS_Ma = Convert.ToInt32(cbMaNhanSu.Value);

            reader = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_ASP_Load_R_Para_File(Public_QuanLyNhanSu);
            while (reader.Read())
            {
                lb_HoTen.Text = reader.GetString(3);
                //lb_TenDonVi.Text = reader.GetString(1);
                lb_SoDienThoai.Text = reader.GetString(4);

            }

            reader.Close();

            btnGuiYeuCau.Enabled = btnHuy.Enabled = true;
        }

        protected void btnGuiYeuCau_Click(object sender, EventArgs e)
        {

            try
            {
                Public_ThucHienCongViec.HT_UserCreate = 1;
                //Public.QLP_DateCreate = GetNgayTrongTuan(Convert.ToDateTime(dtNgayBatDau.Text));
                Public_ThucHienCongViec.HT_UserEditor = 1;
                //Public.QLP_DateEditor =

                Public_ThucHienCongViec.THCV_HienThi = true;
                Public_ThucHienCongViec.THCV_SuDung = "";
                Public_ThucHienCongViec.THCV_NgayThucHien = Convert.ToDateTime(dtThoiGianDuKien.Value);
                Public_ThucHienCongViec.THCV_NguonCongViec = "Không theo kế hoạch";
                Public_ThucHienCongViec.THCV_MucDoUuTien = 1;
                Public_ThucHienCongViec.THCV_NgayYeuCau = Convert.ToDateTime(dtThoiGianDuKien.Value);
                Public_ThucHienCongViec.THCV_NgayDeNghiHoanThanh = Convert.ToDateTime(dtThoiGianDuKien.Value);
                Public_ThucHienCongViec.THCV_YeuCau = cbNoiDung.Text;
                Public_ThucHienCongViec.THCV_MoTa = txtMoTa.Text;
                Public_ThucHienCongViec.QLP_Ma = int.Parse("0" + cbDiaDiem.Value);
                Public_ThucHienCongViec.THCV_KetQuaThucHien = "";
                Public_ThucHienCongViec.THCV_GhiChuNguoiThucHien = "";
                Public_ThucHienCongViec.THCV_GhiChu = txtGhiChu.Text;
                //Public_ThucHienCongViec.PCCV_Ma = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(PCCV_Ma));

                //Public_ThucHienCongViec.QLNS_MaNSTH = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellValue(QLNS_MaNSTH));
                Public_ThucHienCongViec.TSHC_Ma = int.Parse("0" + ID);
                Public_ThucHienCongViec.QLNS_MaNSKT = int.Parse("0" + cbMaNhanSu.Text);
                //Public.THCV_MoTaCongViec = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_MoTaCongViec);
                //Public.THCV_TuDanhGia = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_TuDanhGia);
                //Public.THCV_ThoiGianBatDau = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_ThoiGianBatDau);
                //Public.THCV_ThoiGianKetThuc = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_ThoiGianKetThuc);
                //Public.THCV_SoPhut = int.Parse("0" + bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_SoPhut));
                //Public.THCV_DeXuat = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_DeXuat);
                //Public.THCV_DanhGia = bandedGridView_ThucHienCongViec.GetFocusedRowCellDisplayText(THCV_DanhGia);
                Public_ThucHienCongViec.THCV_GhiChuNguoiKiemTra = txtGhiChuHoTro.Text;

                if (cls_ThucHienCongViecBLL.PC_ThucHienCongViec_Them(Public_ThucHienCongViec) > 0)
                {
                    lbThongbao.Text = "Gửi yêu cầu thành công";
                    lbThongbao.Visible = true;
                }
            }
            catch 
            {
                lbThongbao.Text = "Gửi yêu cầu thất bại";
                lbThongbao.Visible = true;
            }
        }
    }
}