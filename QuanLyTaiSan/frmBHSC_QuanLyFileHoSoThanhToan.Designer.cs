namespace QuanLyTaiSan
{
    partial class frmBHSC_QuanLyFileHoSoThanhToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBHSC_QuanLyFileHoSoThanhToan));
            this.gridControl_QuanLyFileHoSoThanhToan = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView_QuanLyFileHoSoThanhToan = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.QLFHSTT_Chon = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemCheckEdit_QLNS_Chon = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.QLFHSTT_Ma = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.QLFHSTT_SoHoSo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.QLFHSTT_NgayHoSo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.QLFHSTT_TenFile = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.btn_Tenfile = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.QLFHSTT_DataFile = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.QLFHSTT_GhiChu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnClear = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnDown = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDownload = new DevExpress.XtraBars.BarButtonItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_QuanLyFileHoSoThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView_QuanLyFileHoSoThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_QLNS_Chon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Tenfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_QuanLyFileHoSoThanhToan
            // 
            this.gridControl_QuanLyFileHoSoThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_QuanLyFileHoSoThanhToan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_QuanLyFileHoSoThanhToan.Location = new System.Drawing.Point(0, 24);
            this.gridControl_QuanLyFileHoSoThanhToan.MainView = this.bandedGridView_QuanLyFileHoSoThanhToan;
            this.gridControl_QuanLyFileHoSoThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_QuanLyFileHoSoThanhToan.Name = "gridControl_QuanLyFileHoSoThanhToan";
            this.gridControl_QuanLyFileHoSoThanhToan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit_QLNS_Chon,
            this.btn_Tenfile});
            this.gridControl_QuanLyFileHoSoThanhToan.Size = new System.Drawing.Size(1127, 639);
            this.gridControl_QuanLyFileHoSoThanhToan.TabIndex = 8;
            this.gridControl_QuanLyFileHoSoThanhToan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView_QuanLyFileHoSoThanhToan});
            // 
            // bandedGridView_QuanLyFileHoSoThanhToan
            // 
            this.bandedGridView_QuanLyFileHoSoThanhToan.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightYellow;
            this.bandedGridView_QuanLyFileHoSoThanhToan.Appearance.SelectedRow.Options.UseBackColor = true;
            this.bandedGridView_QuanLyFileHoSoThanhToan.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.gridBand7});
            this.bandedGridView_QuanLyFileHoSoThanhToan.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.QLFHSTT_Chon,
            this.QLFHSTT_Ma,
            this.QLFHSTT_SoHoSo,
            this.QLFHSTT_NgayHoSo,
            this.QLFHSTT_TenFile,
            this.QLFHSTT_DataFile,
            this.QLFHSTT_GhiChu});
            this.bandedGridView_QuanLyFileHoSoThanhToan.GridControl = this.gridControl_QuanLyFileHoSoThanhToan;
            this.bandedGridView_QuanLyFileHoSoThanhToan.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.bandedGridView_QuanLyFileHoSoThanhToan.Name = "bandedGridView_QuanLyFileHoSoThanhToan";
            this.bandedGridView_QuanLyFileHoSoThanhToan.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.bandedGridView_QuanLyFileHoSoThanhToan.OptionsBehavior.AutoExpandAllGroups = true;
            this.bandedGridView_QuanLyFileHoSoThanhToan.OptionsSelection.MultiSelect = true;
            this.bandedGridView_QuanLyFileHoSoThanhToan.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.bandedGridView_QuanLyFileHoSoThanhToan.OptionsView.ColumnAutoWidth = false;
            this.bandedGridView_QuanLyFileHoSoThanhToan.OptionsView.EnableAppearanceEvenRow = true;
            this.bandedGridView_QuanLyFileHoSoThanhToan.OptionsView.EnableAppearanceOddRow = true;
            this.bandedGridView_QuanLyFileHoSoThanhToan.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.bandedGridView_QuanLyFileHoSoThanhToan.OptionsView.RowAutoHeight = true;
            this.bandedGridView_QuanLyFileHoSoThanhToan.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridView_QuanLyFileHoSoThanhToan.OptionsView.ShowFooter = true;
            this.bandedGridView_QuanLyFileHoSoThanhToan.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.bandedGridView_QuanLyFileHoSoThanhToan.OptionsView.ShowGroupPanel = false;
            this.bandedGridView_QuanLyFileHoSoThanhToan.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.True;
            this.bandedGridView_QuanLyFileHoSoThanhToan.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.bandedGridView_QuanLyFileHoSoThanhToan_PopupMenuShowing);
            // 
            // gridBand2
            // 
            this.gridBand2.Columns.Add(this.QLFHSTT_Chon);
            this.gridBand2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 0;
            this.gridBand2.Width = 60;
            // 
            // QLFHSTT_Chon
            // 
            this.QLFHSTT_Chon.AppearanceCell.Options.UseTextOptions = true;
            this.QLFHSTT_Chon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLFHSTT_Chon.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHSTT_Chon.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QLFHSTT_Chon.AppearanceHeader.Options.UseFont = true;
            this.QLFHSTT_Chon.AppearanceHeader.Options.UseTextOptions = true;
            this.QLFHSTT_Chon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLFHSTT_Chon.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHSTT_Chon.Caption = "Chọn";
            this.QLFHSTT_Chon.ColumnEdit = this.repositoryItemCheckEdit_QLNS_Chon;
            this.QLFHSTT_Chon.FieldName = "QLFHSTT_Chon";
            this.QLFHSTT_Chon.Name = "QLFHSTT_Chon";
            this.QLFHSTT_Chon.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TSYC_Chon", "{0}")});
            this.QLFHSTT_Chon.Visible = true;
            this.QLFHSTT_Chon.Width = 60;
            // 
            // repositoryItemCheckEdit_QLNS_Chon
            // 
            this.repositoryItemCheckEdit_QLNS_Chon.AutoHeight = false;
            this.repositoryItemCheckEdit_QLNS_Chon.DisplayValueChecked = "True";
            this.repositoryItemCheckEdit_QLNS_Chon.DisplayValueUnchecked = "False";
            this.repositoryItemCheckEdit_QLNS_Chon.Name = "repositoryItemCheckEdit_QLNS_Chon";
            // 
            // gridBand7
            // 
            this.gridBand7.Columns.Add(this.QLFHSTT_Ma);
            this.gridBand7.Columns.Add(this.QLFHSTT_SoHoSo);
            this.gridBand7.Columns.Add(this.QLFHSTT_NgayHoSo);
            this.gridBand7.Columns.Add(this.QLFHSTT_TenFile);
            this.gridBand7.Columns.Add(this.QLFHSTT_DataFile);
            this.gridBand7.Columns.Add(this.QLFHSTT_GhiChu);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 1;
            this.gridBand7.Width = 564;
            // 
            // QLFHSTT_Ma
            // 
            this.QLFHSTT_Ma.AppearanceCell.Options.UseTextOptions = true;
            this.QLFHSTT_Ma.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLFHSTT_Ma.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHSTT_Ma.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QLFHSTT_Ma.AppearanceHeader.Options.UseFont = true;
            this.QLFHSTT_Ma.AppearanceHeader.Options.UseTextOptions = true;
            this.QLFHSTT_Ma.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLFHSTT_Ma.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHSTT_Ma.Caption = "Mã";
            this.QLFHSTT_Ma.FieldName = "QLFHSTT_Ma";
            this.QLFHSTT_Ma.Name = "QLFHSTT_Ma";
            this.QLFHSTT_Ma.Visible = true;
            this.QLFHSTT_Ma.Width = 67;
            // 
            // QLFHSTT_SoHoSo
            // 
            this.QLFHSTT_SoHoSo.AppearanceCell.Options.UseTextOptions = true;
            this.QLFHSTT_SoHoSo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.QLFHSTT_SoHoSo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHSTT_SoHoSo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QLFHSTT_SoHoSo.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.QLFHSTT_SoHoSo.AppearanceHeader.Options.UseFont = true;
            this.QLFHSTT_SoHoSo.AppearanceHeader.Options.UseForeColor = true;
            this.QLFHSTT_SoHoSo.AppearanceHeader.Options.UseTextOptions = true;
            this.QLFHSTT_SoHoSo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLFHSTT_SoHoSo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHSTT_SoHoSo.Caption = "Số hồ sơ";
            this.QLFHSTT_SoHoSo.FieldName = "QLFHSTT_SoHoSo";
            this.QLFHSTT_SoHoSo.Name = "QLFHSTT_SoHoSo";
            this.QLFHSTT_SoHoSo.Visible = true;
            this.QLFHSTT_SoHoSo.Width = 142;
            // 
            // QLFHSTT_NgayHoSo
            // 
            this.QLFHSTT_NgayHoSo.AppearanceCell.Options.UseTextOptions = true;
            this.QLFHSTT_NgayHoSo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.QLFHSTT_NgayHoSo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHSTT_NgayHoSo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QLFHSTT_NgayHoSo.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.QLFHSTT_NgayHoSo.AppearanceHeader.Options.UseFont = true;
            this.QLFHSTT_NgayHoSo.AppearanceHeader.Options.UseForeColor = true;
            this.QLFHSTT_NgayHoSo.AppearanceHeader.Options.UseTextOptions = true;
            this.QLFHSTT_NgayHoSo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLFHSTT_NgayHoSo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHSTT_NgayHoSo.Caption = "Ngày hồ sơ";
            this.QLFHSTT_NgayHoSo.FieldName = "QLFHSTT_NgayHoSo";
            this.QLFHSTT_NgayHoSo.Name = "QLFHSTT_NgayHoSo";
            this.QLFHSTT_NgayHoSo.Visible = true;
            this.QLFHSTT_NgayHoSo.Width = 145;
            // 
            // QLFHSTT_TenFile
            // 
            this.QLFHSTT_TenFile.AppearanceCell.Options.UseTextOptions = true;
            this.QLFHSTT_TenFile.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.QLFHSTT_TenFile.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHSTT_TenFile.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QLFHSTT_TenFile.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.QLFHSTT_TenFile.AppearanceHeader.Options.UseFont = true;
            this.QLFHSTT_TenFile.AppearanceHeader.Options.UseForeColor = true;
            this.QLFHSTT_TenFile.AppearanceHeader.Options.UseTextOptions = true;
            this.QLFHSTT_TenFile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLFHSTT_TenFile.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHSTT_TenFile.Caption = "File hợp đồng";
            this.QLFHSTT_TenFile.ColumnEdit = this.btn_Tenfile;
            this.QLFHSTT_TenFile.FieldName = "QLFHSTT_TenFile";
            this.QLFHSTT_TenFile.Name = "QLFHSTT_TenFile";
            this.QLFHSTT_TenFile.Visible = true;
            this.QLFHSTT_TenFile.Width = 135;
            // 
            // btn_Tenfile
            // 
            this.btn_Tenfile.AutoHeight = false;
            this.btn_Tenfile.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btn_Tenfile.Name = "btn_Tenfile";
            this.btn_Tenfile.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_Tenfile_ButtonClick);
            // 
            // QLFHSTT_DataFile
            // 
            this.QLFHSTT_DataFile.AppearanceCell.Options.UseTextOptions = true;
            this.QLFHSTT_DataFile.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLFHSTT_DataFile.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHSTT_DataFile.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLFHSTT_DataFile.AppearanceHeader.Options.UseFont = true;
            this.QLFHSTT_DataFile.AppearanceHeader.Options.UseTextOptions = true;
            this.QLFHSTT_DataFile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.QLFHSTT_DataFile.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHSTT_DataFile.Caption = "Data file hợp đồng";
            this.QLFHSTT_DataFile.FieldName = "QLFHSTT_DataFile";
            this.QLFHSTT_DataFile.Name = "QLFHSTT_DataFile";
            this.QLFHSTT_DataFile.Width = 105;
            // 
            // QLFHSTT_GhiChu
            // 
            this.QLFHSTT_GhiChu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLFHSTT_GhiChu.AppearanceCell.Options.UseFont = true;
            this.QLFHSTT_GhiChu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.QLFHSTT_GhiChu.AppearanceHeader.Options.UseFont = true;
            this.QLFHSTT_GhiChu.Caption = "Ghi chú";
            this.QLFHSTT_GhiChu.FieldName = "QLFHSTT_GhiChu";
            this.QLFHSTT_GhiChu.Name = "QLFHSTT_GhiChu";
            this.QLFHSTT_GhiChu.Visible = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnRefresh,
            this.btnClear,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnUndo,
            this.btnDown,
            this.barButtonItem9,
            this.btnDownload});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClear, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDown, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Glyph")));
            this.btnRefresh.Id = 0;
            this.btnRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.LargeGlyph")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnClear
            // 
            this.btnClear.Caption = "Clear";
            this.btnClear.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClear.Glyph")));
            this.btnClear.Id = 1;
            this.btnClear.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnClear.LargeGlyph")));
            this.btnClear.Name = "btnClear";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThem.Glyph")));
            this.btnThem.Id = 2;
            this.btnThem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThem.LargeGlyph")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSua.Glyph")));
            this.btnSua.Id = 3;
            this.btnSua.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSua.LargeGlyph")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 4;
            this.btnXoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.LargeGlyph")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLuu.Glyph")));
            this.btnLuu.Id = 5;
            this.btnLuu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLuu.LargeGlyph")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUndo.Glyph")));
            this.btnUndo.Id = 6;
            this.btnUndo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnUndo.LargeGlyph")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnDown
            // 
            this.btnDown.Caption = "Download";
            this.btnDown.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDown.Glyph")));
            this.btnDown.Id = 7;
            this.btnDown.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDown.LargeGlyph")));
            this.btnDown.Name = "btnDown";
            this.btnDown.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDown_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1127, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 663);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1127, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 639);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1127, 24);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 639);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 8;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // btnDownload
            // 
            this.btnDownload.Caption = "Download";
            this.btnDownload.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDownload.Glyph")));
            this.btnDownload.Id = 9;
            this.btnDownload.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDownload.LargeGlyph")));
            this.btnDownload.Name = "btnDownload";
            // 
            // frmBHSC_QuanLyFileHoSoThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 663);
            this.Controls.Add(this.gridControl_QuanLyFileHoSoThanhToan);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBHSC_QuanLyFileHoSoThanhToan";
            this.Text = "Quản lý file hồ sơ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBHSC_QuanLyFileHoSoThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_QuanLyFileHoSoThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView_QuanLyFileHoSoThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_QLNS_Chon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Tenfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_QuanLyFileHoSoThanhToan;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView_QuanLyFileHoSoThanhToan;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLFHSTT_Chon;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_QLNS_Chon;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLFHSTT_Ma;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLFHSTT_SoHoSo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLFHSTT_NgayHoSo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLFHSTT_TenFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_Tenfile;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLFHSTT_DataFile;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLFHSTT_GhiChu;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnClear;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnDown;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem btnDownload;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}