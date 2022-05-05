using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public
{
    public class QuanLyFileHoSoThanhToanPublic
    {
        private int _QLFHSTT_Ma;

        public int QLFHSTT_Ma
        {
            get { return _QLFHSTT_Ma; }
            set { _QLFHSTT_Ma = value; }
        }

        private string _QLFHSTT_SoHoSo;

        public string QLFHSTT_SoHoSo
        {
            get { return _QLFHSTT_SoHoSo; }
            set { _QLFHSTT_SoHoSo = value; }
        }

        private DateTime _QLFHSTT_NgayHoSo;

        public DateTime QLFHSTT_NgayHoSo
        {
            get { return _QLFHSTT_NgayHoSo; }
            set { _QLFHSTT_NgayHoSo = value; }
        }

        private string _QLFHSTT_TenFile;

        public string QLFHSTT_TenFile
        {
            get { return _QLFHSTT_TenFile; }
            set { _QLFHSTT_TenFile = value; }
        }

        private byte[] _QLFHSTT_DataFile;

        public byte[] QLFHSTT_DataFile
        {
            get { return _QLFHSTT_DataFile; }
            set { _QLFHSTT_DataFile = value; }
        }

        private string _QLFHSTT_GhiChu;

        public string QLFHSTT_GhiChu
        {
            get { return _QLFHSTT_GhiChu; }
            set { _QLFHSTT_GhiChu = value; }
        }


        private int? _HT_UserCreate;

        public int? HT_UserCreate
        {
            get { return _HT_UserCreate; }
            set { _HT_UserCreate = value; }
        }

        private DateTime? _QLFHSTT_DateCreate;

        public DateTime? QLFHSTT_DateCreate
        {
            get { return _QLFHSTT_DateCreate; }
            set { _QLFHSTT_DateCreate = value; }
        }
        private int? _HT_UserEditor;

        public int? HT_UserEditor
        {
            get { return _HT_UserEditor; }
            set { _HT_UserEditor = value; }
        }
        private DateTime? _QLFHSTT_DateEditor;

        public DateTime? QLFHSTT_DateEditor
        {
            get { return _QLFHSTT_DateEditor; }
            set { _QLFHSTT_DateEditor = value; }
        }

        private string _QLFHSTT_SuDung;

        public string QLFHSTT_SuDung
        {
            get { return _QLFHSTT_SuDung; }
            set { _QLFHSTT_SuDung = value; }
        }

        private bool? _QLFHSTT_HienThi;

        public bool? QLFHSTT_HienThi
        {
            get { return _QLFHSTT_HienThi; }
            set { _QLFHSTT_HienThi = value; }
        }
    }
}
