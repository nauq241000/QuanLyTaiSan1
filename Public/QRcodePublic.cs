using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public
{
    public class QRcodePublic
    {
        private int _QRCode_Ma;

        public int QRCode_Ma
        {
            get { return _QRCode_Ma; }
            set { _QRCode_Ma = value; }
        }
        private string _QRCode_Link;

        public string QRCode_Link
        {
            get { return _QRCode_Link; }
            set { _QRCode_Link = value; }
        }
        private int _HT_UserEditor;

        public int HT_UserEditor
        {
            get { return _HT_UserEditor; }
            set { _HT_UserEditor = value; }
        }
        private DateTime _QRCode_DateEditor;

        public DateTime QRCode_DateEditor
        {
            get { return _QRCode_DateEditor; }
            set { _QRCode_DateEditor = value; }
        }
    }
}
