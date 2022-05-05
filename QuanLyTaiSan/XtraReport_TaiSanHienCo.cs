using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using Public;
using BLL;
using System.Windows.Forms;

namespace QuanLyTaiSan
{
    public partial class XtraReport_TaiSanHienCo : DevExpress.XtraReports.UI.XtraReport
    {

        TaiSanHienCoBLL cls = new TaiSanHienCoBLL();
        TaiSanHienCoPublic Public = new TaiSanHienCoPublic();

        QuanLyPhongBLL cls_QuanLyPhongBLL = new QuanLyPhongBLL();
        TaiSanYeuCauBLL cls_TaiSanYeuCauBLL = new TaiSanYeuCauBLL();

        QuanLyNhanSuBLL cls_QuanLyNhanSuBLL = new QuanLyNhanSuBLL();
        QuanLyNhanSuPublic Public_QuanLyNhanSu = new QuanLyNhanSuPublic();

        QuanLyDonViBLL cls_QuanLyDonViBLL = new QuanLyDonViBLL();
        QuanLyDonViPublic Public_QuanLyDonVi = new QuanLyDonViPublic();

        int stt = 0;


        public XtraReport_TaiSanHienCo(TaiSanHienCoPublic Public)
        {
            InitializeComponent();
            
            string string_Header = "";

            SqlDataReader dr = cls.TS_TaiSanHienCo_Load_R_Para_File(Public);

            dr.Read();

            //Phần string_Header



            //MessageBox.Show("Đường dẫn" + Environment.CurrentDirectory);
            //string Duong_Dan_01 = "'" + Environment.CurrentDirectory.ToString().Replace("\\", "/") + "/img_dongke_dam.bmp'";
            //MessageBox.Show("Đường dẫn: " + Duong_Dan_01);

            Public_QuanLyNhanSu.QLNS_Ma = Convert.ToInt32(dr["QLNS_MaNSQL"]);
            SqlDataReader dr_01 = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_Load_R_Para_File(Public_QuanLyNhanSu);
            dr_01.Read();


            Public_QuanLyDonVi.QLDV_Ma = Convert.ToInt32(dr_01["QLDV_Ma"]);
            SqlDataReader dr_02 = cls_QuanLyDonViBLL.TS_QuanLyDonVi_Load_R_Para_File(Public_QuanLyDonVi);
            dr_02.Read();


            string_Header = "<table width='100%' border='0' cellspacing='0' cellpadding='0'>";
            string_Header += "<tr><td><p align='center' class='MsoNormal' style='margin-bottom:0cm;margin-bottom:.0001pt;text-align:center;line-height:normal'><b style='mso-bidi-font-weight:normal'><span style='font-size:16.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'>CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM<o:p></o:p></span></b></p></td></tr>";
            string_Header += "<tr><td><p align='center' class='MsoNormal'><b style='mso-bidi-font-weight:normal'><span style='font-size:14.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'>Độc lập - Tự do - Hạnh Phúc<o:p></o:p></span></b></p></td></tr>";
            string_Header += "<tr><td><p align='center' class='MsoNormal'><b style='mso-bidi-font-weight:normal'><span style='font-size:16.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'>BIÊN BẢN BÀN GIAO TÀI SẢN<o:p></o:p></span></b></p></td></tr></table>";
            ////Phần string_NoiDung
            string_Header += "<br/><table width='100%' border='0' cellspacing='0' cellpadding='0'>";
            string_Header += "<tr><td><p class='MsoNormal'><span style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hôm nay, ngày …. tháng …. năm 2022 tại ........................................................... của trường Đại học </p>";
            string_Header += "<p class='MsoNormal'><span style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'>Kinh tế - Kỹ thuật Công nghiệp, tầng ......., tòa nhà&nbsp; ............. ,.......................................................................<o:p></o:p></span></p>";
            string_Header += "<p class='MsoNormal'><span style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'>Chúng tôi gồm có:<o:p></o:p></span></p></td></tr>";
            string_Header += "<tr><td><p class='MsoNormal'><b style='mso-bidi-font-weight:normal'><span style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'><span style='mso-spacerun:yes'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>BÊN GIAO: " + Convert.ToString(dr_02["QLDV_TenDonVi"]) + " - TRƯỜNG ĐẠI HỌC KINH TẾ - KỸ THUẬT CÔNG NGHIỆP<o:p></o:p></span></b></p></td></tr>";
            string_Header += "<tr><td><span style='font-size:12.0pt;line-height:107%;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:EN-US;mso-fareast-language:EN-US;mso-bidi-language:AR-SA'>Họ và tên: " + Convert.ToString(dr_01["QLNS_HoTen"]) + " , Chức vụ: " + Convert.ToString(dr_01["QLNS_ChucVu"]) + " </span></td></tr><tr>";
            string_Header += "<tr><td><br/><b style='mso-bidi-font-weight:normal'><span style='font-size:12.0pt;line-height:107%;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:EN-US;mso-fareast-language:EN-US;mso-bidi-language:AR-SA'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; BÊN NHẬN</span></b><span style='font-size:12.0pt;line-height:107%;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:EN-US;mso-fareast-language:EN-US;mso-bidi-language:AR-SA'>: </span></td></tr>";


            dr_01.Close();
            Public_QuanLyNhanSu.QLNS_Ma = Convert.ToInt32(dr["QLNS_MaNSSD"]);
            dr_01 = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_Load_R_Para_File(Public_QuanLyNhanSu);
            dr_01.Read();


            string_Header += "<tr><td><br/><span style='font-size:12.0pt;line-height:107%;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:EN-US;mso-fareast-language:EN-US;mso-bidi-language:AR-SA'>Họ và tên: " + Convert.ToString(dr_01["QLNS_HoTen"]) + " , Chức vụ: " + Convert.ToString(dr_01["QLNS_ChucVu"]) + " </span></td></tr><tr>";
            string_Header += "<tr><td>Điện thoại: " + Convert.ToString(dr_01["QLNS_SoDienThoai"]) + " </td></tr>";
            string_Header += "<tr><td><p class='MsoNormal'><b style='mso-bidi-font-weight:normal'><i style='mso-bidi-font-style:normal'><span style='font-size:12.0pt;line-height:120%;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'><span style='mso-spacerun:yes'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>Bên giao</span></i></b><span style='font-size:12.0pt;line-height:120%;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'> đã tiến hành bàn giao số vật tư, hàng hóa cho <b style='mso-bidi-font-weight:normal'><i style='mso-bidi-font-style:normal'>Bên nhận</i></b> theo biểu thống kê sau:<o:p></o:p></span></p></td></tr></table>";

            xrRichText.Html = string_Header;

            string string_Footer = "";
            string_Footer += "<p class='MsoNormal'><span style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'>Toàn bộ tài sản, vật tư trên bàn giao lắp đặt tại các phòng <span style='mso-spacerun:yes'>&nbsp;</span>............................................<o:p></o:p></span></p></td></tr>";
            string_Footer += "<p class='MsoNormal'><span style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'>Kể từ ngày<span style='mso-spacerun:yes'>......</span>/....../20...... số vật tư trên do bên nhận chịu trách nhiệm quản lý.<o:p></o:p></span></p></td></tr>";
            string_Footer += "<p class='MsoNormal'><span style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'>Biên bản này có tổng số trang là ...... (........) trang, lập thành ...... (........) bản có giá trị như nhau. Bên giao giữ ...... (........) bản, bên nhận giữ ...... (........) bản.<o:p></o:p></span></p></td></tr>";
            string_Footer += "<p class='MsoNormal'><span style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'>Biên bản này có tổng số trang là ...... (........) trang, lập thành ...... (........) bản có giá trị như nhau. Bên giao giữ ...... (........) bản, bên nhận giữ ...... (........) bản.<o:p></o:p></span></p></td></tr>";

            string_Footer += "<table border='0' cellpadding='0' cellspacing='0' class='style7' style='mso-yfti-tbllook: 1184; mso-padding-alt: 0cm 5.4pt 0cm 5.4pt; mso-border-insideh: none; mso-border-insidev: none' width='737'>";
            string_Footer += "<tr style='mso-yfti-irow:0;mso-yfti-firstrow:yes;mso-yfti-lastrow:yes'><td style='width:269.35pt;padding:0cm 5.4pt 0cm 5.4pt' valign='top' width='359'><p align='center' class='MsoNormal'><b style='mso-bidi-font-weight:normal'><span lang='VI' style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:VI'>BÊN GIAO<o:p></o:p></span></b></p><p align='center' class='MsoNormal'><i style='mso-bidi-font-style:normal'><span lang='VI' style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:VI'><o:p></o:p></span></i></p></td>";
            string_Footer += "<td style='width:283.55pt;padding:0cm 5.4pt 0cm 5.4pt' valign='top' width='378'><p align='center' class='MsoNormal'><b style='mso-bidi-font-weight:normal'><span lang='VI' style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:VI'>BÊN NHẬN<o:p></o:p></span></b></p><p align='center' class='MsoNormal'><i style='mso-bidi-font-style:normal'><span lang='VI' style='font-size:14.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:VI'><o:p></o:p></span></i></p></td></tr></table>";

            //xrRichText1.Html = string_Footer;

            xrRichText2.Html = string_Footer;
        }

        public void BindData()
        {
            STT.DataBindings.Add("Text", DataSource, "STT");
            TSHC_TenTaiSan.DataBindings.Add("Text", DataSource, "TSHC_TenTaiSan");
            TSHC_ThuongHieu.DataBindings.Add("Text", DataSource, "TSHC_ThuongHieu");
            TSHC_XuatXu.DataBindings.Add("Text", DataSource, "TSHC_XuatXu");
            TSHC_NamSanXuat.DataBindings.Add("Text", DataSource, "TSHC_NamSanXuat");
            TSHC_SoSeri.DataBindings.Add("Text", DataSource, "TSHC_SoSeri");
            TSHC_SoLuong.DataBindings.Add("Text", DataSource, "TSHC_SoLuong");
            TSHC_ThoiGianBaoHanh.DataBindings.Add("Text", DataSource, "TSHC_ThoiGianBaoHanh");
            TSHC_GhiChu.DataBindings.Add("Text", DataSource, "TSHC_GhiChu");
        }

        public void SetPageHeader()
        {
            PageHeader.PrintOn = PrintOnPages.NotWithReportFooter;
        }
    }
}
