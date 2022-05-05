namespace QuanLyTaiSan
{
    partial class frmQLTS_NhomTaiSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTS_NhomTaiSan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
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
            this.gridControl_NhomTaiSan = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView_NhomTaiSan = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.NTS_Chon = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemCheckEdit_TSYC_Chon = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.NTS_Ma = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.NTS_Ten = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemButtonEdit_TenFile = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemComboBox_DonViYeuCau = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_NhomTaiSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView_NhomTaiSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_TSYC_Chon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit_TenFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox_DonViYeuCau)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
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
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 10;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClear, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1011, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 439);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1011, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 415);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1011, 24);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 415);
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
            // gridControl_NhomTaiSan
            // 
            this.gridControl_NhomTaiSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_NhomTaiSan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_NhomTaiSan.Location = new System.Drawing.Point(0, 24);
            this.gridControl_NhomTaiSan.MainView = this.bandedGridView_NhomTaiSan;
            this.gridControl_NhomTaiSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_NhomTaiSan.Name = "gridControl_NhomTaiSan";
            this.gridControl_NhomTaiSan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit_TSYC_Chon,
            this.repositoryItemButtonEdit_TenFile,
            this.repositoryItemComboBox_DonViYeuCau});
            this.gridControl_NhomTaiSan.Size = new System.Drawing.Size(1011, 415);
            this.gridControl_NhomTaiSan.TabIndex = 6;
            this.gridControl_NhomTaiSan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView_NhomTaiSan});
            // 
            // bandedGridView_NhomTaiSan
            // 
            this.bandedGridView_NhomTaiSan.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightYellow;
            this.bandedGridView_NhomTaiSan.Appearance.SelectedRow.Options.UseBackColor = true;
            this.bandedGridView_NhomTaiSan.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.gridBand7});
            this.bandedGridView_NhomTaiSan.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.NTS_Chon,
            this.NTS_Ma,
            this.NTS_Ten});
            this.bandedGridView_NhomTaiSan.GridControl = this.gridControl_NhomTaiSan;
            this.bandedGridView_NhomTaiSan.GroupCount = 1;
            this.bandedGridView_NhomTaiSan.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.bandedGridView_NhomTaiSan.Name = "bandedGridView_NhomTaiSan";
            this.bandedGridView_NhomTaiSan.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.bandedGridView_NhomTaiSan.OptionsBehavior.AutoExpandAllGroups = true;
            this.bandedGridView_NhomTaiSan.OptionsSelection.MultiSelect = true;
            this.bandedGridView_NhomTaiSan.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.bandedGridView_NhomTaiSan.OptionsView.ColumnAutoWidth = false;
            this.bandedGridView_NhomTaiSan.OptionsView.EnableAppearanceEvenRow = true;
            this.bandedGridView_NhomTaiSan.OptionsView.EnableAppearanceOddRow = true;
            this.bandedGridView_NhomTaiSan.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.bandedGridView_NhomTaiSan.OptionsView.RowAutoHeight = true;
            this.bandedGridView_NhomTaiSan.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridView_NhomTaiSan.OptionsView.ShowFooter = true;
            this.bandedGridView_NhomTaiSan.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.bandedGridView_NhomTaiSan.OptionsView.ShowGroupPanel = false;
            this.bandedGridView_NhomTaiSan.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.True;
            this.bandedGridView_NhomTaiSan.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.NTS_Ma, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.bandedGridView_NhomTaiSan.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.bandedGridView_TaiSanHienCo_PopupMenuShowing);
            // 
            // gridBand2
            // 
            this.gridBand2.Columns.Add(this.NTS_Chon);
            this.gridBand2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 0;
            this.gridBand2.Width = 60;
            // 
            // NTS_Chon
            // 
            this.NTS_Chon.AppearanceCell.Options.UseTextOptions = true;
            this.NTS_Chon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NTS_Chon.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NTS_Chon.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NTS_Chon.AppearanceHeader.Options.UseFont = true;
            this.NTS_Chon.AppearanceHeader.Options.UseTextOptions = true;
            this.NTS_Chon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NTS_Chon.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NTS_Chon.Caption = "Chọn";
            this.NTS_Chon.ColumnEdit = this.repositoryItemCheckEdit_TSYC_Chon;
            this.NTS_Chon.FieldName = "NTS_Chon";
            this.NTS_Chon.Name = "NTS_Chon";
            this.NTS_Chon.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TSYC_Chon", "{0}")});
            this.NTS_Chon.Visible = true;
            this.NTS_Chon.Width = 60;
            // 
            // repositoryItemCheckEdit_TSYC_Chon
            // 
            this.repositoryItemCheckEdit_TSYC_Chon.AutoHeight = false;
            this.repositoryItemCheckEdit_TSYC_Chon.DisplayValueChecked = "True";
            this.repositoryItemCheckEdit_TSYC_Chon.DisplayValueUnchecked = "False";
            this.repositoryItemCheckEdit_TSYC_Chon.Name = "repositoryItemCheckEdit_TSYC_Chon";
            // 
            // gridBand7
            // 
            this.gridBand7.Columns.Add(this.NTS_Ma);
            this.gridBand7.Columns.Add(this.NTS_Ten);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 1;
            this.gridBand7.Width = 241;
            // 
            // NTS_Ma
            // 
            this.NTS_Ma.AppearanceCell.Options.UseTextOptions = true;
            this.NTS_Ma.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NTS_Ma.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NTS_Ma.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NTS_Ma.AppearanceHeader.Options.UseFont = true;
            this.NTS_Ma.AppearanceHeader.Options.UseTextOptions = true;
            this.NTS_Ma.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NTS_Ma.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NTS_Ma.Caption = "Mã";
            this.NTS_Ma.FieldName = "NTS_Ma";
            this.NTS_Ma.Name = "NTS_Ma";
            this.NTS_Ma.Visible = true;
            this.NTS_Ma.Width = 48;
            // 
            // NTS_Ten
            // 
            this.NTS_Ten.AppearanceCell.Options.UseTextOptions = true;
            this.NTS_Ten.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.NTS_Ten.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NTS_Ten.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NTS_Ten.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.NTS_Ten.AppearanceHeader.Options.UseFont = true;
            this.NTS_Ten.AppearanceHeader.Options.UseForeColor = true;
            this.NTS_Ten.AppearanceHeader.Options.UseTextOptions = true;
            this.NTS_Ten.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NTS_Ten.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NTS_Ten.Caption = "Nhóm tài sản";
            this.NTS_Ten.FieldName = "NTS_Ten";
            this.NTS_Ten.Name = "NTS_Ten";
            this.NTS_Ten.Visible = true;
            this.NTS_Ten.Width = 193;
            // 
            // repositoryItemButtonEdit_TenFile
            // 
            this.repositoryItemButtonEdit_TenFile.AutoHeight = false;
            this.repositoryItemButtonEdit_TenFile.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit_TenFile.Name = "repositoryItemButtonEdit_TenFile";
            // 
            // repositoryItemComboBox_DonViYeuCau
            // 
            this.repositoryItemComboBox_DonViYeuCau.AutoHeight = false;
            this.repositoryItemComboBox_DonViYeuCau.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox_DonViYeuCau.Items.AddRange(new object[] {
            "Khoa CNTT",
            "Khoa Cơ Điện Tử",
            "Khoa Cơ Khí",
            "Khoa Điện Tử Viễn Thông",
            "Khoa Kế Toán",
            "Khoa Kinh Doanh Thương Mại",
            "Khoa May",
            "Khoa Ngôn Ngữ Anh",
            "Khoa Quản Trị Kinh Doanh",
            "Khoa Tài Chính Ngân Hàng",
            "Giảng Đường",
            "Phòng CTSV",
            "Phòng Đào Tạo",
            "Phòng Học"});
            this.repositoryItemComboBox_DonViYeuCau.Name = "repositoryItemComboBox_DonViYeuCau";
            // 
            // frmQLTS_NhomTaiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 439);
            this.Controls.Add(this.gridControl_NhomTaiSan);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQLTS_NhomTaiSan";
            this.Text = "Quản lý nhóm tài sản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhomTaiSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_NhomTaiSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView_NhomTaiSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_TSYC_Chon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit_TenFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox_DonViYeuCau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
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
        private DevExpress.XtraGrid.GridControl gridControl_NhomTaiSan;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView_NhomTaiSan;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn NTS_Chon;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_TSYC_Chon;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn NTS_Ma;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn NTS_Ten;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox_DonViYeuCau;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit_TenFile;
    }
}