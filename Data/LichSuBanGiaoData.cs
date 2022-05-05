using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;
using System.Data;

namespace Data
{
    public class LichSuBanGiaoData
    {
        ClsKetNoi cls = new ClsKetNoi();
        LichSuBanGiaoPublic Public = new LichSuBanGiaoPublic();

        public DataTable LS_LichSuBanGiao_Load()
        {
            return cls.LayDuLieu("SP_LichSuBanGiao_Load");
        }


        
    }
}
