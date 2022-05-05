using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Public;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class QuanLyDonViData
    {
        ClsKetNoi cls = new ClsKetNoi();
        
        QuanLyDonViPublic Public = new QuanLyDonViPublic();

        public DataTable TS_QuanLyDonVi_Load()
        {
            return cls.LayDuLieu("SP_QuanLyDonVi_Load");
        }

        public int TS_QuanLyDonVi_Xoa(QuanLyDonViPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@QLDV_Ma";
            giatri[0] = Public.QLDV_Ma;
            return cls.Update("SP_QuanLyDonVi_Del", bien, giatri, thamso);
        }

        public int TS_QuanLyDonVi_Them(QuanLyDonViPublic Public)
        {
            
            int thamso = 7;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0]="@QLDV_MaDonVi";
            bien[1]="@QLDV_TenDonVi";
            bien[2]="@QLDV_MoTa";
            bien[3]="@QLDV_GhiChu";
            bien[4]="@HT_UserCreate";
            bien[5]="@QLDV_SuDung";
            bien[6]="@QLDV_HienThi";

            giatri[0]=Public.QLDV_MaDonVi;
            giatri[1]=Public.QLDV_TenDonVi;
            giatri[2]=Public.QLDV_MoTa ;
            giatri[3]=Public.QLDV_GhiChu ;
            giatri[4]=Public.HT_UserCreate ;
            giatri[5]=Public.QLDV_SuDung ;
            giatri[6]=Public.QLDV_HienThi;

            return cls.Update("SP_QuanLyDonVi_Add", bien, giatri, thamso);
        }

        public int TS_QuanLyDonVi_Sua(QuanLyDonViPublic Public)
        {
            //Không cập nhật Demo_DateEditor => Lấy ngày giờ trên hệ thống máy chủ SQL
            int thamso = 6;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@QLDV_Ma";
            bien[1] = "@QLDV_MaDonVi";
            bien[2] = "@QLDV_TenDonVi";
            bien[3] = "@QLDV_MoTa";
            bien[4] = "@QLDV_GhiChu";
            bien[5] = "@HT_UserEditor";

            giatri[0] = Public.QLDV_Ma;
            giatri[1] = Public.QLDV_MaDonVi;
            giatri[2] = Public.QLDV_TenDonVi;
            giatri[3] = Public.QLDV_MoTa;
            giatri[4] = Public.QLDV_GhiChu;
            giatri[5] = Public.HT_UserEditor;

            return cls.Update("SP_QuanLyDonVi_Edit", bien, giatri, thamso);
        }

        public SqlDataReader TS_QuanLyDonVi_Load_R_Para_File(QuanLyDonViPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@QLDV_Ma";
            giatri[0] = Public.QLDV_Ma;
            return cls.LayDuLieu_R("SP_QuanLyDonVi_Load_R_Para_File", bien, giatri, thamso);
        }


        public SqlDataReader TS_QuanLyDonVi_ASP_Load_R_Para_File(QuanLyDonViPublic Public)
        {
            ClsKetNoiASP clsASP = new ClsKetNoiASP();
            return clsASP.LayDuLieuASP_R("SELECT * FROM QuanLyDonVi_View WHERE QLDV_Ma = "+Public.QLDV_Ma);
        }
    }
}
