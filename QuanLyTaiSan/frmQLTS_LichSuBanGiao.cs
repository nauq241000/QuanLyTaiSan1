using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;
using Public;

namespace QuanLyTaiSan
{
    public partial class frmQLTS_LichSuBanGiao : DevExpress.XtraEditors.XtraForm
    {
        public frmQLTS_LichSuBanGiao()
        {
            InitializeComponent();
        }

        LichSuBanGiaoBLL cls = new LichSuBanGiaoBLL();
        LichSuBanGiaoPublic Public = new LichSuBanGiaoPublic();

        TaiSanHienCoBLL cls_TaiSanHienCoBLL = new TaiSanHienCoBLL();
        TaiSanHienCoPublic Public_TaiSanHienCo = new TaiSanHienCoPublic();

        QuanLyNhanSuBLL cls_QuanLyNhanSuBLL = new QuanLyNhanSuBLL();
        QuanLyNhanSuPublic Public_QuanLyNhanSu = new QuanLyNhanSuPublic();

        QuanLyPhongBLL cls_QuanLyPhongBLL = new QuanLyPhongBLL();
        QuanLyPhongPublic Public_QuanLyPhong = new QuanLyPhongPublic();

        private void Lock_Unlock_Control_Input(bool Lock_Control)
        {
            this.TSHC_Ma.OptionsColumn.ReadOnly = true;
            this.TSHC_Ten.OptionsColumn.ReadOnly = true;
            this.QLNS_Ten.OptionsColumn.ReadOnly = true;
            this.QLP_Ma.OptionsColumn.ReadOnly = true;
            this.TSHC_NgayBanGiao.OptionsColumn.ReadOnly = true;
        }

        private void frmQLTS_LichSuBanGiao_Load(object sender, EventArgs e)
        {

            repositoryItemLookUpEdit_MaTS.DataSource = cls_TaiSanHienCoBLL.TS_TaiSanHienCo_Load();
            repositoryItemLookUpEdit_MaTS.DisplayMember = "TSHC_Ma";
            repositoryItemLookUpEdit_MaTS.ValueMember = "TSHC_Ma";

            repositoryItemLookUpEdit_MaTS.PopupWidth = 300;
            repositoryItemLookUpEdit_MaTS.ShowFooter = false;
            repositoryItemLookUpEdit_MaTS.Columns.Clear();
            repositoryItemLookUpEdit_MaTS.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TSHC_Ma", "Mã", 100));
            repositoryItemLookUpEdit_MaTS.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TSHC_TenTaiSan", "Tên nhóm tài sản", 200));

            repositoryItemLookUpEdit_TenTS.DataSource = cls_TaiSanHienCoBLL.TS_TaiSanHienCo_Load();
            repositoryItemLookUpEdit_TenTS.DisplayMember = "TSHC_TenTaiSan";
            repositoryItemLookUpEdit_TenTS.ValueMember = "TSHC_Ma";

            repositoryItemLookUpEdit_TenTS.PopupWidth = 300;
            repositoryItemLookUpEdit_TenTS.ShowFooter = false;
            repositoryItemLookUpEdit_TenTS.Columns.Clear();
            repositoryItemLookUpEdit_TenTS.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TSHC_Ma", "Mã", 100));
            repositoryItemLookUpEdit_TenTS.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TSHC_TenTaiSan", "Tên nhóm tài sản", 200));

            repositoryItemLookUpEdit_MaNS.DataSource = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_Load();
            repositoryItemLookUpEdit_MaNS.DisplayMember = "QLNS_Ma";
            repositoryItemLookUpEdit_MaNS.ValueMember = "QLNS_Ma";

            repositoryItemLookUpEdit_MaNS.PopupWidth = 300;
            repositoryItemLookUpEdit_MaNS.ShowFooter = false;
            repositoryItemLookUpEdit_MaNS.Columns.Clear();
            repositoryItemLookUpEdit_MaNS.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_Ma", "Mã", 100));
            repositoryItemLookUpEdit_MaNS.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_TenNhanSu", "Tên nhóm tài sản", 200));

            repositoryItemLookUpEdit_TenNS.DataSource = cls_QuanLyNhanSuBLL.TS_QuanLyNhanSu_Load();
            repositoryItemLookUpEdit_TenNS.DisplayMember = "QLNS_HoTen";
            repositoryItemLookUpEdit_TenNS.ValueMember = "QLNS_Ma";

            repositoryItemLookUpEdit_TenNS.PopupWidth = 300;
            repositoryItemLookUpEdit_TenNS.ShowFooter = false;
            repositoryItemLookUpEdit_TenNS.Columns.Clear();
            repositoryItemLookUpEdit_TenNS.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_Ma", "Mã", 100));
            repositoryItemLookUpEdit_TenNS.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLNS_HoTen", "Tên nhóm tài sản", 200));

            repositoryItemLookUpEdit_MaPhong.DataSource = cls_QuanLyPhongBLL.TS_QuanLyPhong_Load();
            repositoryItemLookUpEdit_MaPhong.DisplayMember = "QLP_Ma";
            repositoryItemLookUpEdit_MaPhong.ValueMember = "QLP_Ma";

            repositoryItemLookUpEdit_MaPhong.PopupWidth = 300;
            repositoryItemLookUpEdit_MaPhong.ShowFooter = false;
            repositoryItemLookUpEdit_MaPhong.Columns.Clear();
            repositoryItemLookUpEdit_MaPhong.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_Ma", "Mã", 100));
            repositoryItemLookUpEdit_MaPhong.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_TenPhong", "Tên nhóm tài sản", 200));

            repositoryItemLookUpEdit_TenPhong.DataSource = cls_QuanLyPhongBLL.TS_QuanLyPhong_Load();
            repositoryItemLookUpEdit_TenPhong.DisplayMember = "QLP_TenPhong";
            repositoryItemLookUpEdit_TenPhong.ValueMember = "QLP_Ma";

            repositoryItemLookUpEdit_TenPhong.PopupWidth = 300;
            repositoryItemLookUpEdit_TenPhong.ShowFooter = false;
            repositoryItemLookUpEdit_TenPhong.Columns.Clear();
            repositoryItemLookUpEdit_TenPhong.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_Ma", "Mã", 100));
            repositoryItemLookUpEdit_TenPhong.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QLP_TenPhong", "Tên nhóm tài sản", 200));

            gridControl_LichSuBanGiao.DataSource = cls.LS_LichSuBanGiao_Load();
        }

        
    }
}