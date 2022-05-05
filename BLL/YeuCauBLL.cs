using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using System.Data;
using Public;
using System.Data.SqlClient;

namespace BLL
{
    public class YeuCauBLL
    {
        YeuCauData cls = new YeuCauData();

        public DataTable TS_YeuCau_Load()
        {
            return cls.TS_YeuCau_Load();
        }

        public int TS_YeuCau_Xoa(YeuCauPublic Public)
        {
            return cls.TS_YeuCau_Xoa(Public);
        }

        public int TS_YeuCau_Them(YeuCauPublic Public)
        {
            return cls.TS_YeuCau_Them(Public);
        }

        public int TS_YeuCau_Sua(YeuCauPublic Public)
        {
            return cls.TS_YeuCau_Sua(Public);
        }

        public SqlDataReader TS_YeuCau_Load_R_Para_File(YeuCauPublic Public)
        {
            return cls.TS_YeuCau_Load_R_Para_File(Public);
        }
    }
}
