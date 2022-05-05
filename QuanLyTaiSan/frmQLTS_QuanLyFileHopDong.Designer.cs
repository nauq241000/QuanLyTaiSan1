namespace QuanLyTaiSan
{
    partial class frmQLTS_QuanLyFileHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTS_QuanLyFileHopDong));
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
            this.gridControl_QuanLyFileHopDong = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView_QuanLyFileHopDong = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.QLFHD_Chon = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemCheckEdit_QLNS_Chon = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.QLFHD_Ma = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.QLFHD_SoHopDong = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.QLFHD_NgayHopDong = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.QLFHD_TenFileHopDong = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.btn_Tenfile = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.QLFHD_DataFileHopDong = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.QLFHD_GhiChu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_QuanLyFileHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView_QuanLyFileHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_QLNS_Chon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Tenfile)).BeginInit();
            this.SuspendLayout();
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
            this.barDockControlTop.Size = new System.Drawing.Size(1013, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 551);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1013, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 527);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1013, 24);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 527);
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
            // gridControl_QuanLyFileHopDong
            // 
            this.gridControl_QuanLyFileHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_QuanLyFileHopDong.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_QuanLyFileHopDong.Location = new System.Drawing.Point(0, 24);
            this.gridControl_QuanLyFileHopDong.MainView = this.bandedGridView_QuanLyFileHopDong;
            this.gridControl_QuanLyFileHopDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_QuanLyFileHopDong.MenuManager = this.barManager1;
            this.gridControl_QuanLyFileHopDong.Name = "gridControl_QuanLyFileHopDong";
            this.gridControl_QuanLyFileHopDong.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit_QLNS_Chon,
            this.btn_Tenfile});
            this.gridControl_QuanLyFileHopDong.Size = new System.Drawing.Size(1013, 527);
            this.gridControl_QuanLyFileHopDong.TabIndex = 7;
            this.gridControl_QuanLyFileHopDong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView_QuanLyFileHopDong});
            // 
            // bandedGridView_QuanLyFileHopDong
            // 
            this.bandedGridView_QuanLyFileHopDong.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightYellow;
            this.bandedGridView_QuanLyFileHopDong.Appearance.SelectedRow.Options.UseBackColor = true;
            this.bandedGridView_QuanLyFileHopDong.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.gridBand7});
            this.bandedGridView_QuanLyFileHopDong.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.QLFHD_Chon,
            this.QLFHD_Ma,
            this.QLFHD_SoHopDong,
            this.QLFHD_NgayHopDong,
            this.QLFHD_TenFileHopDong,
            this.QLFHD_DataFileHopDong,
            this.QLFHD_GhiChu});
            this.bandedGridView_QuanLyFileHopDong.GridControl = this.gridControl_QuanLyFileHopDong;
            this.bandedGridView_QuanLyFileHopDong.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.bandedGridView_QuanLyFileHopDong.Name = "bandedGridView_QuanLyFileHopDong";
            this.bandedGridView_QuanLyFileHopDong.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.bandedGridView_QuanLyFileHopDong.OptionsBehavior.AutoExpandAllGroups = true;
            this.bandedGridView_QuanLyFileHopDong.OptionsSelection.MultiSelect = true;
            this.bandedGridView_QuanLyFileHopDong.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.bandedGridView_QuanLyFileHopDong.OptionsView.ColumnAutoWidth = false;
            this.bandedGridView_QuanLyFileHopDong.OptionsView.EnableAppearanceEvenRow = true;
            this.bandedGridView_QuanLyFileHopDong.OptionsView.EnableAppearanceOddRow = true;
            this.bandedGridView_QuanLyFileHopDong.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.bandedGridView_QuanLyFileHopDong.OptionsView.RowAutoHeight = true;
            this.bandedGridView_QuanLyFileHopDong.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridView_QuanLyFileHopDong.OptionsView.ShowFooter = true;
            this.bandedGridView_QuanLyFileHopDong.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.bandedGridView_QuanLyFileHopDong.OptionsView.ShowGroupPanel = false;
            this.bandedGridView_QuanLyFileHopDong.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.True;
            this.bandedGridView_QuanLyFileHopDong.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.bandedGridView_TaiSanHienCo_PopupMenuShowing);
            // 
            // gridBand2
            // 
            this.gridBand2.Columns.Add(this.QLFHD_Chon);
            this.gridBand2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 0;
            this.gridBand2.Width = 60;
            // 
            // QLFHD_Chon
            // 
            this.QLFHD_Chon.AppearanceCell.Options.UseTextOptions = true;
            this.QLFHD_Chon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLFHD_Chon.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHD_Chon.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QLFHD_Chon.AppearanceHeader.Options.UseFont = true;
            this.QLFHD_Chon.AppearanceHeader.Options.UseTextOptions = true;
            this.QLFHD_Chon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLFHD_Chon.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHD_Chon.Caption = "Chọn";
            this.QLFHD_Chon.ColumnEdit = this.repositoryItemCheckEdit_QLNS_Chon;
            this.QLFHD_Chon.FieldName = "QLFHD_Chon";
            this.QLFHD_Chon.Name = "QLFHD_Chon";
            this.QLFHD_Chon.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TSYC_Chon", "{0}")});
            this.QLFHD_Chon.Visible = true;
            this.QLFHD_Chon.Width = 60;
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
            this.gridBand7.Columns.Add(this.QLFHD_Ma);
            this.gridBand7.Columns.Add(this.QLFHD_SoHopDong);
            this.gridBand7.Columns.Add(this.QLFHD_NgayHopDong);
            this.gridBand7.Columns.Add(this.QLFHD_TenFileHopDong);
            this.gridBand7.Columns.Add(this.QLFHD_DataFileHopDong);
            this.gridBand7.Columns.Add(this.QLFHD_GhiChu);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 1;
            this.gridBand7.Width = 564;
            // 
            // QLFHD_Ma
            // 
            this.QLFHD_Ma.AppearanceCell.Options.UseTextOptions = true;
            this.QLFHD_Ma.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLFHD_Ma.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHD_Ma.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QLFHD_Ma.AppearanceHeader.Options.UseFont = true;
            this.QLFHD_Ma.AppearanceHeader.Options.UseTextOptions = true;
            this.QLFHD_Ma.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLFHD_Ma.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHD_Ma.Caption = "Mã";
            this.QLFHD_Ma.FieldName = "QLFHD_Ma";
            this.QLFHD_Ma.Name = "QLFHD_Ma";
            this.QLFHD_Ma.Visible = true;
            this.QLFHD_Ma.Width = 67;
            // 
            // QLFHD_SoHopDong
            // 
            this.QLFHD_SoHopDong.AppearanceCell.Options.UseTextOptions = true;
            this.QLFHD_SoHopDong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.QLFHD_SoHopDong.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHD_SoHopDong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QLFHD_SoHopDong.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.QLFHD_SoHopDong.AppearanceHeader.Options.UseFont = true;
            this.QLFHD_SoHopDong.AppearanceHeader.Options.UseForeColor = true;
            this.QLFHD_SoHopDong.AppearanceHeader.Options.UseTextOptions = true;
            this.QLFHD_SoHopDong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLFHD_SoHopDong.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHD_SoHopDong.Caption = "Số hợp đồng";
            this.QLFHD_SoHopDong.FieldName = "QLFHD_SoHopDong";
            this.QLFHD_SoHopDong.Name = "QLFHD_SoHopDong";
            this.QLFHD_SoHopDong.Visible = true;
            this.QLFHD_SoHopDong.Width = 142;
            // 
            // QLFHD_NgayHopDong
            // 
            this.QLFHD_NgayHopDong.AppearanceCell.Options.UseTextOptions = true;
            this.QLFHD_NgayHopDong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.QLFHD_NgayHopDong.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHD_NgayHopDong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QLFHD_NgayHopDong.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.QLFHD_NgayHopDong.AppearanceHeader.Options.UseFont = true;
            this.QLFHD_NgayHopDong.AppearanceHeader.Options.UseForeColor = true;
            this.QLFHD_NgayHopDong.AppearanceHeader.Options.UseTextOptions = true;
            this.QLFHD_NgayHopDong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLFHD_NgayHopDong.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHD_NgayHopDong.Caption = "Ngày hợp đồng";
            this.QLFHD_NgayHopDong.FieldName = "QLFHD_NgayHopDong";
            this.QLFHD_NgayHopDong.Name = "QLFHD_NgayHopDong";
            this.QLFHD_NgayHopDong.Visible = true;
            this.QLFHD_NgayHopDong.Width = 145;
            // 
            // QLFHD_TenFileHopDong
            // 
            this.QLFHD_TenFileHopDong.AppearanceCell.Options.UseTextOptions = true;
            this.QLFHD_TenFileHopDong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.QLFHD_TenFileHopDong.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHD_TenFileHopDong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QLFHD_TenFileHopDong.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.QLFHD_TenFileHopDong.AppearanceHeader.Options.UseFont = true;
            this.QLFHD_TenFileHopDong.AppearanceHeader.Options.UseForeColor = true;
            this.QLFHD_TenFileHopDong.AppearanceHeader.Options.UseTextOptions = true;
            this.QLFHD_TenFileHopDong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLFHD_TenFileHopDong.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHD_TenFileHopDong.Caption = "File hợp đồng";
            this.QLFHD_TenFileHopDong.ColumnEdit = this.btn_Tenfile;
            this.QLFHD_TenFileHopDong.FieldName = "QLFHD_TenFileHopDong";
            this.QLFHD_TenFileHopDong.Name = "QLFHD_TenFileHopDong";
            this.QLFHD_TenFileHopDong.Visible = true;
            this.QLFHD_TenFileHopDong.Width = 135;
            // 
            // btn_Tenfile
            // 
            this.btn_Tenfile.AutoHeight = false;
            this.btn_Tenfile.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btn_Tenfile.Name = "btn_Tenfile";
            this.btn_Tenfile.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_Tenfile_ButtonClick);
            // 
            // QLFHD_DataFileHopDong
            // 
            this.QLFHD_DataFileHopDong.AppearanceCell.Options.UseTextOptions = true;
            this.QLFHD_DataFileHopDong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLFHD_DataFileHopDong.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHD_DataFileHopDong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLFHD_DataFileHopDong.AppearanceHeader.Options.UseFont = true;
            this.QLFHD_DataFileHopDong.AppearanceHeader.Options.UseTextOptions = true;
            this.QLFHD_DataFileHopDong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.QLFHD_DataFileHopDong.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLFHD_DataFileHopDong.Caption = "Data file hợp đồng";
            this.QLFHD_DataFileHopDong.FieldName = "QLFHD_DataFileHopDong";
            this.QLFHD_DataFileHopDong.Name = "QLFHD_DataFileHopDong";
            this.QLFHD_DataFileHopDong.Width = 105;
            // 
            // QLFHD_GhiChu
            // 
            this.QLFHD_GhiChu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.QLFHD_GhiChu.AppearanceCell.Options.UseFont = true;
            this.QLFHD_GhiChu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.QLFHD_GhiChu.AppearanceHeader.Options.UseFont = true;
            this.QLFHD_GhiChu.Caption = "Ghi chú";
            this.QLFHD_GhiChu.FieldName = "QLFHD_GhiChu";
            this.QLFHD_GhiChu.Name = "QLFHD_GhiChu";
            this.QLFHD_GhiChu.Visible = true;
            // 
            // frmQLTS_QuanLyFileHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 551);
            this.Controls.Add(this.gridControl_QuanLyFileHopDong);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQLTS_QuanLyFileHopDong";
            this.Text = "frmQuanLyFileHopDong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLyFileHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_QuanLyFileHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView_QuanLyFileHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_QLNS_Chon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Tenfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevExpress.XtraGrid.GridControl gridControl_QuanLyFileHopDong;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView_QuanLyFileHopDong;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLFHD_Chon;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_QLNS_Chon;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLFHD_Ma;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLFHD_SoHopDong;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLFHD_NgayHopDong;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLFHD_TenFileHopDong;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_Tenfile;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLFHD_DataFileHopDong;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLFHD_GhiChu;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}