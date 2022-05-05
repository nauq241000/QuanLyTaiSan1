using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Public;
using BLL;

namespace TestWeb
{
    public partial class Default : System.Web.UI.Page
    {

        TaiSanHienCoBLL cls = new TaiSanHienCoBLL();
        TaiSanHienCoPublic Public = new TaiSanHienCoPublic();

        QuanLyNhanSuBLL cls_QuanLyNhanSuBLL = new QuanLyNhanSuBLL();
        QuanLyNhanSuPublic Public_QuanLyNhanSu = new QuanLyNhanSuPublic();

        QuanLyDonViBLL cls_QuanLyDonViBLL = new QuanLyDonViBLL();
        QuanLyDonViPublic Public_QuanLyDonVi = new QuanLyDonViPublic();

        QuanLyPhongBLL cls_QuanLyPhongBLL = new QuanLyPhongBLL();
        QuanLyPhongPublic Public_QuanLyPhong = new QuanLyPhongPublic();

        string ID = null;
        string US = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            ID = Request.QueryString["ID"];
            US = Request.QueryString["US"];
            if (ID != null)
            {
                LoadThietBiDiKem();
                LoadData();
            }
            if (US == null)
            {
                ASPxPageControl1.TabPages[3].Visible = false;
                ASPxPageControl1.TabPages[4].Visible = false;
                ASPxPageControl1.TabPages[5].Visible = false;
                btnBaoHong.Visible = false;
            }
            else
            {
                QuanLyNhanSuPublic NSPublic = new QuanLyNhanSuPublic();
                NSPublic.QLNS_Ma = Convert.ToInt32(cls_QuanLyNhanSuBLL.CV_ChiTietCongViec_GetMa(US).Rows[0][0]);
                SqlDataReader reader_01 = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_ASP_Load_R_Para_File(NSPublic);
                while (reader_01.Read())
                {
                    NSPublic.QLNS_ChucVu = reader_01.GetString(5);

                }
                reader_01.Close();

                if (!NSPublic.QLNS_ChucVu.Contains("Quản lý thiết bị"))
                {
                    ASPxPageControl1.TabPages[3].Visible = false;
                    ASPxPageControl1.TabPages[4].Visible = false;
                    ASPxPageControl1.TabPages[5].Visible = false;
                }
                btnDangNhap.Text = "Đăng xuất";
                LoadCBBQuanLyNhanSu();
                LoadCBBQuanLyPhong();
                LoadDataThietBiDiKem();
            }
        }

        public void LoadData()
        {
            Public.TSHC_Ma = Convert.ToInt32(ID);
            lb_MaTS.Text = Public.TSHC_Ma.ToString();

            SqlDataReader reader = cls.TS_TaiSanHienCo_ASP_Load_R_Para_File(Public);
            while (reader.Read())
            {
                lb_TenTS.Text = reader.GetString(6);
                lb_LoaiTS.Text = reader.GetString(5);
                lb_Seri.Text = reader.GetString(18);
                lb_ThuongHieu.Text = reader.GetString(13);
                lb_XuatXu.Text = reader.GetString(17);
                lb_NguonGoc.Text = reader.GetString(12);
                lb_NamSX.Text = reader.GetInt32(14).ToString();
                lb_NgaySD.Text = reader.GetDateTime(15).ToShortDateString();
                lb_HanBaoHanh.Text = reader.GetInt32(22).ToString();
                lb_TinhTrang.Text = reader.GetString(10);

                byte[] bytes;
                try
                {
                    bytes = (byte[])reader.GetValue(25);
                    string strBase64 = Convert.ToBase64String(bytes);
                    img_AnhChupTS.ImageUrl = "data:Image/jpg;base64," + strBase64;
                }
                catch
                {
                    bytes = null;
                }

                Public_QuanLyNhanSu.QLNS_Ma = reader.GetInt32(3);
                Public_QuanLyPhong.QLP_Ma = reader.GetInt32(4);
            }

            reader.Close();

            reader = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_ASP_Load_R_Para_File(Public_QuanLyNhanSu);
            while (reader.Read())
            {
                lb_MaNS.Text = reader.GetString(3);
                //lb_TenDonVi.Text = reader.GetString(1);
                lb_TenNhanSu.Text = reader.GetString(4);
                lb_SDT.Text = reader.GetString(10);
                lb_ChucVu.Text = reader.GetString(5);
                lb_CoSo.Text = reader.GetString(2);

                Public_QuanLyDonVi.QLDV_Ma = reader.GetInt32(1);

            }

            reader.Close();

            reader = cls_QuanLyDonViBLL.TS_QuanLyDonVi_ASP_Load_R_Para_File(Public_QuanLyDonVi);
            while (reader.Read())
            {
                lb_TenDonVi.Text = reader.GetString(2);
            }

            reader.Close();

            reader = cls_QuanLyPhongBLL.TS_QuanLyPhong_ASP_Load_R_Para_File(Public_QuanLyPhong);
            while (reader.Read())
            {
                lb_PhongHienTai.Text = reader.GetString(4);
            }

            reader.Close();
        }

