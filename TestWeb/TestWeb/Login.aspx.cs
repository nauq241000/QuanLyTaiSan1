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

namespace TestWeb
{
    public partial class Login : System.Web.UI.Page
    {

        DangNhapASPPublic Public = new DangNhapASPPublic();
        DangNhapASPBLL cls = new DangNhapASPBLL();

        string ID = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            ID = Request.QueryString["ID"];
        }

        protected void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (ID != null)
            {
                if (!string.IsNullOrEmpty(txtuser.Text) && !string.IsNullOrEmpty(txtuser.Text))
                {
                    Public.username = txtuser.Text;
                    Public.password = toMD5(txtpass.Text);

                    if (cls.CheckLogin(Public) > 0)
                        Response.Redirect("?ID=" + ID + "&US=" + txtuser.Text);
                    else
                    {
                        lbThongbao.Visible = true;
                        lbThongbao.Text = "Tài khoản hoặc mật khẩu không chính xác!!!";
                        lbThongbao.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtuser.Text) && !string.IsNullOrEmpty(txtuser.Text))
                {
                    Public.username = txtuser.Text;
                    Public.password = toMD5(txtpass.Text);

                    if (cls.CheckLogin(Public) > 0)
                        Response.Redirect("?US=" + txtuser.Text);
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