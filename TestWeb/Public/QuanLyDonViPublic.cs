using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public
{
    public class QuanLyDonViPublic
    {
        private int _QLDV_Ma;

        public int QLDV_Ma
        {
            get { return _QLDV_Ma; }
            set { _QLDV_Ma = value; }
        }

        private string _QLDV_MaDonVi;

        public string QLDV_MaDonVi
        {
            get { return _QLDV_MaDonVi; }
            set { _QLDV_MaDonVi = value; }
        }

        private string _QLDV_TenDonVi;

        public string QLDV_TenDonVi
        {
            get { return _QLDV_TenDonVi; }
            set { _QLDV_TenDonVi = value; }
        }

        private string _QLDV_MoTa;

        public string QLDV_MoTa
        {
            get { return _QLDV_MoTa; }
            set { _QLDV_MoTa = value; }
        }

        private string _QLDV_GhiChu;

        public string QLDV_GhiChu
        {
            get { return _QLDV_GhiChu; }
            set { _QLDV_GhiChu = value; }
        }


        private int? _HT_UserCreate;

        public int? HT_UserCreate
        {
            get { return _HT_UserCreate; }
            set { _HT_UserCreate = value; }
        }

        private DateTime? _QLDV_DateCreate;

        public DateTime? QLDV_DateCreate
        {
            get { return _QLDV_DateCreate; }
            set { _QLDV_DateCreate = value; }
        }

        private int? _HT_UserEditor;

        public int? HT_UserEditor
        {
            get { return _HT_UserEditor; }
            set { _HT_UserEditor = value; }
        }

        private DateTime? _QLDV_DateEditor;

        public DateTime? QLDV_DateEditor
        {
            get { return _QLDV_DateEditor; }
            set { _QLDV_DateEditor = value; }
        }

        private string _QLDV_SuDung;

        public string QLDV_SuDung
        {
            get { return _QLDV_SuDung; }
            set { _QLDV_SuDung = value; }
        }

        private bool? _QLDV_HienThi;

        public bool? QLDV_HienThi
        {
            get { return _QLDV_HienThi; }
            set { _QLDV_HienThi = value; }
        }
    }
}
