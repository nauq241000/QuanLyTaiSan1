using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public
{
    public class DangNhapASPPublic
    {
        private string _username;

        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _password;

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