        public void LoadThietBiDiKem()
        {
            //ASPxPageControl1.TabPages[2].Visible = false;

            Public.TSHC_Ma = Convert.ToInt32(ID);

            grv_ThietBiDiKem.DataSource = cls.TS_TSHC_ThietBiDiKem_ASP_Load(Public);
            grv_ThietBiDiKem.DataBind();

        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login.aspx?ID=" + ID);
        }

        public void LoadCBBQuanLyNhanSu()
        {
            cb_MaNSSua.DataSource = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSuASP_Load();
            cb_MaNSSua.DataBind();
        }

        public void LoadCBBQuanLyPhong()
        {
            cb_PhongSua.DataSource = cls_QuanLyPhongBLL.TS_QuanLyPhongASP_Load();
            cb_PhongSua.DataBind();
        }

        protected void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                Public_QuanLyNhanSu.QLNS_Ma = Convert.ToInt32(cb_MaNSSua.Text);
                SqlDataReader reader = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_ASP_Load_R_Para_File(Public_QuanLyNhanSu);

                while (reader.Read())
                {
                    //lb_TenDonVi.Text = reader.GetString(1);
                    lb_HoTenSua.Text = reader.GetString(4);
                    lb_SDTSua.Text = reader.GetString(10);
                    lb_ChucVuSua.Text = reader.GetString(5);
                    lb_CoSoSua.Text = reader.GetString(2);

                    Public_QuanLyDonVi.QLDV_Ma = reader.GetInt32(1);

                }

                reader.Close();

                reader = cls_QuanLyDonViBLL.TS_QuanLyDonVi_ASP_Load_R_Para_File(Public_QuanLyDonVi);
                while (reader.Read())
                {
                    lb_TenDonViSua.Text = reader.GetString(2);
                }
                reader.Close();
            }
            catch 
            { }
        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            Public.QLNS_MaNSSD = Convert.ToInt32(cb_MaNSSua.Value);
            Public.QLP_Ma = Convert.ToInt32(cb_PhongSua.Value);
            Public.HT_UserEditor = 1;

            cls.TS_TaiSanHienCoASP_NSSD_Sua(Public);

            Response.Redirect("/?ID=" + ID + "&US=" + US);
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            Response.Redirect("/?ID=" + ID + "&US=" + US);
        }

        public void LoadDataThietBiDiKem()
        {
            grv_ThietBiDiKem0.DataSource = cls.TS_TSHC_ThietBiDiKemALL_ASP_Load();
            grv_ThietBiDiKem0.DataBind();

            Public.TSHC_Ma = Convert.ToInt32(ID);

            grv_ThietBiDiKem1.DataSource = cls.TS_TSHC_ThietBiDiKem_ASP_Load(Public);
            grv_ThietBiDiKem1.DataBind();
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            List<object> MaTaiSan = new List<object>();
            MaTaiSan = grv_ThietBiDiKem0.GetSelectedFieldValues("TSHC_Ma");

            for (int i = 0; i < MaTaiSan.Count; i++)
            {
                Public.TSHC_Ma = Convert.ToInt32(MaTaiSan[i]);
                Public.TSHC_MaNhomThietBiDiKem = ID;
                Public.HT_UserEditor = 1;

                cls.TS_TaiSanHienCoASP_TBDK_Sua(Public);
            }

            Response.Redirect("/?ID=" + ID + "&US=" + US);
        }

        protected void btnHuyTBDK_Click(object sender, EventArgs e)
        {
            Response.Redirect("/?ID=" + ID + "&US=" + US);
        }

        protected void btnXoaTBDK_Click(object sender, EventArgs e)
        {
            List<object> MaTaiSan = new List<object>();
            MaTaiSan = grv_ThietBiDiKem1.GetSelectedFieldValues("TSHC_Ma");

            for (int i = 0; i < MaTaiSan.Count; i++)
            {
                Public.TSHC_Ma = Convert.ToInt32(MaTaiSan[i]);
                Public.TSHC_MaNhomThietBiDiKem = "";
                Public.HT_UserEditor = 1;

                cls.TS_TaiSanHienCoASP_TBDK_Sua(Public);
            }

            Response.Redirect("/?ID=" + ID + "&US=" + US);
        }

        protected void btnBaoHong_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Report.aspx?ID=" + ID + "&US=" + US);
        }

       
    }
}