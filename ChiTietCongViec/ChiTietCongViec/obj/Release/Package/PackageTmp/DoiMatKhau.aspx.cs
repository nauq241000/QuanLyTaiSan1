using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Public;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;

namespace ChiTietCongViec
{
    public partial class DoiMatKhau : System.Web.UI.Page
    {
        NhanSuDangNhapBLL cls = new NhanSuDangNhapBLL();
        NhanSuDangNhapPublic Public = new NhanSuDangNhapPublic();
        string ID = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ID = Request.QueryString["US"];
            lbThongbao.Visible = false;
        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            NhanSuDangNhapBLL cls = new NhanSuDangNhapBLL();
            NhanSuDangNhapPublic Public = new NhanSuDangNhapPublic();
            Public.QLNS_MaNhanSu = ID;
            Public.NSDN_MatKhau = toMD5(txtmkcu.Text);
            if (cls.CheckLogin(Public) > 0)
            {
                Public.NSDN_MatKhau = toMD5(txtmkmoi.Text);

                if (txtmkmoi.Text == "123")
                {
                    lbThongbao.ForeColor = Color.Red;
                    lbThongbao.Text = "Mật khẩu vừa đặt không hợp lệ";
                    lbThongbao.Visible = true;
                }
                else
                {
                    if (cls.Doimk(Public) > 0)
                    {

                        lbThongbao.ForeColor = Color.Red;
                        lbThongbao.Text = "Đổi mật khẩu thành công";
                        lbThongbao.Visible = true;

                        Response.Redirect("?US=" + ID);
                    }
                    else
                    {
                        lbThongbao.ForeColor = Color.Red;
                        lbThongbao.Text = "Đổi mật khẩu thất bại";
                        lbThongbao.Visible = true;
                    }
                }
            }
            else
            {
                lbThongbao.ForeColor = Color.Red;
                lbThongbao.Text = "Mật khẩu cũ không chính xác";
                lbThongbao.Visible = true;
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