using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public
{
    public class YeuCauPublic
    {
        private int _YC_Ma;

        public int YC_Ma
        {
            get { return _YC_Ma; }
            set { _YC_Ma = value; }
        }

        private string _YC_NhomYeuCau;

        public string YC_NhomYeuCau
        {
            get { return _YC_NhomYeuCau; }
            set { _YC_NhomYeuCau = value; }
        }

        private string _YC_TenYeuCau;

        public string YC_TenYeuCau
        {
            get { return _YC_TenYeuCau; }
            set { _YC_TenYeuCau = value; }
        }

        private DateTime _YC_NgayYeuCau;

        public DateTime YC_NgayYeuCau
        {
            get { return _YC_NgayYeuCau; }
            set { _YC_NgayYeuCau = value; }
        }

        private string _YC_DonViYeuCau;

        public string YC_DonViYeuCau
        {
            get { return _YC_DonViYeuCau; }
            set { _YC_DonViYeuCau = value; }
        }

        private string _YC_NguoiDeNghi;

        public string YC_NguoiDeNghi
        {
            get { return _YC_NguoiDeNghi; }
            set { _YC_NguoiDeNghi = value; }
        }

        private string _YC_TenFile;

        public string YC_TenFile
        {
            get { return _YC_TenFile; }
            set { _YC_TenFile = value; }
        }

        private byte[] _YC_DataFile;

        public byte[] YC_DataFile
        {
            get { return _YC_DataFile; }
            set { _YC_DataFile = value; }
        }

        private string _YC_GhiChu;

        public string YC_GhiChu
        {
            get { return _YC_GhiChu; }
            set { _YC_GhiChu = value; }
        }

        private int? _HT_UserCreate;

        public int? HT_UserCreate
        {
            get { return _HT_UserCreate; }
            set { _HT_UserCreate = value; }
        }

        private DateTime? _YC_DateCreate;

        public DateTime? YC_DateCreate
        {
            get { return _YC_DateCreate; }
            set { _YC_DateCreate = value; }
        }
        private int? _HT_UserEditor;

        public int? HT_UserEditor
        {
            get { return _HT_UserEditor; }
            set { _HT_UserEditor = value; }
        }
        private DateTime? _YC_DateEditor;

        public DateTime? YC_DateEditor
        {
            get { return _YC_DateEditor; }
            set { _YC_DateEditor = value; }
        }

        private string _YC_SuDung;

        public string YC_SuDung
        {
            get { return _YC_SuDung; }
            set { _YC_SuDung = value; }
        }

        private bool? _YC_HienThi;

        public bool? YC_HienThi
        {
            get { return _YC_HienThi; }
            set { _YC_HienThi = value; }
        }
    }
}
