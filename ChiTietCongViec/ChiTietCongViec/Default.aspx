<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChiTietCongViec.Default" %>
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
            height: 22px;
        }
        .style12
        {
            height: 148px;
            font-style: italic;
        }
        .style13
        {
            height: 64px;
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
            <td align="center" style="font-size: 25px; font-weight: bold; color: #0000FF">
                CHI TIẾT CÔNG VIỆC</td>
        </tr>
        <tr>
            <td class="style11">
                <table class="style9">
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <table class="style9">
                                <tr>
                                    <td width="10%">
                                        &nbsp;</td>
                                    <td width="80%">
                                        <dx:ASPxGridView ID="ASPxGridView_ChiTietCongViec" runat="server" 
                                            AutoGenerateColumns="False" EnableTheming="True" Theme="Aqua" 
                                            Width="100%" KeyFieldName="THCV_Ma">
                                            <SettingsPager PageSize="15">
                                            </SettingsPager>
                                            <Settings HorizontalScrollBarMode="Visible" />
                                            <SettingsBehavior AllowSelectSingleRowOnly="True" />
                                            <SettingsSearchPanel Visible="True" />
                                            <Columns>
                                                <dx:GridViewCommandColumn SelectAllCheckboxMode="Page" 
                                                    ShowSelectCheckbox="True" VisibleIndex="0">
                                                    <CellStyle HorizontalAlign="Center">
                                                    </CellStyle>
                                                </dx:GridViewCommandColumn>
                                                <dx:GridViewDataTextColumn Caption="Mã" FieldName="THCV_Ma" Name="THCV_Ma" 
                                                    VisibleIndex="1" Width="75px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                    <CellStyle HorizontalAlign="Center" VerticalAlign="Middle">
                                                    </CellStyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Ngày thực hiện" 
                                                    FieldName="THCV_NgayThucHien" Name="THCV_NgayThucHien" VisibleIndex="2" 
                                                    Width="140px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Mã phòng" FieldName="QLP_Ma" Name="QLP_Ma" 
                                                    VisibleIndex="6" Width="75px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                    <CellStyle HorizontalAlign="Center" VerticalAlign="Middle">
                                                    </CellStyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Ngày đề nghị hoàn thành" 
                                                    FieldName="THCV_NgayDeNghiHoanThanh" Name="THCV_NgayDeNghiHoanThanh" 
                                                    VisibleIndex="5" Width="165px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Mức dộ ưu tiên" 
                                                    FieldName="THCV_MucDoUuTien" Name="THCV_MucDoUuTien" VisibleIndex="3" 
                                                    Width="110px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                    <CellStyle HorizontalAlign="Center" VerticalAlign="Middle">
                                                    </CellStyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Ngày yêu cầu" FieldName="THCV_NgayYeuCau" 
                                                    Name="THCV_NgayYeuCau" VisibleIndex="4" Width="142px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Cơ sở" FieldName="QLP_CoSo" Name="QLP_CoSo" 
                                                    VisibleIndex="7" Width="100px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Địa điểm" FieldName="QLP_DiaDiem" 
                                                    Name="QLP_DiaDiem" VisibleIndex="8" Width="220px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Tòa nhà" FieldName="QLP_ToaNha" 
                                                    Name="QLP_ToaNha" VisibleIndex="9" Width="100px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Phòng" FieldName="QLP_TenPhong" Name="QLP_TenPhong" 
                                                    VisibleIndex="10" Width="100px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Công việc thực hiện" 
                                                    FieldName="THCV_YeuCau" Name="THCV_YeuCau" 
                                                    VisibleIndex="11" Width="150px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Mô tả chi tiết công việc" 
                                                    FieldName="THCV_MoTaCongViec" Name="THCV_MoTaCongViec" VisibleIndex="12" 
                                                    Width="150px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Đánh giá" FieldName="THCV_DanhGia" 
                                                    Name="THCV_DanhGia" VisibleIndex="15" Width="100px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Đề xuất" FieldName="THCV_DeXuat" 
                                                    Name="THCV_DeXuat" VisibleIndex="17" Width="150px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Mã nhân sự " FieldName="QLNS_MaNSKT" 
                                                    Name="QLNS_MaNSKT" VisibleIndex="19" Width="100px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                    <CellStyle HorizontalAlign="Center" VerticalAlign="Middle">
                                                    </CellStyle>
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Tên nhân sự quản lý" FieldName="QLNS_HoTen" 
                                                    Name="QLNS_HoTen" VisibleIndex="20" Width="130px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Số điện thoại" FieldName="QLNS_SoDienThoai" 
                                                    Name="QLNS_SoDienThoai" VisibleIndex="21" Width="100px">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Thời gian hoàn thành" 
                                                    FieldName="THCV_ThoiGianKetThuc" Name="THCV_ThoiGianKetThuc" 
                                                    VisibleIndex="14" Width="140px">
                                                    <HeaderStyle Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Thời gian bắt đầu" 
                                                    FieldName="THCV_ThoiGianBatDau" Name="THCV_ThoiGianBatDau" 
                                                    VisibleIndex="13" Width="142px">
                                                    <HeaderStyle Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Kết quả thực hiện" 
                                                    FieldName="THCV_KetQuaThucHien" Name="THCV_KetQuaThucHien" 
                                                    VisibleIndex="16" Width="150px">
                                                    <HeaderStyle Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                                <dx:GridViewDataTextColumn Caption="Ghi chú" 
                                                    FieldName="THCV_GhiChuNguoiThucHien" Name="THCV_GhiChuNguoiThucHien" 
                                                    VisibleIndex="18" Width="150px">
                                                    <HeaderStyle Font-Bold="True" />
                                                </dx:GridViewDataTextColumn>
                                            </Columns>
                                        </dx:ASPxGridView>
                                    </td>
                                    <td width="10%">
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server" 
                                PaperKind="A4">
                            </dx:ASPxGridViewExporter>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                        <dx:ASPxLabel ID="lbThongBao" runat="server" Font-Size="14px" 
                                Text="">
                            </dx:ASPxLabel>
                            </td>
                    </tr>
                    <tr>
                        <td class="style13">
                            <table class="dxflInternalEditorTable_Aqua">
                                <tr>
                                    <td class="style10">
                                        </td>
                                    <td class="style10">
                                        </td>
                                    <td class="style10">
                                        </td>
                                    <td class="style10">
                                        </td>
                                    <td class="style10">
                                        </td>
                                    <td class="style10">
                                        </td>
                                    <td class="style10">
                                        </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td align="right" width="6%">
                            <dx:ASPxButton ID="btnRefresh" runat="server" Font-Size="16px" Text="Refresh" 
                                Theme="Aqua" onclick="btnRefresh_Click">
                                <Image IconID="actions_convert_16x16">
                                </Image>
                            </dx:ASPxButton>
                                    </td>
                                    <td align="right" width="11%">
                            <dx:ASPxButton ID="btnCapNhat" runat="server" Font-Size="16px" 
                                Text="Cập nhật trạng thái " Theme="Aqua" onclick="btnCapNhat_Click">
                                <Image IconID="scheduling_recurrence_16x16">
                                </Image>
                            </dx:ASPxButton>
                                    </td>
                                    <td align="right" width="5%">
                            <dx:ASPxButton ID="btnLuu" runat="server" Font-Size="16px" Text="Lưu" 
                                Theme="Aqua" onclick="btnLuu_Click">
                                <Image IconID="save_saveto_16x16">
                                </Image>
                            </dx:ASPxButton>
                                    </td>
                                    <td align="right" width="5%">
                            <dx:ASPxButton ID="btnHuy" runat="server" Font-Size="16px" Text="Hủy" 
                                Theme="Aqua" onclick="btnHuy_Click">
                                <Image IconID="actions_cancel_16x16">
                                </Image>
                            </dx:ASPxButton>
                                    </td>
                                    <td align="right" width="6%">
                            <dx:ASPxButton ID="btnExportExcel" runat="server" Font-Size="16px" Text="Export" 
                                Theme="Aqua" onclick="btnExportExcel_Click">
                                <Image IconID="actions_download_16x16">
                                </Image>
                            </dx:ASPxButton>
                                    </td>
                                    <td width="10%">
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
                        <td>
                            <table class="dxflInternalEditorTable_Aqua">
                                <tr>
                                    <td width="10%">
                                        &nbsp;</td>
                                    <td width="80%">
                                        <dx:ASPxPanel ID="ASPxPanel1" runat="server" style="margin-bottom: 0px" 
                                            Width="100%">
                                            <PanelCollection>
<dx:PanelContent runat="server">
    <table class="style9">
    <tr>
            <td width="20%">
               
                <br />
                <br />
            </td>
        <tr>
            <td width="20%">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <dx:ASPxLabel ID="ASPxLabel15" runat="server" Font-Size="14px" Text="Mã">
                </dx:ASPxLabel>
                <br />
                <br />
            </td>
            <td width="20%">
                <dx:ASPxLabel ID="lbTHCV_Ma" runat="server" Font-Size="14px">
                </dx:ASPxLabel>
                <br />
                <br />
            </td>
            <td width="20%">
                <dx:ASPxLabel ID="ASPxLabel16" runat="server" Font-Size="14px" Text="Địa điểm">
                </dx:ASPxLabel>
                <br />
                <br />
            </td>
            <td width="20%">
                <dx:ASPxLabel ID="lbDiaDiem" runat="server" Font-Size="14px">
                </dx:ASPxLabel>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style10" width="20%">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <dx:ASPxLabel ID="ASPxLabel17" runat="server" Font-Size="14px" 
                    Text="Ngày thực hiện">
                </dx:ASPxLabel>
                <br />
            </td>
            <td class="style10" width="20%">
                <dx:ASPxLabel ID="lbNgayThucHien" runat="server" Font-Size="14px">
                </dx:ASPxLabel>
                <br />
            </td>
            <td class="style10" width="20%">
                <dx:ASPxLabel ID="ASPxLabel18" runat="server" Font-Size="14px" Text="Phòng">
                </dx:ASPxLabel>
                <br />
            </td>
            <td class="style10" width="20%">
                <dx:ASPxLabel ID="lbPhong" runat="server" Font-Size="14px">
                </dx:ASPxLabel>
                <br />
            </td>
        </tr>
        <tr>
            <td width="20%">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <dx:ASPxLabel ID="ASPxLabel19" runat="server" Font-Size="14px" 
                    Text="Công việc thực hiện">
                </dx:ASPxLabel>
                <br />
            </td>
            <td width="20%">
                <dx:ASPxLabel ID="lbTenCongViec" runat="server" Font-Size="14px">
                </dx:ASPxLabel>
                <br />
            </td>
            <td width="20%" style="color: #FF0000">
                <dx:ASPxLabel ID="ASPxLabel20" runat="server" Font-Size="14px" Text="Đánh giá" 
                    ForeColor="Black">
                </dx:ASPxLabel>
                *<br />
            </td>
            <td width="20%">
                <br />
                <dx:ASPxComboBox ID="cb_DanhGia" runat="server" Font-Size="14px" 
                    SelectedIndex="0" Width="90%">
                    <Items>
                        <dx:ListEditItem Selected="True" Text="Hoàn thành" Value="Hoàn thành" />
                        <dx:ListEditItem Text="Không hoàn thành" Value="Không hoàn thành" />
                    </Items>
                </dx:ASPxComboBox>
                <br />
            </td>
        </tr>
        <tr>
            <td class="style10" width="20%" style="color: #FF0000">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <dx:ASPxLabel ID="ASPxLabel21" runat="server" Font-Size="14px" 
                    Text="Tổng thời gian thực hiện" ForeColor="Black">
                </dx:ASPxLabel>
                *<br />
            </td>
            <td class="style10" width="20%">
                <dx:ASPxTextBox ID="txtTongThoiGian" runat="server" Font-Size="14px" 
                    Width="90%">
                    <MaskSettings ErrorText="Nhập số giờ hoàn thành" Mask="&lt;0..10000&gt;" />
                </dx:ASPxTextBox>
            </td>
            <td class="style10" width="20%">
                <dx:ASPxLabel ID="ASPxLabel22" runat="server" Font-Size="14px" Text="Đề xuất">
                </dx:ASPxLabel>
                <br/>
            </td>
            <td class="style10" width="20%">
                <dx:ASPxTextBox ID="txtDeXuat" runat="server" Font-Size="14px" Width="90%">
                </dx:ASPxTextBox>
            </td>
        </tr>
        <tr>
            <td width="20%">
                &nbsp;</td>
            <td width="20%">
                &nbsp;</td>
            <td width="20%">
                &nbsp;</td>
            <td width="20%">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style10" width="20%" style="color: #FF0000">
                &nbsp;&nbsp;&nbsp; &nbsp;
                <dx:ASPxLabel ID="ASPxLabel23" runat="server" Font-Size="14px" 
                    Text="Thời gian bắt đầu" ForeColor="Black">
                </dx:ASPxLabel>
                *<br />
            </td>
            <td class="style10" width="20%">
                <dx:ASPxDateEdit ID="dtThoiGianBatDau" runat="server" DisplayFormatString="g" 
                    Font-Size="14px" Theme="Default" Width="90%">
                    <TimeSectionProperties Visible="True">
                    </TimeSectionProperties>
                </dx:ASPxDateEdit>
            </td>
            <td class="style10" width="20%" style="color: #FF0000">
                <dx:ASPxLabel ID="ASPxLabel24" runat="server" Font-Size="14px" 
                    Text="Thời gian hoàn thành" ForeColor="Black">
                </dx:ASPxLabel>
                *<br />
            </td>
            <td class="style10" width="20%">
                <dx:ASPxDateEdit ID="dtThoiGianKetThuc" runat="server" DisplayFormatString="g" 
                    Font-Size="14px" Theme="Default" Width="90%">
                    <TimeSectionProperties Visible="True">
                    </TimeSectionProperties>
                </dx:ASPxDateEdit>
            </td>
        </tr>
        <tr>
            <td width="20%">
                &nbsp;</td>
            <td width="20%">
                &nbsp;</td>
            <td width="20%">
                &nbsp;</td>
            <td width="20%">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style10" width="20%">
                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <dx:ASPxLabel ID="ASPxLabel25" runat="server" Font-Size="14px" 
                    Text="Kết quả thực hiện">
                </dx:ASPxLabel>
                <br />
            </td>
            <td class="style10" width="20%">
                <dx:ASPxTextBox ID="txtKetQuaThucHien" runat="server" Font-Size="14px" 
                    Width="90%">
                </dx:ASPxTextBox>
            </td>
            <td class="style10" width="20%">
                <dx:ASPxLabel ID="ASPxLabel26" runat="server" Font-Size="14px" Text="Ghi chú">
                </dx:ASPxLabel>
                <br />
            </td>
            <td class="style10" width="20%">
                <dx:ASPxTextBox ID="txtGhiChu" runat="server" Font-Size="14px" Width="90%">
                </dx:ASPxTextBox>
            </td>
        </tr>
        <tr>
            <td width="20%" class="style10">
                </td>
            <td width="20%" class="style10">
                </td>
            <td width="20%" class="style10">
                </td>
            <td width="20%" class="style10">
                </td>
        </tr>
        <tr>
        <td width="20%"></td></tr>
    </table>
    </dx:PanelContent>
</PanelCollection>
                                            <Border BorderColor="Black" BorderWidth="1px" />
                                        </dx:ASPxPanel>
                                    </td>
                                    <td width="10%">
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <table class="style9">
                    <tr>
                        <td width="20%">
                            &nbsp;</td>
                        <td width="15%">
                            &nbsp;</td>
                        <td width="15%">
                            &nbsp;</td>
                        <td align="center" width="15%">
                            &nbsp;</td>
                        <td width="15%">
                            &nbsp;</td>
                        <td width="20%">
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
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style12" ">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
