using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;
using Data;
using System.Data;

namespace BLL
{
    public class NhomTaiSanBLL
    {
        NhomTaiSanData cls = new NhomTaiSanData();

        public DataTable TS_NhomTaiSan_Load()
        {
            return cls.TS_NhomTaiSan_Load();
        }

        public int TS_NhomTaiSan_Xoa(NhomTaiSanPublic Public)
        {
            return cls.TS_NhomTaiSan_Xoa(Public);
        }

        public int TS_NhomTaiSan_Them(NhomTaiSanPublic Public)
        {
            return cls.TS_NhomTaiSan_Them(Public);
        }

        public int TS_NhomTaiSan_Sua(NhomTaiSanPublic Public)
        {
            return cls.TS_NhomTaiSan_Sua(Public);
        }

    }
}
