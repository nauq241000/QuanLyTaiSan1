using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;
using System.Data;
using System.Data.SqlClient;
using Data;

namespace BLL
{
    public class HT_PQ_USERBLL
    {
        HT_PQ_USERData cls = new HT_PQ_USERData();

        public DataTable LoadHT_PQ_USER_Para(HT_PQ_USERPublic Public)
        {
            return cls.LoadHT_PQ_USER_Para(Public);
        }
        public DataTable LoadHT_PQ_USER_Load_Para_NutCon(HT_PQ_USERPublic Public)
        {
            return cls.LoadHT_PQ_USER_Load_Para_NutCon(Public);
        }
        public SqlDataReader LoadHT_PQ_USER_R_MaND(HT_PQ_USERPublic Public)
        {
            return cls.LoadHT_PQ_USER_R_MaND(Public);
        }
        public int CopyHT_PQ_USER(HT_PQ_USERPublic Public)
        {
            return cls.CopyHT_PQ_USER(Public);
        }
        public int DongBoHT_PQ_USER(HT_PQ_USERPublic Public)
        {
            return cls.DongBoHT_PQ_USER(Public);
        }
        public int SuaHT_PQ_USER(HT_PQ_USERPublic Public)
        {
            return cls.SuaHT_PQ_USER(Public);
        }
        public int Visible_BarButtonItem_Main(HT_PQ_USERPublic Public)
        {
            return cls.Visible_BarButtonItem_Main(Public);
        }
        public int Visible_BarButtonItem_Form(HT_PQ_USERPublic Public)
        {
            return cls.Visible_BarButtonItem_Form(Public);
        }
        public int VisiblePageGroup_Main(HT_PQ_USERPublic Public)
        {
            return cls.VisiblePageGroup_Main(Public);
        }
        public int VisiblePage_Main(HT_PQ_USERPublic Public)
        {
            return cls.VisiblePage_Main(Public);
        }
    }
}
