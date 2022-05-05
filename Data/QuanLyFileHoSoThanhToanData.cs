using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Public;
using System.Data;

namespace Data
{
    public class QuanLyFileHoSoThanhToanData
    {
        ClsKetNoi cls = new ClsKetNoi();
        QuanLyFileHoSoThanhToanPublic Public = new  QuanLyFileHoSoThanhToanPublic();

        public DataTable QL_QuanLyFileHoSoThanhToan_Load()
        {
            return cls.LayDuLieu("SP_QuanLyFileHoSoThanhToan_Load");
        }

        public int QL_QuanLyFileHoSoThanhToan_Xoa(QuanLyFileHoSoThanhToanPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@QLFHSTT_Ma";
            giatri[0] = Public.QLFHSTT_Ma;
            return cls.Update("SP_QuanLyFileHoSoThanhToan_Del", bien, giatri, thamso);
        }

        public int QL_QuanLyFileHoSoThanhToan_Them(QuanLyFileHoSoThanhToanPublic Public)
        {
            
            int thamso = 8;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

                    bien[0]="@QLFHSTT_SoHoSo";
                    bien[1]="@QLFHSTT_NgayHoSo";
                    bien[2]="@QLFHSTT_TenFile";
                    bien[3]="@QLFHSTT_DataFile";
                    bien[4]="@QLFHSTT_GhiChu";
                    bien[5]="@HT_UserCreate";
                    bien[6]="@QLFHSTT_SuDung";
                    bien[7]="@QLFHSTT_HienThi";

                    giatri[0]=Public.QLFHSTT_SoHoSo ;
                    giatri[1]=Public.QLFHSTT_NgayHoSo ;
                    giatri[2]=Public.QLFHSTT_TenFile ;
                    giatri[3]=Public.QLFHSTT_DataFile ;
                    giatri[4]=Public.QLFHSTT_GhiChu ;
                    giatri[5]=Public.HT_UserCreate ;
                    giatri[6]=Public.QLFHSTT_SuDung  ;
                    giatri[7]=Public.QLFHSTT_HienThi  ;

            return cls.Update("SP_QuanLyFileHoSoThanhToan_Add", bien, giatri, thamso);
        }

        public int QL_QuanLyFileHoSoThanhToan_Sua(QuanLyFileHoSoThanhToanPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SQL
                    int thamso = 7;
                    string[] bien = new string[thamso];
                    object[] giatri = new object[thamso];

                    bien[0]="@QLFHSTT_Ma";
                    bien[1]="@QLFHSTT_SoHoSo";
                    bien[2]="@QLFHSTT_NgayHoSo";
                    bien[3]="@QLFHSTT_TenFile";
                    bien[4]="@QLFHSTT_DataFile";
                    bien[5]="@QLFHSTT_GhiChu";
                    bien[6]="@HT_UserEditor";

                    giatri[0]=Public.QLFHSTT_Ma ;
                    giatri[1]=Public.QLFHSTT_SoHoSo ;
                    giatri[2]=Public.QLFHSTT_NgayHoSo ;
                    giatri[3]=Public.QLFHSTT_TenFile ;
                    giatri[4]=Public.QLFHSTT_DataFile ;
                    giatri[5]=Public.QLFHSTT_GhiChu ;
                    giatri[6]=Public.HT_UserEditor  ;

            return cls.Update("SP_QuanLyFileHoSoThanhToan_Edit", bien, giatri, thamso);
        }


        public SqlDataReader TS_QuanLyFileHoSoThanhToan_Load_R_Para_File(QuanLyFileHoSoThanhToanPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            bien[0] = "@QLFHSTT_Ma";
            giatri[0] = Public.QLFHSTT_Ma;

            return cls.LayDuLieu_R("SP_QuanLyFileHoSoThanhToan_Load_R_Para_File", bien, giatri, thamso);
        }
    }
}
