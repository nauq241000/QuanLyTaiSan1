using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public
{
    public class NhomTaiSanPublic
    {
        private int _NTS_Ma;

        public int NTS_Ma
        {
            get { return _NTS_Ma; }
            set { _NTS_Ma = value; }
        }

        private string _NTS_Ten;

        public string NTS_Ten
        {
            get { return _NTS_Ten; }
            set { _NTS_Ten = value; }
        }

        private int? _HT_UserCreate;

        public int? HT_UserCreate
        {
            get { return _HT_UserCreate; }
            set { _HT_UserCreate = value; }
        }

        private DateTime? _NTS_DateCreate;

        public DateTime? NTS_DateCreate
        {
            get { return _NTS_DateCreate; }
            set { _NTS_DateCreate = value; }
        }
        private int? _HT_UserEditor;

        public int? HT_UserEditor
        {
            get { return _HT_UserEditor; }
            set { _HT_UserEditor = value; }
        }
        private DateTime? _NTS_DateEditor;

        public DateTime? NTS_DateEditor
        {
            get { return _NTS_DateEditor; }
            set { _NTS_DateEditor = value; }
        }

        private string _NTS_SuDung;

        public string NTS_SuDung
        {
            get { return _NTS_SuDung; }
            set { _NTS_SuDung = value; }
        }

        private bool? _NTS_HienThi;

        public bool? NTS_HienThi
        {
            get { return _NTS_HienThi; }
            set { _NTS_HienThi = value; }
        }

    }
}
