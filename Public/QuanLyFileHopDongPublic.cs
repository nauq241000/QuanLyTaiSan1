using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public
{
    public class QuanLyFileHopDongPublic
    {
        private int _QLFHD_Ma;

        public int QLFHD_Ma
        {
            get { return _QLFHD_Ma; }
            set { _QLFHD_Ma = value; }
        }

        private string _QLFHD_SoHopDong;

        public string QLFHD_SoHopDong
        {
            get { return _QLFHD_SoHopDong; }
            set { _QLFHD_SoHopDong = value; }
        }

        private DateTime _QLFHD_NgayHopDong;

        public DateTime QLFHD_NgayHopDong
        {
            get { return _QLFHD_NgayHopDong; }
            set { _QLFHD_NgayHopDong = value; }
        }

        private string _QLFHD_TenFileHopDong;

        public string QLFHD_TenFileHopDong
        {
            get { return _QLFHD_TenFileHopDong; }
            set { _QLFHD_TenFileHopDong = value; }
        }

        private byte[] _QLFHD_DataFileHopDong;

        public byte[] QLFHD_DataFileHopDong
        {
            get { return _QLFHD_DataFileHopDong; }
            set { _QLFHD_DataFileHopDong = value; }
        }

        private string _QLFHD_GhiChu;

        public string QLFHD_GhiChu
        {
            get { return _QLFHD_GhiChu; }
            set { _QLFHD_GhiChu = value; }
        }


        private int? _HT_UserCreate;

        public int? HT_UserCreate
        {
            get { return _HT_UserCreate; }
            set { _HT_UserCreate = value; }
        }

        private DateTime? _QLFHD_DateCreate;

        public DateTime? QLFHD_DateCreate
        {
            get { return _QLFHD_DateCreate; }
            set { _QLFHD_DateCreate = value; }
        }
        private int? _HT_UserEditor;

        public int? HT_UserEditor
        {
            get { return _HT_UserEditor; }
            set { _HT_UserEditor = value; }
        }
        private DateTime? _QLFHD_DateEditor;

        public DateTime? QLFHD_DateEditor
        {
            get { return _QLFHD_DateEditor; }
            set { _QLFHD_DateEditor = value; }
        }

        private string _QLFHD_SuDung;

        public string QLFHD_SuDung
        {
            get { return _QLFHD_SuDung; }
            set { _QLFHD_SuDung = value; }
        }

        private bool? _QLFHD_HienThi;

        public bool? QLFHD_HienThi
        {
            get { return _QLFHD_HienThi; }
            set { _QLFHD_HienThi = value; }
        }


    }
}
