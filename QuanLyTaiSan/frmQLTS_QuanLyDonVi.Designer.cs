namespace QuanLyTaiSan
{
    partial class frmQLTS_QuanLyDonVi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTS_QuanLyDonVi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnClear = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDownload = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl_QuanLyDonVi = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView_QuanLyDonVi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.QLDV_Chon = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemCheckEdit_QLNS_Chon = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.QLDV_Ma = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.QLDV_MaDonVi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.QLDV_TenDonVi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.QLDV_MoTa = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.QLDV_GhiChu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_QuanLyDonVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView_QuanLyDonVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_QLNS_Chon)).BeginInit();
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
            this.btnIn,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Glyph = ((System.Drawing.Image)(resources.GetObject("btnIn.Glyph")));
            this.btnIn.Id = 7;
            this.btnIn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnIn.LargeGlyph")));
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1053, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 442);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1053, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 418);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1053, 24);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 418);
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
            // gridControl_QuanLyDonVi
            // 
            this.gridControl_QuanLyDonVi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_QuanLyDonVi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_QuanLyDonVi.Location = new System.Drawing.Point(0, 24);
            this.gridControl_QuanLyDonVi.MainView = this.bandedGridView_QuanLyDonVi;
            this.gridControl_QuanLyDonVi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_QuanLyDonVi.MenuManager = this.barManager1;
            this.gridControl_QuanLyDonVi.Name = "gridControl_QuanLyDonVi";
            this.gridControl_QuanLyDonVi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit_QLNS_Chon});
            this.gridControl_QuanLyDonVi.Size = new System.Drawing.Size(1053, 418);
            this.gridControl_QuanLyDonVi.TabIndex = 6;
            this.gridControl_QuanLyDonVi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView_QuanLyDonVi});
            // 
            // bandedGridView_QuanLyDonVi
            // 
            this.bandedGridView_QuanLyDonVi.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightYellow;
            this.bandedGridView_QuanLyDonVi.Appearance.SelectedRow.Options.UseBackColor = true;
            this.bandedGridView_QuanLyDonVi.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.gridBand7});
            this.bandedGridView_QuanLyDonVi.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.QLDV_Chon,
            this.QLDV_Ma,
            this.QLDV_MaDonVi,
            this.QLDV_TenDonVi,
            this.QLDV_MoTa,
            this.QLDV_GhiChu});
            this.bandedGridView_QuanLyDonVi.GridControl = this.gridControl_QuanLyDonVi;
            this.bandedGridView_QuanLyDonVi.GroupCount = 1;
            this.bandedGridView_QuanLyDonVi.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.bandedGridView_QuanLyDonVi.Name = "bandedGridView_QuanLyDonVi";
            this.bandedGridView_QuanLyDonVi.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.bandedGridView_QuanLyDonVi.OptionsBehavior.AutoExpandAllGroups = true;
            this.bandedGridView_QuanLyDonVi.OptionsSelection.MultiSelect = true;
            this.bandedGridView_QuanLyDonVi.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.bandedGridView_QuanLyDonVi.OptionsView.ColumnAutoWidth = false;
            this.bandedGridView_QuanLyDonVi.OptionsView.EnableAppearanceEvenRow = true;
            this.bandedGridView_QuanLyDonVi.OptionsView.EnableAppearanceOddRow = true;
            this.bandedGridView_QuanLyDonVi.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.bandedGridView_QuanLyDonVi.OptionsView.RowAutoHeight = true;
            this.bandedGridView_QuanLyDonVi.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridView_QuanLyDonVi.OptionsView.ShowFooter = true;
            this.bandedGridView_QuanLyDonVi.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.bandedGridView_QuanLyDonVi.OptionsView.ShowGroupPanel = false;
            this.bandedGridView_QuanLyDonVi.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.True;
            this.bandedGridView_QuanLyDonVi.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.QLDV_MaDonVi, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.bandedGridView_QuanLyDonVi.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.bandedGridView_TaiSanHienCo_PopupMenuShowing);
            // 
            // gridBand2
            // 
            this.gridBand2.Columns.Add(this.QLDV_Chon);
            this.gridBand2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 0;
            this.gridBand2.Width = 60;
            // 
            // QLDV_Chon
            // 
            this.QLDV_Chon.AppearanceCell.Options.UseTextOptions = true;
            this.QLDV_Chon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLDV_Chon.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLDV_Chon.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QLDV_Chon.AppearanceHeader.Options.UseFont = true;
            this.QLDV_Chon.AppearanceHeader.Options.UseTextOptions = true;
            this.QLDV_Chon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLDV_Chon.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLDV_Chon.Caption = "Chọn";
            this.QLDV_Chon.ColumnEdit = this.repositoryItemCheckEdit_QLNS_Chon;
            this.QLDV_Chon.FieldName = "QLDV_Chon";
            this.QLDV_Chon.Name = "QLDV_Chon";
            this.QLDV_Chon.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TSYC_Chon", "{0}")});
            this.QLDV_Chon.Visible = true;
            this.QLDV_Chon.Width = 60;
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
            this.gridBand7.Columns.Add(this.QLDV_Ma);
            this.gridBand7.Columns.Add(this.QLDV_MaDonVi);
            this.gridBand7.Columns.Add(this.QLDV_TenDonVi);
            this.gridBand7.Columns.Add(this.QLDV_MoTa);
            this.gridBand7.Columns.Add(this.QLDV_GhiChu);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 1;
            this.gridBand7.Width = 850;
            // 
            // QLDV_Ma
            // 
            this.QLDV_Ma.AppearanceCell.Options.UseTextOptions = true;
            this.QLDV_Ma.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLDV_Ma.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLDV_Ma.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QLDV_Ma.AppearanceHeader.Options.UseFont = true;
            this.QLDV_Ma.AppearanceHeader.Options.UseTextOptions = true;
            this.QLDV_Ma.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLDV_Ma.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLDV_Ma.Caption = "Mã";
            this.QLDV_Ma.FieldName = "QLDV_Ma";
            this.QLDV_Ma.Name = "QLDV_Ma";
            this.QLDV_Ma.Visible = true;
            this.QLDV_Ma.Width = 100;
            // 
            // QLDV_MaDonVi
            // 
            this.QLDV_MaDonVi.AppearanceCell.Options.UseTextOptions = true;
            this.QLDV_MaDonVi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.QLDV_MaDonVi.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLDV_MaDonVi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QLDV_MaDonVi.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.QLDV_MaDonVi.AppearanceHeader.Options.UseFont = true;
            this.QLDV_MaDonVi.AppearanceHeader.Options.UseForeColor = true;
            this.QLDV_MaDonVi.AppearanceHeader.Options.UseTextOptions = true;
            this.QLDV_MaDonVi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLDV_MaDonVi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLDV_MaDonVi.Caption = "Mã đơn vị";
            this.QLDV_MaDonVi.FieldName = "QLDV_MaDonVi";
            this.QLDV_MaDonVi.Name = "QLDV_MaDonVi";
            this.QLDV_MaDonVi.Visible = true;
            this.QLDV_MaDonVi.Width = 150;
            // 
            // QLDV_TenDonVi
            // 
            this.QLDV_TenDonVi.AppearanceCell.Options.UseTextOptions = true;
            this.QLDV_TenDonVi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.QLDV_TenDonVi.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLDV_TenDonVi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QLDV_TenDonVi.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.QLDV_TenDonVi.AppearanceHeader.Options.UseFont = true;
            this.QLDV_TenDonVi.AppearanceHeader.Options.UseForeColor = true;
            this.QLDV_TenDonVi.AppearanceHeader.Options.UseTextOptions = true;
            this.QLDV_TenDonVi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLDV_TenDonVi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLDV_TenDonVi.Caption = "Tên đơn vị";
            this.QLDV_TenDonVi.FieldName = "QLDV_TenDonVi";
            this.QLDV_TenDonVi.Name = "QLDV_TenDonVi";
            this.QLDV_TenDonVi.Visible = true;
            this.QLDV_TenDonVi.Width = 250;
            // 
            // QLDV_MoTa
            // 
            this.QLDV_MoTa.AppearanceCell.Options.UseTextOptions = true;
            this.QLDV_MoTa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.QLDV_MoTa.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLDV_MoTa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QLDV_MoTa.AppearanceHeader.Options.UseFont = true;
            this.QLDV_MoTa.AppearanceHeader.Options.UseTextOptions = true;
            this.QLDV_MoTa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLDV_MoTa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLDV_MoTa.Caption = "Mô tả";
            this.QLDV_MoTa.FieldName = "QLDV_MoTa";
            this.QLDV_MoTa.Name = "QLDV_MoTa";
            this.QLDV_MoTa.Visible = true;
            this.QLDV_MoTa.Width = 200;
            // 
            // QLDV_GhiChu
            // 
            this.QLDV_GhiChu.AppearanceCell.Options.UseTextOptions = true;
            this.QLDV_GhiChu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QLDV_GhiChu.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLDV_GhiChu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLDV_GhiChu.AppearanceHeader.Options.UseFont = true;
            this.QLDV_GhiChu.AppearanceHeader.Options.UseTextOptions = true;
            this.QLDV_GhiChu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.QLDV_GhiChu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QLDV_GhiChu.Caption = "Ghi chú";
            this.QLDV_GhiChu.FieldName = "QLDV_GhiChu";
            this.QLDV_GhiChu.Name = "QLDV_GhiChu";
            this.QLDV_GhiChu.Visible = true;
            this.QLDV_GhiChu.Width = 150;
            // 
            // frmQLTS_QuanLyDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 442);
            this.Controls.Add(this.gridControl_QuanLyDonVi);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQLTS_QuanLyDonVi";
            this.Text = "Quản lý đơn vị";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQLTS_QuanLyDonVi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_QuanLyDonVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView_QuanLyDonVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_QLNS_Chon)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnDownload;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraGrid.GridControl gridControl_QuanLyDonVi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView_QuanLyDonVi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLDV_Chon;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_QLNS_Chon;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLDV_Ma;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLDV_MaDonVi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLDV_TenDonVi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLDV_MoTa;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn QLDV_GhiChu;
    }
}