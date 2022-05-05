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

namespace QuanLyTaiSan
{
    public partial class frmQRCode_Sua : DevExpress.XtraEditors.XtraForm
    {
        public frmQRCode_Sua()
        {
            InitializeComponent();
        }

        TaiSanHienCoBLL cls = new TaiSanHienCoBLL();
        QRcodePublic Public = new QRcodePublic();

        private void frmQRCode_Sua_Load(object sender, EventArgs e)
        {
            try
            {
                txtLink.Text = cls.TS_QRCode_Load().Rows[0][1].ToString();
            }catch{}
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thay đổi link???", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Public.HT_UserEditor = BienToanCuc.HT_USER_ID; ;
                Public.QRCode_Link = txtLink.Text;

                int kq = cls.TS_QRCode_Sua(Public);

                MessageBox.Show("Cập nhật thành công!!!", "Thông báo");

                this.Close();
            }
        }
    }
}