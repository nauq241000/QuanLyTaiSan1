using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Public;
using BLL;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Data;

namespace ChiTietCongViec
{
    public partial class Login : System.Web.UI.Page
    {

        NhanSuDangNhapPublic Public = new NhanSuDangNhapPublic();
        NhanSuDangNhapBLL cls = new NhanSuDangNhapBLL();

        ChiTietCongViecBLL cls_ChiTietCongViecBLL = new ChiTietCongViecBLL();
        ChiTietCongViecPublic ChiTietCongViecPublic = new ChiTietCongViecPublic();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (ID != null)
            {
                if (!string.IsNullOrEmpty(txtuser.Text) && !string.IsNullOrEmpty(txtuser.Text))
                {
                    Public.QLNS_MaNhanSu = txtuser.Text;
                    Public.NSDN_MatKhau = toMD5(txtpass.Text);

                    if (cls.CheckLogin(Public) > 0)
                    {
                        try
                        {
                            DataTable dt = cls_ChiTietCongViecBLL.CV_ChiTietCongViec_GetMa(Public.QLNS_MaNhanSu);

                            int MaNhanSu = Convert.ToInt32(dt.Rows[0][0]);

                            if (txtpass.Text == "123")
                                Response.Redirect("/DoiMatKhau.aspx?US=" + txtuser.Text);
                            else
                                Response.Redirect("?US=" + txtuser.Text);
                        }
                        catch 
                        {
                            lbThongbao.Visible = true;
                            lbThongbao.Text = "Nhân sự không tồn tại trong danh sách!!!";
                            lbThongbao.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        lbThongbao.Visible = true;
                        lbThongbao.Text = "Tài khoản hoặc mật khẩu không chính xác!!!";
                        lbThongbao.ForeColor = Color.Red;
                    }
                }
            }
        }

        public static string toMD5(string pass)
        {
            MD5CryptoServiceProvider myMD5 = new MD5CryptoServiceProvider();
            byte[] myPass = System.Text.Encoding.UTF8.GetBytes(pass);
            myPass = myMD5.ComputeHash(myPass);

            StringBuilder s = new StringBuilder();
            foreach (byte p in myPass)
            {
                s.Append(p.ToString("x2").ToLower());
            }
            return s.ToString();
        }
    }
}