using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using System.Data;

namespace BLL
{
    public class LichSuBanGiaoBLL
    {
        LichSuBanGiaoData cls = new LichSuBanGiaoData();

        public DataTable LS_LichSuBanGiao_Load()
        {
            return cls.LS_LichSuBanGiao_Load();
        }
    }
}
