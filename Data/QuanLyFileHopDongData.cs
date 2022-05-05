using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class QuanLyFileHopDongData
    {
        ClsKetNoi cls = new ClsKetNoi();
      QuanLyFileHopDongPublic Public = new  QuanLyFileHopDongPublic();

        public DataTable QL_QuanLyFileHopDong_Load()
        {
            return cls.LayDuLieu("SP_QuanLyFileHopDong_Load");
        }

        public int QL_QuanLyFileHopDong_Xoa(QuanLyFileHopDongPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@QLFHD_Ma";
            giatri[0] = Public.QLFHD_Ma;
            return cls.Update("SP_QuanLyFileHopDong_Del", bien, giatri, thamso);
        }

        public int QL_QuanLyFileHopDong_Them(QuanLyFileHopDongPublic Public)
        {
            
            int thamso = 8;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

                    bien[0]="@QLFHD_SoHopDong";
                    bien[1]="@QLFHD_NgayHopDong";
                    bien[2]="@QLFHD_TenFileHopDong";
                    bien[3]="@QLFHD_DataFileHopDong";
                    bien[4]="@QLFHD_GhiChu";
                    bien[5]="@HT_UserCreate";
                    bien[6]="@QLFHD_SuDung";
                    bien[7]="@QLFHD_HienThi";

                    giatri[0]=Public.QLFHD_SoHopDong ;
                    giatri[1]=Public.QLFHD_NgayHopDong ;
                    giatri[2]=Public.QLFHD_TenFileHopDong ;
                    giatri[3]=Public.QLFHD_DataFileHopDong ;
                    giatri[4]=Public.QLFHD_GhiChu ;
                    giatri[5]=Public.HT_UserCreate ;
                    giatri[6]=Public.QLFHD_SuDung  ;
                    giatri[7]=Public.QLFHD_HienThi  ;

            return cls.Update("SP_QuanLyFileHopDong_Add", bien, giatri, thamso);
        }

        public int QL_QuanLyFileHopDong_Sua(QuanLyFileHopDongPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SQL
                    int thamso = 7;
                    string[] bien = new string[thamso];
                    object[] giatri = new object[thamso];

                    bien[0]="@QLFHD_Ma";
                    bien[1]="@QLFHD_SoHopDong";
                    bien[2]="@QLFHD_NgayHopDong";
                    bien[3]="@QLFHD_TenFileHopDong";
                    bien[4]="@QLFHD_DataFileHopDong";
                    bien[5]="@QLFHD_GhiChu";
                    bien[6]="@HT_UserEditor";

                    giatri[0]=Public.QLFHD_Ma ;
                    giatri[1]=Public.QLFHD_SoHopDong ;
                    giatri[2]=Public.QLFHD_NgayHopDong ;
                    giatri[3]=Public.QLFHD_TenFileHopDong ;
                    giatri[4]=Public.QLFHD_DataFileHopDong ;
                    giatri[5]=Public.QLFHD_GhiChu ;
                    giatri[6]=Public.HT_UserEditor  ;

            return cls.Update("SP_QuanLyFileHopDong_Edit", bien, giatri, thamso);
        }


        public SqlDataReader TS_QuanLyFileHopDong_Load_R_Para_File(QuanLyFileHopDongPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@QLFHD_Ma";
            giatri[0] = Public.QLFHD_Ma;

            return cls.LayDuLieu_R("SP_QuanLyFileHopDong_Load_R_Para_File", bien, giatri, thamso);
        }
    }
}
