using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Public;
using Data;

namespace BLL
{
    public class TaiSanHienCoBLL
    {

        TaiSanHienCoData cls = new TaiSanHienCoData();

        public SqlDataReader TS_TaiSanHienCo_ASP_Load_R_Para_File(TaiSanHienCoPublic Public)
        {
            return cls.TS_TaiSanHienCo_ASP_Load_R_Para_File(Public);
        }

        public object TS_TSHC_ThietBiDiKem_ASP_Load(TaiSanHienCoPublic Public)
        {
            return cls.TS_TSHC_ThietBiDiKem_ASP_Load(Public);
        }

        public int TS_TaiSanHienCoASP_NSSD_Sua(TaiSanHienCoPublic Public)
        {
            return cls.TS_TaiSanHienCoASP_NSSD_Sua(Public);
        }

        public int TS_TaiSanHienCoASP_TBDK_Sua(TaiSanHienCoPublic Public)
        {
            return cls.TS_TaiSanHienCoASP_TBDK_Sua(Public);
        }

        public object TS_TSHC_ThietBiDiKemALL_ASP_Load()
        {
            return cls.TS_TSHC_ThietBiDiKemALL_ASP_Load();
        }
    }
}
