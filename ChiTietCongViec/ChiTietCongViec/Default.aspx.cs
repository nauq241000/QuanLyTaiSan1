using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using Public;
using System.Drawing;
using DevExpress.XtraPrinting;

namespace ChiTietCongViec
{
    public partial class Default : System.Web.UI.Page
    {

        ChiTietCongViecBLL cls = new ChiTietCongViecBLL();
        ChiTietCongViecPublic Public = new ChiTietCongViecPublic();

        string US = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            US = Request.QueryString["US"];

            if (US == null)
            {
                Response.Redirect("/Login.aspx");
            }
            else
            {
                LoadCongViec();
            }
        }

        public void LoadCongViec()
        {
            //ASPxPageControl1.TabPages[2].Visible = false;

            DataTable dt = cls.CV_ChiTietCongViec_GetMa(US);

            int MaNhanSu = Convert.ToInt32(dt.Rows[0][0]);

            ASPxGridView_ChiTietCongViec.DataSource = cls.CV_ChiTietCongViec_Load(MaNhanSu);
            ASPxGridView_ChiTietCongViec.DataBind();

            btnLuu.Enabled = btnHuy.Enabled = false;

            lbThongBao.Visible = false;

        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            Response.Redirect("/?US=" + US);
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (ASPxGridView_ChiTietCongViec.GetSelectedFieldValues("THCV_DanhGia")[0].ToString() != "Hoàn thành")
                {
                    lbTHCV_Ma.Text = ASPxGridView_ChiTietCongViec.GetSelectedFieldValues("THCV_Ma")[0].ToString();
                    lbNgayThucHien.Text = ASPxGridView_ChiTietCongViec.GetSelectedFieldValues("THCV_NgayThucHien")[0].ToString();
                    lbTenCongViec.Text = ASPxGridView_ChiTietCongViec.GetSelectedFieldValues("THCV_YeuCau")[0].ToString();
                    lbDiaDiem.Text = ASPxGridView_ChiTietCongViec.GetSelectedFieldValues("QLP_DiaDiem")[0].ToString();
                    lbPhong.Text = ASPxGridView_ChiTietCongViec.GetSelectedFieldValues("QLP_TenPhong")[0].ToString();

                    btnLuu.Enabled = btnHuy.Enabled = true;

                    btnCapNhat.Enabled = false;
                }
                else
                {
                    lbThongBao.Text = "Không thể sửa thông tin công việc đã hoàn thành!!!";
                    lbThongBao.ForeColor = Color.Red;
                    lbThongBao.Visible = true;
                }
            }
            catch { }


        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            Response.Redirect("/?US=" + US);
        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            Public.THCV_Ma = Convert.ToInt32(lbTHCV_Ma.Text);
            Public.THCV_DanhGia = cb_DanhGia.Text;
            Public.THCV_DeXuat = txtDeXuat.Text;
            Public.THCV_SoPhut = Convert.ToInt32(txtTongThoiGian.Text);
            Public.THCV_ThoiGianBatDau = Convert.ToDateTime(dtThoiGianBatDau.Value);
            Public.THCV_ThoiGianKetThuc = Convert.ToDateTime(dtThoiGianKetThuc.Value);
            Public.THCV_KetQuaThucHien = txtKetQuaThucHien.Text;
            Public.THCV_GhiChuNguoiThucHien = txtGhiChu.Text;

            Public.HT_UserEditor = 1;

            if (cls.CV_ChiTietCongViec_Edit(Public) > 0)
            {
                Response.Redirect("/?US=" + US);
            }
            else
            {

            }

        }

        protected void btnExportExcel_Click(object sender, EventArgs e)
        {
            ASPxGridViewExporter1.WriteXlsxToResponse("DanhSachCongViec");
        }
    }
}