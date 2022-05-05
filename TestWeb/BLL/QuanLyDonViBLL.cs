using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Public;
using Data;

namespace BLL
{
    public class QuanLyDonViBLL
    {

        QuanLyDonViData cls = new QuanLyDonViData();

        public SqlDataReader TS_QuanLyDonVi_ASP_Load_R_Para_File(QuanLyDonViPublic Public)
        {
            return cls.TS_QuanLyDonVi_ASP_Load_R_Para_File(Public);
        }
    }
}
