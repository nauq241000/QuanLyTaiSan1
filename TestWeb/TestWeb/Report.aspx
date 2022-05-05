<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="TestWeb.Report" %>
<%@ Register assembly="DevExpress.Web.v15.2, Version=15.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style9
        {
            width: 100%;
        }
        .style10
        {
            height: 23px;
        }
        .style11
        {
            height: 27px;
        }
        .style12
        {
            height: 99px;
        }
        .style13
        {
            width: 10%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style9">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" class="style10" 
                style="font-size: 20px; color: #0000FF; font-weight: bold;">
                GỬI YÊU CẦU HỖ TRỢ</td>
        </tr>
        <tr>
            <td class="style10">
            </td>
        </tr>
        <tr>
            <td>
                <table class="style9">
                    <tr>
                        <td width="25%">
                            &nbsp;</td>
                        <td width="10%">
                            <dx:ASPxLabel ID="ASPxLabel1" runat="server" Font-Bold="True" Font-Size="14px" 
                                Text="Địa điểm">
                            </dx:ASPxLabel>
                            <br />
                        </td>
                        <td width="10%">
                            <dx:ASPxLabel ID="ASPxLabel2" runat="server" Font-Size="14px" Text="Cơ sở">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td width="30%">
                            <dx:ASPxComboBox ID="cbDiaDiem" runat="server" Font-Size="14px" 
                                Width="100%" EnableTheming="True" Theme="Default" TextFormatString="{1}">
                                <Columns>
                                    <dx:ListBoxColumn Caption="Mã phòng" FieldName="QLP_Ma" Name="QLP_Ma" />
                                    <dx:ListBoxColumn Caption="Cơ sở" FieldName="QLP_CoSo" Name="QLP_CoSo" />
                                    <dx:ListBoxColumn Caption="Địa điểm" FieldName="QLP_DiaDiem" 
                                        Name="QLP_DiaDiem" />
                                    <dx:ListBoxColumn Caption="Tòa nhà" FieldName="QLP_ToaNha" Name="QLP_ToaNha" />
                                    <dx:ListBoxColumn Caption="Phòng" FieldName="QLP_TenPhong" 
                                        Name="QLP_TenPhong" />
                                    <dx:ListBoxColumn Caption="Ghi chú" FieldName="QLP_GhiChu" Name="QLP_GhiChu" />
                                </Columns>
                            </dx:ASPxComboBox>
                            <br />
                        </td>
                        <td width="25%">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="cbDiaDiem" ErrorMessage="Mời bạn nhập dữ liệu" 
                                ForeColor="Red"></asp:RequiredFieldValidator>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td width="25%">
                            &nbsp;</td>
                        <td width="10%">
                            &nbsp;</td>
                        <td width="10%">
                            <dx:ASPxLabel ID="ASPxLabel3" runat="server" Font-Size="14px" Text="Địa điểm">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td width="30%">
                            
                            <dx:ASPxLabel ID="lb_DiaDiem" runat="server" Font-Size="14px">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td width="25%">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td width="25%">
                            &nbsp;</td>
                        <td width="10%">
                            &nbsp;</td>
                        <td width="10%">
                            <dx:ASPxLabel ID="ASPxLabel4" runat="server" Font-Size="14px" Text="Tòa nhà">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td width="30%">
                            
                            <dx:ASPxLabel ID="lb_ToaNha" runat="server" Font-Size="14px">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td width="25%">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td width="25%">
                            &nbsp;</td>
                        <td width="10%">
                            &nbsp;</td>
                        <td width="10%">
                            <dx:ASPxLabel ID="ASPxLabel5" runat="server" Font-Size="14px" Text="Phòng">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td width="30%">
                            <dx:ASPxLabel ID="lb_Phong" runat="server" Font-Size="14px">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td width="25%">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td width="25%">
                            &nbsp;</td>
                        <td width="10%">
                            &nbsp;</td>
                        <td width="10%">
                            <dx:ASPxLabel ID="ASPxLabel6" runat="server" Font-Size="14px" Text="Ghi chú">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td width="30%">
                            <dx:ASPxTextBox ID="txtGhiChu" runat="server" Font-Size="14px" Width="100%" 
                                Theme="Default">
                            </dx:ASPxTextBox>
                            <br />
                        </td>
                        <td width="25%">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td width="25%">
                            &nbsp;</td>
                        <td width="10%">
                            <dx:ASPxLabel ID="ASPxLabel7" runat="server" Font-Bold="True" Font-Size="14px" 
                                Text="Nội dung lỗi">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td width="10%">
                            <dx:ASPxLabel ID="ASPxLabel8" runat="server" Font-Size="14px" Text="Nội dung">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td width="30%">
                            <dx:ASPxComboBox ID="cbNoiDung" runat="server" Font-Size="14px" Width="100%" 
                                Theme="Default">
                                <Items>
                                    <dx:ListEditItem Text="Hỏng" Value="0" />
                                </Items>
                            </dx:ASPxComboBox>
                            <br />
                        </td>
                        <td width="25%">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="cbNoiDung" ErrorMessage="Mời bạn nhập dữ liệu" 
                                ForeColor="Red"></asp:RequiredFieldValidator>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td width="25%">
                            &nbsp;</td>
                        <td width="10%">
                            &nbsp;</td>
                        <td width="10%" valign="top">
                            <dx:ASPxLabel ID="ASPxLabel9" runat="server" Font-Size="14px" Text="Mô tả">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td width="30%">
                            <dx:ASPxTextBox ID="txtMoTa" runat="server" Font-Size="14px" 
                                Theme="Default" Width="100%">
                            </dx:ASPxTextBox>
                            <br />
                        </td>
                        <td width="25%">
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ControlToValidate="txtMoTa" ErrorMessage="Mời bạn nhập dữ liệu" 
                                ForeColor="Red"></asp:RequiredFieldValidator>
                            &nbsp;<br />
                        </td>
                    </tr>
                    <tr>
                        <td class="style11" width="25%">
                        </td>
                        <td class="style11" width="10%">
                            <dx:ASPxLabel ID="ASPxLabel10" runat="server" Font-Bold="True" Font-Size="14px" 
                                Text="Đề xuất sửa chữa">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td class="style11" width="10%">
                            <dx:ASPxLabel ID="ASPxLabel11" runat="server" Font-Size="14px" 
                                Text="Thời gian dự kiến">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td class="style11" width="30%">
                            <dx:ASPxDateEdit ID="dtThoiGianDuKien" runat="server" Font-Size="14px" 
                                Theme="Default" Width="100%" DisplayFormatString="g">
                                <TimeSectionProperties Visible="True">
                                </TimeSectionProperties>
                            </dx:ASPxDateEdit>
                            <br />
                        </td>
                        <td class="style11" width="25%">
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                ControlToValidate="dtThoiGianDuKien" ErrorMessage="Mời bạn nhập dữ liệu" 
                                ForeColor="Red"></asp:RequiredFieldValidator>
                            &nbsp;<br />
                        </td>
                    </tr>
                    <tr>
                        <td class="style10" width="25%">
                            &nbsp;</td>
                        <td class="style10" width="10%">
                        </td>
                        <td class="style10" width="10%">
                            <dx:ASPxLabel ID="ASPxLabel12" runat="server" Font-Bold="True" Font-Size="14px" 
                                Text="Người hỗ trợ">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td class="style10" width="30%">
                            &nbsp;</td>
                        <td class="style10" width="25%">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style10" width="25%">
                        </td>
                        <td class="style10" width="10%">
                        </td>
                        <td class="style10" width="10%">
                            <dx:ASPxLabel ID="ASPxLabel14" runat="server" Font-Size="14px" 
                                Text="Mã nhân sự">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td class="style10" width="30%">
                            <dx:ASPxComboBox ID="cbMaNhanSu" runat="server" Font-Size="14px" 
                                Width="100%" EnableTheming="True" Theme="Default" TextFormatString="{0}">
                                <Columns>
                                    <dx:ListBoxColumn Caption="Mã nhân sự" FieldName="QLNS_Ma" Name="QLNS_Ma" />
                                    <dx:ListBoxColumn Caption="Họ tên" FieldName="QLNS_HoTen" Name="QLNS_HoTen" />
                                    <dx:ListBoxColumn Caption="Số điện thoại" FieldName="QLNS_SoDienThoai" 
                                        Name="QLNS_SoDienThoai" />
                                </Columns>
                            </dx:ASPxComboBox>
                            <br />
                        </td>
                        <td class="style10" width="25%">
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                ControlToValidate="cbMaNhanSu" ErrorMessage="Mời bạn nhập dữ liệu" 
                                ForeColor="Red"></asp:RequiredFieldValidator>
                            <br />
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style10" width="25%">
                        </td>
                        <td class="style10" width="10%">
                        </td>
                        <td class="style10" width="10%">
                            <dx:ASPxLabel ID="ASPxLabel15" runat="server" Font-Size="14px" Text="Họ tên">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td class="style10" width="30%">
                            
                            <dx:ASPxLabel ID="lb_HoTen" runat="server" Font-Size="14px">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td class="style10" width="25%">
                        </td>
                    </tr>
                    <tr>
                        <td width="25%">
                            &nbsp;</td>
                        <td width="10%">
                            &nbsp;</td>
                        <td width="10%">
                            <dx:ASPxLabel ID="ASPxLabel16" runat="server" Font-Size="14px" 
                                Text="Số điện thoại">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td width="30%">
                            
                            <dx:ASPxLabel ID="lb_SoDienThoai" runat="server" Font-Size="14px">
                            </dx:ASPxLabel>
                            <br />
                        </td>
                        <td width="25%">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td width="25%">
                            &nbsp;</td>
                        <td width="10%">
                            &nbsp;</td>
                        <td width="10%">
                            <dx:ASPxLabel ID="ASPxLabel13" runat="server" Font-Size="14px" Text="Ghi chú">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td width="30%">
                            <dx:ASPxTextBox ID="txtGhiChuHoTro" runat="server" Font-Size="14px" 
                                Width="100%">
                            </dx:ASPxTextBox>
                            <br />
                        </td>
                        <td width="25%">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td width="25%">
                            &nbsp;</td>
                        <td width="10%">
                            &nbsp;</td>
                        <td width="10%">
                            &nbsp;</td>
                        <td width="30%">
                            &nbsp;</td>
                        <td width="25%">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td width="25%">
                            &nbsp;</td>
                        <td width="10%">
                            &nbsp;</td>
                        <td width="10%">
                            &nbsp;</td>
                        <td width="30%">
                            &nbsp;</td>
                        <td width="25%">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td width="25%">
                            &nbsp;</td>
                        <td width="10%">
                            &nbsp;</td>
                        <td width="10%">
                            &nbsp;</td>
                        <td width="30%">
                            &nbsp;</td>
                        <td width="25%">
                            &nbsp;</td>
                    </tr>
                    
                    
                    
                    
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table class="style9">
                    <tr>
                        <td width="40%">
                            &nbsp;</td>
                        <td align="center" width="10%">
                            <dx:ASPxLabel ID="lbThongbao" runat="server" Font-Size="14px" ForeColor="Red" 
                                Visible="False">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                        </td>
                        <td align="center" width="10%">
                            &nbsp;</td>
                        <td width="40%">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table class="style9">
                    <tr>
                        <td width="35%">
                            &nbsp;</td>
                        <td align="center" class="style13">
                            <dx:ASPxButton ID="btnKiemtra" runat="server" Font-Size="16px" Text="Kiểm tra" 
                                Theme="Aqua" onclick="btnKiemtra_Click">
                                <Image IconID="programming_forcetesting_16x16">
                                </Image>
                            </dx:ASPxButton>
                        </td>
                        <td align="center" width="10%">
                            <dx:ASPxButton ID="btnGuiYeuCau" runat="server" Font-Size="16px" 
                                Text="Gửi yêu cầu" Theme="Aqua" onclick="btnGuiYeuCau_Click">
                                <Image IconID="contacts_mail_16x16devav">
                                </Image>
                            </dx:ASPxButton>
                        </td>
                        <td align="center" width="10%">
                            <dx:ASPxButton ID="btnHuy" runat="server" Font-Size="16px" Text="Hủy" 
                                Theme="Aqua" onclick="btnHuy_Click">
                                <Image IconID="actions_cancel_16x16">
                                </Image>
                            </dx:ASPxButton>
                        </td>
                        <td width="35%">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style12">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
