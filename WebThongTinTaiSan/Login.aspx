<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebThongTinTaiSan.Login" %>
<%@ Register assembly="DevExpress.Web.v15.2, Version=15.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
        .style1
        {
            width: 100%;
            height: 456px;
        }
        .style3
        {
            height: 23px;
        }
        .style5
        {
            width: 290px;
            height: 23px;
        }
        .style9
        {
            width: 134px;
        }
        .style10
        {
            width: 107px;
        }
        .style11
        {
            height: 24px;
        }
        .style12
        {
            width: 107px;
            height: 23px;
        }
        .style13
        {
            height: 23px;
        }
        .style14
        {
            height: 23px;
            width: 445px;
        }
        .style15
        {
            height: 211px;
        }
        .style16
        {
            width: 510px;
        }
        .style17
        {
            height: 23px;
            width: 510px;
        }
        .style18
        {
            height: 211px;
            width: 510px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style1">
        <tr>
            <td align="center" style="font-size: 22px; color: #0000FF; font-weight: bold;" 
                class="style11">
                QUẢN LÝ ĐỒ DÙNG</td>
        </tr>
        <tr>
        <td> 
            <br />
            </td>
        </tr>
        <tr>
            <td>
                <table class="style1">
                    <tr>
                        <td class="style16">
                            &nbsp;</td>
                        <td class="style10" width="8%" style="font-size: 17px">
                            Tên đăng nhập<br />
                            <br />
                        </td>
                        <td>

                            <br />
                            <dx:ASPxTextBox ID="txtuser" runat="server" Width="238px">
                            </dx:ASPxTextBox>
                            <br />
                        </td>
                        <td width="25%">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtuser" ErrorMessage="Mời bạn nhập dữ liệu" 
                                ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class= style17>
                        </td>
                        <td  width="8%" style="font-size: 17px" class="style13">
                            Mật khẩu</td>
                        <td class="style14">
                            <dx:ASPxTextBox ID="txtpass" runat="server" Height="21px" Width="236px" 
                                Password="True">
                                <HelpTextSettings DisplayMode="Popup">
                                </HelpTextSettings>
                            </dx:ASPxTextBox>
                            
                        </td>
                        <td class="style14" width="25%">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txtpass" ErrorMessage="Mời bạn nhập dữ liệu" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style17">
                            </td>
                        <td class="style12" width="8%">
                            </td>
                        <td class="style3">
                             <dx:ASPxCaptcha ID="ASPxCaptcha3" runat="server" style="margin-top: 28px">
                                <ValidationSettings ErrorText="Mã không hợp lệ">
                                </ValidationSettings>
                                <TextBox Position="Bottom" ShowLabel="False" />
                                <ChallengeImage ForegroundColor="#000000"></ChallengeImage>
                            </dx:ASPxCaptcha>
                            <br />
                        </td>
                        <td width="25%" class="style3">
                            </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            &nbsp;</td>
                        <td  width="8%">
                            &nbsp;</td>
                        <td>
                            <table class="dxflInternalEditorTable">
                                <tr>
                                    <td class="style9">
                                        <dx:ASPxButton ID="btnDangnhap" runat="server"  Height="21px" Text="Đăng nhập" 
                                            Width="123px" Font-Size="16px"  Theme="Aqua" onclick="btnDangnhap_Click">
                                        </dx:ASPxButton>
                                        
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </td>
                        <td width="25%">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style17">
                            </td>
                        <td  width="8%" class="style13">
                            </td>
                        <td class="style13">
                            <dx:ASPxLabel ID="lbThongbao" runat="server">
                            </dx:ASPxLabel>
                            
                            </td>
                        <td  width="25%" class="style13">
                            </td>
                    </tr>
                    <tr >
                        <td class="style18">
                            </td>
                        <td  width="8%" class="style15">
                            </td>
                        <td class="style15">
                            <br />
                        </td>
                        <td width="25%" class="style15">
                            </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
