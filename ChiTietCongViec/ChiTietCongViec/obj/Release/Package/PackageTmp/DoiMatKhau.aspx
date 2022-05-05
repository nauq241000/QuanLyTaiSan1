<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="DoiMatKhau.aspx.cs" Inherits="ChiTietCongViec.DoiMatKhau" %>
<%@ Register assembly="DevExpress.Web.v15.2, Version=15.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <style type="text/css">
        .style9
        {
            height: 53px;
        }
        .style10
        {
            height: 23px;
        }
        .style11
        {
            height: 23px;
            width: 183px;
        }
        .style15
        {
            width: 299px;
            height: 37px;
        }
        .style16
        {
            width: 183px;
        }
        .style17
        {
            height: 62px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="dx-justification" style="height: 571px">
        <tr>
            <td class="style5" width="25%">
                &nbsp;</td>
            <td width="50%">
                <table class="dx-justification">
                    <tr>
                        <td class="style9" 
                            
                            style="background-color: #0066FF; color: #FFFFFF; font-size: 20px; text-align: center; font-weight: bold">
                            ĐỔI MẬT KHẨU</td>
                    </tr>
                    <tr>
                        <td style="background-color: #DAE4FE" class="style17">
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td style="background-color: #DAE4FE">
                            <table class="dx-justification">
                                <tr>
                                    <td class="style11" width="30%">
                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                        <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Mật khẩu cũ" 
                                            Font-Size="14px">
                                        </dx:ASPxLabel>
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                    </td>
                                    <td class="style10" align="center" width="70%">
                                        <dx:ASPxTextBox ID="txtmkcu" runat="server" Font-Size="14px" Height="26px" 
                                            Width="289px" Password="True">
                                        </dx:ASPxTextBox>
                                        <br />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                            ControlToValidate="txtmkcu" ErrorMessage="Vui lòng nhập dữ liệu" 
                                            ForeColor="Red"></asp:RequiredFieldValidator>
                                        <br />
                                        <br />
                                    </td>
                                    
                                </tr>
                                <tr>
                                    <td class="style16" width="30%">
                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                        <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Mật khẩu mới" 
                                            Font-Size="14px">
                                        </dx:ASPxLabel>
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                    </td>
                                    <td align="center" width="70%">
                                        <dx:ASPxTextBox ID="txtmkmoi" runat="server" Font-Size="14px" Height="16px" 
                                            Width="290px" Password="True">
                                        </dx:ASPxTextBox>
                                        <br />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                            ControlToValidate="txtmkmoi" ErrorMessage="Vui lòng nhập dữ liệu" 
                                            ForeColor="Red"></asp:RequiredFieldValidator>
                                        <br />
                                        <br />
                                    </td>
                                    
                                </tr>
                                <tr>
                                    <td class="style16" width="30%">
                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                        <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Nhập lại mật khẩu " 
                                            Font-Size="14px">
                                        </dx:ASPxLabel>
                                        <br />
                                        <br />
                                        <br />
                                    </td>
                                    <td align="center" width="70%">
                                        <dx:ASPxTextBox ID="txtnhaplaimk" runat="server" Font-Size="14px" Height="16px" 
                                            Width="291px" Password="True">
                                        </dx:ASPxTextBox>
                                        <br />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                            ControlToValidate="txtnhaplaimk" ErrorMessage="Vui lòng nhập dữ liệu" 
                                            ForeColor="Red"></asp:RequiredFieldValidator>
                                        <br />
                                    </td>
                                    
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background-color: #DAE4FE" align="center">
                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                ControlToCompare="txtmkmoi" ControlToValidate="txtnhaplaimk" 
                                ErrorMessage="Mật khẩu nhập lại không khớp" ForeColor="Red"></asp:CompareValidator>
                        </td>
                    </tr>
                     <tr>
                        <td style="background-color: #DAE4FE" align="center">
                            <dx:ASPxLabel ID="lbThongbao" runat="server" Visible="False">
                            </dx:ASPxLabel>
                            <br />
                            <br />
                            </td>
                    </tr>
                    <tr>
                        <td style="background-color: #DAE4FE">
                            <table class="dx-justification">
                                <tr>
                                    <td class="style15" align="center">
                                        <dx:ASPxButton ID="btnLuu" runat="server" Font-Size="14px" Height="29px" 
                                            Text="Lưu" Theme="MetropolisBlue" Width="126px" onclick="btnLuu_Click">
                                        </dx:ASPxButton>
                                    </td>
                                   
                                </tr>
                            </table>
                            <br />
                        </td>
                    </tr>
                </table>
            </td>
            <td width="25%">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
