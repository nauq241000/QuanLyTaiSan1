<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestWeb.Default" %>

<%@ Register Assembly="DevExpress.Web.v15.2, Version=15.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style9
        {
            width: 100%;
        }
        .style10
        {
            width: 160%;
        }
        .style11
        {
            width: 100%;
            margin-left: 0px;
        }
        .style12
        {
            
        }
        .style13
        {
            width: 23%;
        }
        .style14
        {
            
        }
        .style15
        {
            height: 83px;
            width: 23%;
        }
        .style17
        {
            width: 65%;
        }
        .style27
        {
            height: 46px;
            width: 141px;
        }
        .style33
        {
            height: 19px;
            width: 141px;
        }
        .style36
        {
            height: 44px;
            width: 141px;
        }
        .style37
        {
            width: 141px;
        }
        .style38
        {
            height: 18px;
            width: 141px;
        }
        .style51
        {
            height: 24px;
            width: 23%;
        }
        .style52
        {
            height: 44px;
            width: 147px;
        }
        .style53
        {
            height: 46px;
            width: 147px;
        }
        .style54
        {
            width: 147px;
        }
        .style56
        {
            height: 19px;
            width: 147px;
        }
        .style57
        {
            height: 18px;
            width: 147px;
        }
        .style62
        {
            width: 100px;
        }
        .style67
        {
            width: 99px;
        }
        .style68
        {
            width: 90px;
        }
        .style70
        {
            width: 99px;
            text-align: center;
            height: 53px;
        }
        .style72
        {
            width: 90px;
            text-align: center;
            height: 53px;
        }
        .style74
        {
            font-size: 14px;
        }
        .style75
        {
            width: 145px;
            text-align: center;
            height: 53px;
        }
        .style76
        {
            width: 100px;
            text-align: center;
            height: 53px;
        }
        .style77
        {
            width: 105px;
            text-align: center;
            height: 53px;
        }
        .style78
        {
            width: 105px;
        }
        .style85
        {
            width: 145px;
        }
        .style87
        {
            width: 90px;
            height: 50px;
        }
        .style88
        {
            width: 105px;
            height: 50px;
        }
        .style91
        {
            width: 145px;
            height: 50px;
        }
        .style92
        {
            width: 99px;
            height: 50px;
        }
        .style93
        {
            width: 100px;
            height: 50px;
        }
        .style94
        {
            width: 108px;
            text-align: center;
            height: 53px;
        }
        .style95
        {
            width: 108px;
            height: 50px;
        }
        .style96
        {
            width: 108px;
        }
        .style97
        {
            width: 163px;
            text-align: center;
            height: 53px;
        }
        .style98
        {
            width: 163px;
            height: 50px;
        }
        .style99
        {
            width: 163px;
        }
        .style100
        {
            height: 57px;
            width: 147px;
        }
        .style101
        {
            height: 57px;
            width: 141px;
        }
        .style105
        {
            width: 248px;
        }
        .style106
        {
            width: 450px;
        }
        .style108
        {
            height: 39px;
            width: 298px;
        }
        .style109
        {
            width: 439px;
        }
        .style110
        {
            width: 165px;
        }
        .style111
        {
            width: 298px;
        }
        .style113
        {
            height: 27px;
        }
        .style114
        {
            width: 814px;
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 1155px">
        <table class="style9">
            <tr>
                <td class="style10" xml:lang="100%">
                    <table class="dxflInternalEditorTable_Aqua">
                        <tr>
                            <td class="style113" width="42%">
                            </td>
                            <td class="style113" width="25%">
                            </td>
                            <td align="right" class="style114" width="10%">
                                <br />
                                <dx:ASPxButton ID="btnBaoHong" runat="server" Font-Size="16px" Height="34px" 
                                    style="margin-left: 0px" Text="Gửi Yêu Cầu" Theme="Aqua" Width="131px" 
                                    onclick="btnBaoHong_Click">
                                    <Image IconID="actions_cancel_16x16">
                                    </Image>
                                </dx:ASPxButton>
                            
                            </td>
                            <td align="right" class="style114" width="18%">
                                <br />
                                <dx:ASPxButton ID="btnDangNhap" runat="server" Font-Size="16px" Height="34px" 
                                    style="margin-left: 0px" Text="Đăng Nhập" Theme="Aqua" Width="131px" 
                                    onclick="btnDangNhap_Click">
                                    <Image IconID="businessobjects_bocustomer_16x16">
                                    </Image>
                                </dx:ASPxButton>
                            </td>
                            <td align="right" class="style113" width="5%">
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="style10">
                    <table class="style11">
                        <tr>
                            <td class="style12">
                                &nbsp;</td>
                            <td class="style17">
                                <table class="style11">
                                    <tr>
                                        <td class="style15">
                                            <span style="color: rgb(0, 0, 255); font-family: Roboto, Arial, sans-serif; font-size: 18px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 300; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
                                            THÔNG TIN QUÁ TRÌNH QUẢN LÝ VÀ SỬ DỤNG THẺ TÀI SẢN</span></td>
                                    </tr>
                                    <tr>
                                        <td class="style13">
                                            <dx:ASPxPageControl runat="server" ActiveTabIndex="3" 
                                                Theme="Aqua" Width="100%" ID="ASPxPageControl1">
                                                <tabpages>
                                                    <dx:TabPage Text="Cơ Bản">
                                                        <activetabstyle font-size="16px">
                                                        </activetabstyle>
                                                        <tabstyle font-size="14px">
                                                        </tabstyle>
                                                        <contentcollection>
                                                            <dx:ContentControl runat="server">
                                                                <table class="dx-justification" style="width: 97%">
                                                                    <tr>
                                                                        <td class="style52">
                                                                            &nbsp;</td>
                                                                        <td class="style36">
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style53" 
                                                                            style="border: 1px solid #808080; font-size: 14px; background-color: #87cefa; font-weight: bold;" 
                                                                            width="100%">
                                                                        <br />
                                                                            &nbsp;Mã tài sản<br />
                                                                        <br />
                                                                        </td>
                                                                        <td class="style27" 
                                                                            style="border: 1px solid #808080; background-color: #87cefa" width="100%">
                                                                            &nbsp;
                                                                            <dx:ASPxLabel ID="lb_MaTS" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style54" 
                                                                            style="border: 1px solid #808080; font-size: 14px; font-weight: bold;" 
                                                                            width="100%">
                                                                        <br />
                                                                            &nbsp;Tên&nbsp; tài sản<br />
                                                                        <br />
                                                                        </td>
                                                                        <td class="style37" style="border: 1px solid #808080; font-size: 14px;" 
                                                                            width="100%">
                                                                            &nbsp;
                                                                            <dx:ASPxLabel ID="lb_TenTS" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style100" 
                                                                            style="border: 1px solid #808080; font-size: 14px; background-color: #87cefa; font-weight: bold;" 
                                                                            width="100%">
                                                                            &nbsp;<br />&nbsp;Loại tài sản<br />
                                                                        <br />
                                                                        </td>
                                                                        <td class="style101" 
                                                                            style="border: 1px solid #808080; background-color: #87cefa" width="100%">
                                                                            &nbsp;
                                                                            <dx:ASPxLabel ID="lb_LoaiTS" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style56" 
                                                                            style="border: 1px solid #808080; font-size: 14px; font-weight: bold;" 
                                                                            width="100%">
                                                                        <br />
                                                                            &nbsp;Số Seri<br />
                                                                        <br />
                                                                        </td>
                                                                        <td class="style33" style="border: 1px solid #808080;" width="100%">
                                                                            &nbsp;
                                                                            <dx:ASPxLabel ID="lb_Seri" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style100" 
                                                                            style="border: 1px solid #808080; font-size: 14px; background-color: #87cefa; font-weight: bold;" 
                                                                            width="100%">
                                                                            &nbsp;
                                                                        <br />
                                                                            &nbsp;Thương hiệu<br />
                                                                        <br />
                                                                        </td>
                                                                        <td class="style101" 
                                                                            style="border: 1px solid #808080; background-color: #87cefa" width="100%">
                                                                            &nbsp;
                                                                            <dx:ASPxLabel ID="lb_ThuongHieu" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style57" 
                                                                            style="border: 1px solid #808080; font-size: 14px; font-weight: bold;" 
                                                                            width="100%">
                                                                        <br />
                                                                            &nbsp;Xuất xứ</td>
                                                                        <td class="style38" style="border: 1px solid #808080;" width="100%">
                                                                            &nbsp;
                                                                            <dx:ASPxLabel ID="lb_XuatXu" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style57" 
                                                                            style="border: 1px solid #808080; font-size: 14px; background-color: #87cefa; font-weight: bold;" 
                                                                            width="100%">
                                                                            &nbsp;
                                                                        <br />
                                                                            &nbsp;Nguồn gốc<br />
                                                                        <br />
                                                                        </td>
                                                                        <td class="style38" 
                                                                            style="border: 1px solid #808080; background-color: #87cefa" width="100%">
                                                                            &nbsp;
                                                                            <dx:ASPxLabel ID="lb_NguonGoc" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style54" 
                                                                            style="border: 1px solid #808080; font-size: 14px; font-weight: bold;" 
                                                                            width="100%">
                                                                        <br />
                                                                            &nbsp;Năm sản xuất<br />
                                                                        <br />
                                                                        </td>
                                                                        <td class="style37" style="border: 1px solid #808080;" width="100%">
                                                                            &nbsp;
                                                                            <dx:ASPxLabel ID="lb_NamSX" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style100" 
                                                                            style="border: 1px solid #808080; font-size: 14px; background-color: #87cefa; font-weight: bold;" 
                                                                            width="100%">
                                                                            &nbsp;
                                                                        <br />
                                                                            &nbsp;Ngày đưa vào sử dụng<br />
                                                                        <br />
                                                                        </td>
                                                                        <td class="style101" 
                                                                            style="border: 1px solid #808080; background-color: #87cefa" width="100%">
                                                                            &nbsp;
                                                                            <dx:ASPxLabel ID="lb_NgaySD" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style52" 
                                                                            style="border: 1px solid #808080; font-size: 14px; font-weight: bold;" 
                                                                            width="100%">
                                                                            &nbsp;
                                                                        <br />
                                                                            &nbsp;Hạn bảo hành<br />
                                                                        <br />
                                                                        </td>
                                                                        <td class="style36" style="border: 1px solid #808080;" width="100%">
                                                                            &nbsp;
                                                                            <dx:ASPxLabel ID="lb_HanBaoHanh" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style57" 
                                                                            style="border: 1px solid #808080; font-size: 14px; background-color: #87cefa; font-weight: bold;" 
                                                                            width="100%">
                                                                        <br />
                                                                            &nbsp;Tình trạng<br />
                                                                        <br />
                                                                        </td>
                                                                        <td class="style38" 
                                                                            style="border: 1px solid #808080; background-color: #87cefa" width="100%">
                                                                            &nbsp;
                                                                            <dx:ASPxLabel ID="lb_TinhTrang" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style54" 
                                                                            style="border: 1px solid #808080; font-size: 14px; font-weight: bold;" 
                                                                            width="100%">
                                                                        <br />
                                                                        <br />
                                                                        <br />
                                                                        <br />
                                                                        <br />
                                                                            &nbsp;<br />&nbsp;Ảnh chụp tài sản<br />
                                                                        <br />
                                                                        <br />
                                                                        <br />
                                                                        </td>
                                                                        <td class="style37" style="border: 1px solid #808080;" width="100%">
                                                                            &nbsp;
                                                                        <br />
                                                                        <br />
                                                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                            <dx:ASPxImage ID="img_AnhChupTS" runat="server" Height="107px" 
                                                                                ShowLoadingImage="True" Width="143px">
                                                                            </dx:ASPxImage>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style54">
                                                                        <br />
                                                                        <br />
                                                                        </td>
                                                                        <td class="style37">
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style54">
                                                                            &nbsp;</td>
                                                                        <td class="style37">
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style54">
                                                                            &nbsp;</td>
                                                                        <td class="style37">
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style54">
                                                                            &nbsp;</td>
                                                                        <td class="style37">
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                </table>
                                                            </dx:ContentControl>
                                                        </contentcollection>
                                                    </dx:TabPage>
                                                    <dx:TabPage Text="Cán Bộ Sử Dụng">
                                                        <activetabstyle font-size="16px">
                                                        </activetabstyle>
                                                        <tabstyle font-size="14px">
                                                        </tabstyle>
                                                        <contentcollection>
                                                            <dx:ContentControl runat="server">
                                                                <table class="dx-justification" style="width: 95%">
                                                                    <tr class="style74">
                                                                        <td class="style72" 
                                                                            style="border: 1px solid #808080; font-size: 14px; background-color: #99CCFF; font-weight: bold;" 
                                                                            width="100%">
                                                                            Mã Nhân Sự</td>
                                                                        <td class="style77" 
                                                                            style="border: 1px solid #808080; font-size: 14px; background-color: #99CCFF; font-weight: bold;" 
                                                                            width="100%">
                                                                            Tên Đơn Vị</td>
                                                                        <td class="style97" 
                                                                            style="border: 1px solid #808080; font-size: 14px; background-color: #99CCFF; font-weight: bold;" 
                                                                            width="100%">
                                                                            Họ Tên</td>
                                                                        <td class="style94" 
                                                                            style="border: 1px solid #808080; font-size: 14px; background-color: #99CCFF; font-weight: bold;" 
                                                                            width="100%">
                                                                            Số Điện Thoại</td>
                                                                        <td class="style75" 
                                                                            style="border: 1px solid #808080; font-size: 14px; background-color: #99CCFF; font-weight: bold;" 
                                                                            width="100%">
                                                                            Chức Vụ</td>
                                                                        <td class="style70" 
                                                                            style="border: 1px solid #808080; font-size: 14px; background-color: #99CCFF; font-weight: bold;" 
                                                                            width="100%">
                                                                            Cơ Sở</td>
                                                                        <td class="style76" 
                                                                            style="border: 1px solid #808080; font-size: 14px; background-color: #99CCFF; font-weight: bold;" 
                                                                            width="100%">
                                                                            Phòng Hiện Tại</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="center" class="style87" style="border: 1px solid #808080; " 
                                                                            width="100%">
                                                                            <dx:ASPxLabel ID="lb_MaNS" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                        <td align="center" class="style88" style="border: 1px solid #808080; " 
                                                                            width="100%">
                                                                            <dx:ASPxLabel ID="lb_TenDonVi" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                        <td align="center" class="style98" style="border: 1px solid #808080;" 
                                                                            width="100%">
                                                                            <dx:ASPxLabel ID="lb_TenNhanSu" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                        <td align="center" class="style95" style="border: 1px solid #808080;" 
                                                                            width="100%">
                                                                            <dx:ASPxLabel ID="lb_SDT" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                        <td align="center" class="style91" style="border: 1px solid #808080;" 
                                                                            width="100%">
                                                                            <dx:ASPxLabel ID="lb_ChucVu" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                        <td align="center" class="style92" style="border: 1px solid #808080;" 
                                                                            width="100%">
                                                                            <dx:ASPxLabel ID="lb_CoSo" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                        <td align="center" class="style93" style="border: 1px solid #808080;" 
                                                                            width="100%">
                                                                            <dx:ASPxLabel ID="lb_PhongHienTai" runat="server" Font-Size="14px">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style68">
                                                                            &nbsp;</td>
                                                                        <td class="style78">
                                                                            &nbsp;</td>
                                                                        <td class="style99">
                                                                            &nbsp;</td>
                                                                        <td class="style96">
                                                                            &nbsp;</td>
                                                                        <td class="style85">
                                                                            &nbsp;</td>
                                                                        <td class="style67">
                                                                            &nbsp;</td>
                                                                        <td class="style62">
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style68">
                                                                            &nbsp;</td>
                                                                        <td class="style78">
                                                                            &nbsp;</td>
                                                                        <td class="style99">
                                                                            &nbsp;</td>
                                                                        <td class="style96">
                                                                            &nbsp;</td>
                                                                        <td class="style85">
                                                                            &nbsp;</td>
                                                                        <td class="style67">
                                                                            &nbsp;</td>
                                                                        <td class="style62">
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                </table>
                                                            </dx:ContentControl>
                                                        </contentcollection>
                                                    </dx:TabPage>
                                                    <dx:TabPage Text="Thiết Bị Đi Kèm ">
                                                        <activetabstyle font-size="16px">
                                                        </activetabstyle>
                                                        <tabstyle font-size="14px">
                                                        </tabstyle>
                                                        <contentcollection>
                                                            <dx:ContentControl runat="server">
                                                            <br />
                                                            <br />
                                                                <dx:ASPxGridView ID="grv_ThietBiDiKem" runat="server" 
                                                                    AutoGenerateColumns="False" EnableTheming="True" style="margin-bottom: 1px" 
                                                                    Theme="Aqua" Width="100%">
                                                                    <SettingsPager PageSize="5">
                                                                    </SettingsPager>
                                                                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" 
                                                                        AllowInsert="False" />
                                                                    <Columns>
                                                                        <dx:GridViewDataTextColumn Caption="Tên Tài Sản" FieldName="TSHC_TenTaiSan" 
                                                                            Name="TSHC_TenTaiSan" ReadOnly="True" ShowInCustomizationForm="True" 
                                                                            VisibleIndex="2">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                            <CellStyle Font-Size="14px" HorizontalAlign="Center" VerticalAlign="Middle">
                                                                            </CellStyle>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Tình Trạng" FieldName="TSHC_TinhTrang" 
                                                                            Name="TSHC_TinhTrang" ShowInCustomizationForm="True" VisibleIndex="3">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                            <CellStyle Font-Size="14px" HorizontalAlign="Center" VerticalAlign="Middle">
                                                                            </CellStyle>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Xuất Xứ" FieldName="TSHC_XuatXu" 
                                                                            Name="TSHC_XuatXu" ShowInCustomizationForm="True" VisibleIndex="4">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                            <CellStyle Font-Size="14px" HorizontalAlign="Center" VerticalAlign="Middle">
                                                                            </CellStyle>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Thương Hiệu" FieldName="TSHC_ThuongHieu" 
                                                                            Name="TSHC_ThuongHieu" ShowInCustomizationForm="True" VisibleIndex="5">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                            <CellStyle Font-Size="14px" HorizontalAlign="Center" VerticalAlign="Middle">
                                                                            </CellStyle>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Ghi Chú" FieldName="TSHC_GhiChu" 
                                                                            Name="TSHC_GhiChu" ShowInCustomizationForm="True" VisibleIndex="6">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                            <CellStyle Font-Size="14px" HorizontalAlign="Center" VerticalAlign="Middle">
                                                                            </CellStyle>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Loại Tài Sản" FieldName="TSHC_LoaiTaiSan" 
                                                                            Name="TSHC_LoaiTaiSan" ShowInCustomizationForm="True" VisibleIndex="1">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                            <CellStyle Font-Size="14px" HorizontalAlign="Center" VerticalAlign="Middle">
                                                                            </CellStyle>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn FieldName="TSHC_Ma" Name="TSHC_Ma" 
                                                                            ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                                                                        </dx:GridViewDataTextColumn>
                                                                    </Columns>
                                                                </dx:ASPxGridView>
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            </dx:ContentControl>
                                                        </contentcollection>
                                                    </dx:TabPage>
                                                    <dx:TabPage Text="Sửa TT Cán Bộ Sử Dụng">
                                                        <ActiveTabStyle Font-Size="16px">
                                                        </ActiveTabStyle>
                                                        <TabStyle Font-Size="14px">
                                                        </TabStyle>
                                                        <ContentCollection>
                                                            <dx:ContentControl runat="server">
                                                                <table class="dx-justification">
                                                                    <caption>
                                                                        <tr>
                                                                            <td class="style108">
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style111" style="font-size: 14px; font-weight: bold;">
                                                                                &nbsp;&nbsp; Mã Nhân Sự<br />
                                                                            <br />
                                                                            </td>
                                                                            <td class="style106">
                                                                                <dx:ASPxComboBox ID="cb_MaNSSua" runat="server" Font-Size="14px" 
                                                                                    TextField="QLNS_MaNhanSu" TextFormatString="{0}" ValueField="QLNS_Ma">
                                                                                    <Columns>
                                                                                        <dx:ListBoxColumn Caption="Mã" FieldName="QLNS_Ma" Name="QLNS_Ma" />
                                                                                        <dx:ListBoxColumn Caption="Mã nhân sự" FieldName="QLNS_MaNhanSu" 
                                                                                            Name="QLNS_MaNhanSu" />
                                                                                        <dx:ListBoxColumn Caption="Tên nhân sự" FieldName="QLNS_HoTen" 
                                                                                            Name="QLNS_HoTen" />
                                                                                        <dx:ListBoxColumn Caption="Chức vụ" FieldName="QLNS_ChucVu" 
                                                                                            Name="QLNS_ChucVu" />
                                                                                        <dx:ListBoxColumn Caption="Email" FieldName="QLNS_Email" Name="QLNS_Email" />
                                                                                        <dx:ListBoxColumn Caption="Số điện thoại" FieldName="QLNS_SoDienThoai" 
                                                                                            Name="QLNS_SoDienThoai" />
                                                                                        <dx:ListBoxColumn Caption="Cơ sở" FieldName="QLNS_CoSo" Name="QLNS_CoSo" />
                                                                                    </Columns>
                                                                                </dx:ASPxComboBox>
                                                                            <br />
                                                                            <br />
                                                                            </td>
                                                                            <td class="style105" style="font-size: 14px; font-weight: bold;">
                                                                                Họ Tên
                                                                            <br />
                                                                            <br />
                                                                            </td>
                                                                            <td>
                                                                                <dx:ASPxLabel ID="lb_HoTenSua" runat="server" Font-Size="14px">
                                                                                </dx:ASPxLabel>
                                                                            <br />
                                                                            <br />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style111" style="font-size: 14px; font-weight: bold;">
                                                                                &nbsp; Tên Đơn Vị<br />
                                                                            <br />
                                                                            </td>
                                                                            <td class="style106">
                                                                                <dx:ASPxLabel ID="lb_TenDonViSua" runat="server" Font-Size="14px">
                                                                                </dx:ASPxLabel>
                                                                            <br />
                                                                            <br />
                                                                            </td>
                                                                            <td class="style105" style="font-size: 14px; font-weight: bold;">
                                                                                Cơ Sở<br />
                                                                            <br />
                                                                            </td>
                                                                            <td>
                                                                                <dx:ASPxLabel ID="lb_CoSoSua" runat="server" Font-Size="14px">
                                                                                </dx:ASPxLabel>
                                                                            <br />
                                                                            <br />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style111" style="font-size: 14px; font-weight: bold;">
                                                                                &nbsp; Chức Vụ<br />
                                                                            <br />
                                                                            </td>
                                                                            <td class="style106">
                                                                                <dx:ASPxLabel ID="lb_ChucVuSua" runat="server" Font-Size="14px">
                                                                                </dx:ASPxLabel>
                                                                            <br />
                                                                            <br />
                                                                            </td>
                                                                            <td class="style105" style="font-size: 14px; font-weight: bold;">
                                                                                Phòng Hiện Tại<br />
                                                                            </td>
                                                                            <td>
                                                                                <dx:ASPxComboBox ID="cb_PhongSua" runat="server" Font-Size="14px" 
                                                                                    TextField="QLP_TenPhong" TextFormatString="{3}" ValueField="QLP_Ma">
                                                                                    <Columns>
                                                                                        <dx:ListBoxColumn Caption="Mã phòng" FieldName="QLP_Ma" Name="QLP_Ma" />
                                                                                        <dx:ListBoxColumn Caption="Cơ sở" FieldName="QLP_CoSo" Name="QLP_CoSo" />
                                                                                        <dx:ListBoxColumn Caption="Địa điểm" FieldName="QLP_DiaDiem" 
                                                                                            Name="QLP_DiaDiem" />
                                                                                        <dx:ListBoxColumn Caption="Tên phòng" FieldName="QLP_TenPhong" 
                                                                                            Name="QLP_TenPhong" />
                                                                                    </Columns>
                                                                                </dx:ASPxComboBox>
                                                                            <br />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style111" style="font-size: 14px; font-weight: bold;">
                                                                                &nbsp; Số Điện Thoại<br />
                                                                            <br />
                                                                            </td>
                                                                            <td class="style106">
                                                                                <dx:ASPxLabel ID="lb_SDTSua" runat="server" Font-Size="14px">
                                                                                </dx:ASPxLabel>
                                                                            <br />
                                                                            <br />
                                                                            </td>
                                                                            <td class="style105">
                                                                                &nbsp;</td>
                                                                            <td>
                                                                                &nbsp;</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style111">
                                                                                &nbsp;</td>
                                                                            <td class="style106">
                                                                                &nbsp;</td>
                                                                            <td class="style105">
                                                                                &nbsp;</td>
                                                                            <td>
                                                                                &nbsp;</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style111">
                                                                                &nbsp;</td>
                                                                            <td class="style106">
                                                                                <table class="dxflInternalEditorTable_Aqua">
                                                                                    <tr>
                                                                                        <td class="style110" align="right">
                                                                                            
                                                                                            <dx:ASPxButton ID="btnKiemTra" runat="server" Font-Size="16px" Text="Kiểm Tra" 
                                                                                                Theme="Aqua" OnClick="btnKiemTra_Click">
                                                                                                <Image IconID="programming_forcetesting_16x16">
                                                                                                </Image>
                                                                                            </dx:ASPxButton>
                                                                                        </td>
                                                                                        <td align="center">
                                                                                            <dx:ASPxButton ID="btnLuu" runat="server" Font-Size="16px" Text="Lưu Thay Đổi" 
                                                                                                Theme="Aqua" OnClick="btnLuu_Click">
                                                                                                <Image IconID="save_saveto_16x16">
                                                                                                </Image>
                                                                                            </dx:ASPxButton>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                            <td class="style105">
                                                                                <dx:ASPxButton ID="btnHuy" runat="server" Font-Size="16px" Text="Hủy" 
                                                                                    Theme="Aqua" OnClick="btnHuy_Click">
                                                                                    <Image IconID="actions_cancel_16x16">
                                                                                    </Image>
                                                                                </dx:ASPxButton>
                                                                            </td>
                                                                            <td>
                                                                                &nbsp;</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="style111">
                                                                                &nbsp;</td>
                                                                            <td align="right" class="style106">
                                                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                            </td>
                                                                            <td class="style105">
                                                                                &nbsp;</td>
                                                                            <td>
                                                                                &nbsp;</td>
                                                                        </tr>
                                                                    </caption>
                                                                </table>
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            </dx:ContentControl>
                                                        </ContentCollection>
                                                    </dx:TabPage>
                                                    <dx:TabPage Text="Thêm TT Thiết Bị Đi Kèm ">
                                                        <ActiveTabStyle Font-Size="16px">
                                                        </ActiveTabStyle>
                                                        <TabStyle Font-Size="14px">
                                                        </TabStyle>
                                                        <ContentCollection>
                                                            <dx:ContentControl runat="server">
                                                            <br />
                                                                <dx:ASPxGridView ID="grv_ThietBiDiKem0" runat="server" 
                                                                    AutoGenerateColumns="False" EnableTheming="True" KeyFieldName="TSHC_Ma" 
                                                                    style="margin-bottom: 1px" Theme="Aqua" Width="100%">
                                                                    <SettingsPager PageSize="5">
                                                                    </SettingsPager>
                                                                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" 
                                                                        AllowInsert="False" />
                                                                    <Columns>
                                                                        <dx:GridViewCommandColumn Name="TSHC_Chon" SelectAllCheckboxMode="Page" 
                                                                            ShowInCustomizationForm="True" ShowSelectCheckbox="True" VisibleIndex="0">
                                                                        </dx:GridViewCommandColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Tên Tài Sản" FieldName="TSHC_TenTaiSan" 
                                                                            Name="TSHC_TenTaiSan" ShowInCustomizationForm="True" VisibleIndex="3">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                            <CellStyle Font-Size="14px" HorizontalAlign="Center" VerticalAlign="Middle">
                                                                            </CellStyle>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Tình Trạng" FieldName="TSHC_TinhTrang" 
                                                                            Name="TSHC_TinhTrang" ShowInCustomizationForm="True" VisibleIndex="4">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                            <CellStyle Font-Size="14px" HorizontalAlign="Center" VerticalAlign="Middle">
                                                                            </CellStyle>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Xuất Xứ" FieldName="TSHC_XuatXu" 
                                                                            Name="TSHC_XuatXu" ShowInCustomizationForm="True" VisibleIndex="5">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                            <CellStyle Font-Size="14px" HorizontalAlign="Center" VerticalAlign="Middle">
                                                                            </CellStyle>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Thương Hiệu" FieldName="TSHC_ThuongHieu" 
                                                                            Name="TSHC_ThuongHieu" ShowInCustomizationForm="True" VisibleIndex="6">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                            <CellStyle Font-Size="14px" HorizontalAlign="Center" VerticalAlign="Middle">
                                                                            </CellStyle>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Ghi Chú" FieldName="TSHC_GhiChu" 
                                                                            Name="TSHC_GhiChu" ShowInCustomizationForm="True" VisibleIndex="7">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                            <CellStyle Font-Size="14px" HorizontalAlign="Center" VerticalAlign="Middle">
                                                                            </CellStyle>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn FieldName="TSHC_Ma" Name="TSHC_Ma" 
                                                                            ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Loại tài sản" FieldName="TSHC_LoaiTaiSan" 
                                                                            Name="TSHC_LoaiTaiSan" ShowInCustomizationForm="True" VisibleIndex="2">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                        </dx:GridViewDataTextColumn>
                                                                    </Columns>
                                                                </dx:ASPxGridView>
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                                <table class="style9">
                                                                    <tr>
                                                                        <td align="center">
                                                                            <dx:ASPxLabel ID="lbThongbao" runat="server" ForeColor="Red">
                                                                            </dx:ASPxLabel>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                                <table class="style9">
                                                                    <tr>
                                                                        <td align="right" class="style109">
                                                                            <dx:ASPxButton ID="btnThem" runat="server" Font-Size="16px" Text="Thêm" 
                                                                                Theme="Aqua" OnClick="btnThem_Click">
                                                                                <Image IconID="actions_insert_16x16">
                                                                                </Image>
                                                                            </dx:ASPxButton>
                                                                            &nbsp;&nbsp;&nbsp;
                                                                        </td>
                                                                        <td>
                                                                            <dx:ASPxButton ID="btnHuyTBDK" runat="server" Font-Size="16px" Text="Hủy" 
                                                                                Theme="Aqua" OnClick="btnHuyTBDK_Click">
                                                                                <Image IconID="actions_cancel_16x16">
                                                                                </Image>
                                                                            </dx:ASPxButton>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            </dx:ContentControl>
                                                        </ContentCollection>
                                                    </dx:TabPage>
                                                    <dx:TabPage Text="Xoá TT Thiết Bị Đi Kèm">
                                                        <ActiveTabStyle Font-Size="16px">
                                                        </ActiveTabStyle>
                                                        <TabStyle Font-Size="14px">
                                                        </TabStyle>
                                                        <ContentCollection>
                                                            <dx:ContentControl runat="server">
                                                            <br />
                                                                <dx:ASPxGridView ID="grv_ThietBiDiKem1" runat="server" 
                                                                    AutoGenerateColumns="False" EnableTheming="True" KeyFieldName="TSHC_Ma" 
                                                                    style="margin-bottom: 1px" Theme="Aqua" Width="100%">
                                                                    <SettingsPager PageSize="5">
                                                                    </SettingsPager>
                                                                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" 
                                                                        AllowInsert="False" />
                                                                    <Columns>
                                                                        <dx:GridViewCommandColumn Name="TSHC_Chon" SelectAllCheckboxMode="Page" 
                                                                            ShowInCustomizationForm="True" ShowSelectCheckbox="True" VisibleIndex="0">
                                                                        </dx:GridViewCommandColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Tên Tài Sản" FieldName="TSHC_TenTaiSan" 
                                                                            Name="TSHC_TenTaiSan" ShowInCustomizationForm="True" VisibleIndex="3">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                            <CellStyle Font-Size="14px" HorizontalAlign="Center" VerticalAlign="Middle">
                                                                            </CellStyle>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Tình Trạng" FieldName="TSHC_TinhTrang" 
                                                                            Name="TSHC_TinhTrang" ShowInCustomizationForm="True" VisibleIndex="4">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                            <CellStyle Font-Size="14px" HorizontalAlign="Center" VerticalAlign="Middle">
                                                                            </CellStyle>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Xuất Xứ" FieldName="TSHC_XuatXu" 
                                                                            Name="TSHC_XuatXu" ShowInCustomizationForm="True" VisibleIndex="5">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                            <CellStyle Font-Size="14px" HorizontalAlign="Center" VerticalAlign="Middle">
                                                                            </CellStyle>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Thương Hiệu" FieldName="TSHC_ThuongHieu" 
                                                                            Name="TSHC_ThuongHieu" ShowInCustomizationForm="True" VisibleIndex="6">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                            <CellStyle Font-Size="14px" HorizontalAlign="Center" VerticalAlign="Middle">
                                                                            </CellStyle>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Ghi Chú" FieldName="TSHC_GhiChu" 
                                                                            Name="TSHC_GhiChu" ShowInCustomizationForm="True" VisibleIndex="7">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                            <CellStyle Font-Size="14px" HorizontalAlign="Center" VerticalAlign="Middle">
                                                                            </CellStyle>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn FieldName="TSHC_Ma" Name="TSHC_Ma" 
                                                                            ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Loại tài sản" FieldName="TSHC_LoaiTaiSan" 
                                                                            Name="TSHC_LoaiTaiSan" ShowInCustomizationForm="True" VisibleIndex="2">
                                                                            <HeaderStyle Font-Bold="True" Font-Size="14px" HorizontalAlign="Center" 
                                                                                VerticalAlign="Middle" />
                                                                        </dx:GridViewDataTextColumn>
                                                                    </Columns>
                                                                </dx:ASPxGridView>
                                                            <br />
                                                            <br />
                                                            <br />
                                                               
                                                            <br />
                                                                <table class="style9">
                                                                    <tr>
                                                                        <td align="center">
                                                                       
                                                                            
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                                <table class="style9">
                                                                    <tr>
                                                                        <td align="right" class="style109">
                                                                            <dx:ASPxButton ID="btnXoaTBDK" runat="server" Font-Size="16px" Text="Xoá" 
                                                                                Theme="Aqua" OnClick="btnXoaTBDK_Click">
                                                                                <Image IconID="actions_deletelist2_16x16">
                                                                                </Image>
                                                                            </dx:ASPxButton>
                                                                          
                                                                            &nbsp;&nbsp;&nbsp;
                                                                          
                                                                        </td>
                                                                        <td>
                                                                            <dx:ASPxButton ID="btnHuyXoaTBDK" runat="server" Font-Size="16px" Text="Hủy" 
                                                                                Theme="Aqua">
                                                                                <Image IconID="actions_cancel_16x16">
                                                                                </Image>
                                                                            </dx:ASPxButton>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            </dx:ContentControl>
                                                        </ContentCollection>
                                                    </dx:TabPage>
                                                </tabpages>
                                            </dx:ASPxPageControl>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style13">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style51">
                                            <table class="dxeBinImgCPnlSys">
                                                <tr>
                                                    <td align="right" class="style106">
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style13">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style13">
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                            <td class="style14">
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>

</asp:Content>
