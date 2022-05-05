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
    public partial class XtraReport_BaoHanh : DevExpress.XtraReports.UI.XtraReport
    {
        TaiSanHienCoBLL cls_TaiSanHienCoBLL = new TaiSanHienCoBLL();
        TaiSanHienCoPublic Public_TaiSanHienCo = new TaiSanHienCoPublic();

        QuanLyPhongBLL cls_QuanLyPhongBLL = new QuanLyPhongBLL();
        QuanLyPhongPublic Public_QuanLyPhong = new QuanLyPhongPublic();

        QuanLyNhanSuBLL cls_QuanLyNhanSuBLL = new QuanLyNhanSuBLL();
        QuanLyNhanSuPublic Public_QuanLyNhanSu = new QuanLyNhanSuPublic();

        QuanLyDonViBLL cls_QuanLyDonViBLL = new QuanLyDonViBLL();
        QuanLyDonViPublic Public_QuanLyDonVi = new QuanLyDonViPublic();

        ThucHienCongViecBLL cls = new ThucHienCongViecBLL();
        ThucHienCongViecPublic Public = new ThucHienCongViecPublic();

        public XtraReport_BaoHanh(ThucHienCongViecPublic Public, string LoaiBienBan)
        {
            InitializeComponent();

            string string_Header = "";

            SqlDataReader dr = cls.PC_ThucHienCongViec_Load_R_Para_File(Public);

            dr.Read();

            //Phần string_Header



            //MessageBox.Show("Đường dẫn" + Environment.CurrentDirectory);
            //string Duong_Dan_01 = "'" + Environment.CurrentDirectory.ToString().Replace("\\", "/") + "/img_dongke_dam.bmp'";
            //MessageBox.Show("Đường dẫn: " + Duong_Dan_01);

            Public_QuanLyNhanSu.QLNS_Ma = Convert.ToInt32(dr["QLNS_MaNSTH"]);
            SqlDataReader dr_01 = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_Load_R_Para_File(Public_QuanLyNhanSu);
            dr_01.Read();




            string_Header = "<table width='100%' border='0' cellspacing='0' cellpadding='0'>";
            string_Header += "<tr><td><p align='center' class='MsoNormal' style='margin-bottom:0cm;margin-bottom:.0001pt;text-align:center;line-height:normal'><b style='mso-bidi-font-weight:normal'><span style='font-size:16.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'>CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM<o:p></o:p></span></b></p></td></tr>";
            string_Header += "<tr><td><p align='center' class='MsoNormal'><b style='mso-bidi-font-weight:normal'><span style='font-size:14.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'>Độc lập - Tự do - Hạnh Phúc<o:p></o:p></span></b></p></td></tr>";
            string_Header += "<tr><td><p align='center' class='MsoNormal'><b style='mso-bidi-font-weight:normal'><span style='font-size:16.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'>BIÊN BẢN BÀN GIAO CÔNG VIỆC " + LoaiBienBan + "<o:p></o:p></span></b></p></td></tr></table>";
            ////Phần string_NoiDung
            string_Header += "<br/><table width='100%' border='0' cellspacing='0' cellpadding='0'>";
            string_Header += "<tr><td><p class='MsoNormal'><span style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hôm nay, ngày …. tháng …. năm 2022 tại ........................................................... của trường Đại học </p>";
            string_Header += "<p class='MsoNormal'><span style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'>Kinh tế - Kỹ thuật Công nghiệp<o:p></o:p></span></p>";
            string_Header += "<tr><td><p class='MsoNormal'><b style='mso-bidi-font-weight:normal'><span style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial'><span style='mso-spacerun:yes'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>BÊN GIAO: PHÒNG ĐÀO TẠO - TRƯỜNG ĐẠI HỌC KINH TẾ - KỸ THUẬT CÔNG NGHIỆP<o:p></o:p></span></b></p></td></tr>";
            string_Header += "<tr><td><br/><b style='mso-bidi-font-weight:normal'><span style='font-size:12.0pt;line-height:107%;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:EN-US;mso-fareast-language:EN-US;mso-bidi-language:AR-SA'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; BÊN NHẬN</span></b><span style='font-size:12.0pt;line-height:107%;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:EN-US;mso-fareast-language:EN-US;mso-bidi-language:AR-SA'>: </span></td></tr>";
            string_Header += "<tr><td><span style='font-size:12.0pt;line-height:107%;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:EN-US;mso-fareast-language:EN-US;mso-bidi-language:AR-SA'>Họ và tên: " + Convert.ToString(dr_01["QLNS_HoTen"]) + " , Chức vụ: " + Convert.ToString(dr_01["QLNS_ChucVu"]) + " </span></td></tr>";


            string_Header += "<tr><td><br/><b style='mso-bidi-font-weight:normal'><span style='font-size:12.0pt;line-height:107%;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:EN-US;mso-fareast-language:EN-US;mso-bidi-language:AR-SA'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DANH SÁCH TÀI SẢN "+LoaiBienBan+"</span></b><span style='font-size:12.0pt;line-height:107%;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:EN-US;mso-fareast-language:EN-US;mso-bidi-language:AR-SA'>: </span></td></tr></table>";


            xrRichText.Html = string_Header;

            string string_Footer = "";
            string_Footer += "<p class='MsoNormal'><span style='font-size:14.0pt;line-height:150%'><o:p>&nbsp;</o:p></span></p><span class='style1' style='mso-fareast-font-family: Calibri; color: black; mso-font-kerning: 18.0pt; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Người bàn giao cam đoan rằng toàn bộ nội dung công việc đang thực hiện và tài sản đã được bàn giao đầy đủ. Biên bản được lập thành 02 bản, mỗi bên giữ một bản.</span><p class='MsoNormal'><o:p></o:p></p>";

            string_Footer += "<table border='0' cellpadding='0' cellspacing='0' class='style7' style='mso-yfti-tbllook: 1184; mso-padding-alt: 0cm 5.4pt 0cm 5.4pt; mso-border-insideh: none; mso-border-insidev: none' width='737'>";
            string_Footer += "<tr style='mso-yfti-irow:0;mso-yfti-firstrow:yes;mso-yfti-lastrow:yes'><td style='width:269.35pt;padding:0cm 5.4pt 0cm 5.4pt' valign='top' width='359'><p align='center' class='MsoNormal'><b style='mso-bidi-font-weight:normal'><span lang='VI' style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:VI'>BÊN GIAO<o:p></o:p></span></b></p><p align='center' class='MsoNormal'><i style='mso-bidi-font-style:normal'><span lang='VI' style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:VI'><o:p></o:p></span></i></p></td>";
            string_Footer += "<td style='width:283.55pt;padding:0cm 5.4pt 0cm 5.4pt' valign='top' width='378'><p align='center' class='MsoNormal'><b style='mso-bidi-font-weight:normal'><span lang='VI' style='font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:VI'>BÊN NHẬN<o:p></o:p></span></b></p><p align='center' class='MsoNormal'><i style='mso-bidi-font-style:normal'><span lang='VI' style='font-size:14.0pt;font-family:&quot;Times New Roman&quot;,serif;mso-fareast-font-family:Arial;mso-ansi-language:VI'><o:p></o:p></span></i></p></td></tr></table>";

            //xrRichText1.Html = string_Footer;

            xrRichText2.Html = string_Footer;

            dr.Close();
            dr_01.Close();
        }

        public void BindData()
        {
            STT.DataBindings.Add("Text", DataSource, "STT");
            TSHC_TenTaiSan.DataBindings.Add("Text", DataSource, "TSHC_TenTaiSan");
            QLP_TenPhong.DataBindings.Add("Text", DataSource, "QLP_TenPhong");
            QLP_ToaNha.DataBindings.Add("Text", DataSource, "QLP_ToaNha");
            QLP_DiaDiem.DataBindings.Add("Text", DataSource, "QLP_DiaDiem");
            TSHC_NgayDuaVaoSuDung.DataBindings.Add("Text", DataSource, "TSHC_NgayDuaVaoSuDung");
            TSHC_ThoiGianBaoHanh.DataBindings.Add("Text", DataSource, "TSHC_ThoiGianBaoHanh");
            TSHC_GhiChu.DataBindings.Add("Text", DataSource, "TSHC_GhiChu");
        }

        public void SetPageHeader()
        {
            PageHeader.PrintOn = PrintOnPages.NotWithReportFooter;
        }

    }
}
